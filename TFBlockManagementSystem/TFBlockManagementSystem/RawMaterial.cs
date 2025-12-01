using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using TFBlockManagementSystem;

namespace TFBlockManagementSystem
{
    public partial class RawMaterial : UserControl
    {
        public RawMaterial()
        {
            InitializeComponent();
            LoadMaterials();
        }


    // ----------------------------
    // LOAD MATERIALS INTO DATAGRID
    // ----------------------------
    private void LoadMaterials()
        {
            try
            {
                DataTable dt = DbHelper.ExecuteDataTable("SELECT * FROM RawMaterials ORDER BY MaterialID DESC");
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading materials: " + ex.Message);
            }
        }

        // ----------------------------
        // GET UNIT BASED ON MATERIAL
        // ----------------------------
        private string GetUnit(string materialName)
        {
            return materialName switch
            {
                "Cement" => "Tons",
                "Sand" => "CFT",
                "Crush" => "CFT",
                "Steel" => "KG",
                "Mold Oil" => "Liters",
                _ => ""
            };
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUnit.Text = GetUnit(cmbName.SelectedItem?.ToString() ?? "");
        }

        // ----------------------------
        // CHECK DUPLICATE MATERIAL ID
        // ----------------------------
        private bool MaterialIdExists(string id)
        {
            string query = "SELECT COUNT(*) FROM RawMaterials WHERE MaterialID = @id";
            object? result = DbHelper.ExecuteScalar(query, new SqlParameter[] { new SqlParameter("@id", id) });
            return result != null && Convert.ToInt32(result) > 0;
        }

        // ----------------------------
        // ADD MATERIAL
        // ----------------------------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            string name = cmbName.Text.Trim();
            string qty = txtQty.Text.Trim();
            string unit = txtUnit.Text.Trim();
            DateTime date = dateAdded.Value;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(qty) || string.IsNullOrEmpty(unit))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            if (!Regex.IsMatch(id, @"^[0-9]{1,10}$"))
            {
                MessageBox.Show("Material ID must contain numbers only (1–10 digits).");
                return;
            }

            if (MaterialIdExists(id))
            {
                MessageBox.Show("This Material ID already exists!");
                return;
            }

            if (!decimal.TryParse(qty, out decimal quantity) || quantity <= 0)
            {
                MessageBox.Show("Quantity must be a positive number.");
                return;
            }

            try
            {
                string query =
                    "INSERT INTO RawMaterials (MaterialID, MaterialName, Quantity, Unit, DateAdded) " +
                    "VALUES (@id, @name, CAST(@qty AS decimal(18,0)), @unit, @date)";

                SqlParameter[] p =
                {
                new SqlParameter("@id", id),
                new SqlParameter("@name", name),
                new SqlParameter("@qty", quantity),
                new SqlParameter("@unit", unit),
                new SqlParameter("@date", date)
            };

                DbHelper.ExecuteNonQuery(query, p);
                MessageBox.Show("Material added successfully!");
                LoadMaterials();

                txtID.Clear();
                txtQty.Clear();
                txtUnit.Clear();
                cmbName.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding material: " + ex.Message);
            }
        }

        // ----------------------------
        // REMOVE MATERIAL FROM BOTH FACTORIES
        // ----------------------------
        // ----------------------------
        // REMOVE MATERIAL FROM BOTH FACTORIES
        // ----------------------------
        private void BtnRemove_Click(object? sender, EventArgs e)
        {
            string material = cmbName.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(material))
            {
                MessageBox.Show("Select a material to remove.");
                return;
            }

            if (!int.TryParse(txtQty.Text.Trim(), out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Enter a valid quantity to remove.");
                txtQty.Focus();
                return;
            }

            DialogResult dr = MessageBox.Show(
                $"Are you sure you want to remove {quantity} {GetUnit(material)} of {material} from both factories?",
                "Confirm Remove",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dr != DialogResult.Yes)
                return;

            // Remove from Factory1
            bool removedFactory1 = RawMaterialDb.RemoveQuantity(material, quantity, "Factory1");

            // Remove from Factory2
            bool removedFactory2 = RawMaterialDb.RemoveQuantity(material, quantity, "Factory2");

            if (removedFactory1 || removedFactory2)
            {
                MessageBox.Show("Raw material entry removed successfully!");
                txtQty.Clear();
                cmbName.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("No material was removed. Please check if it exists in the factories.");
            }
        }


    }


}
