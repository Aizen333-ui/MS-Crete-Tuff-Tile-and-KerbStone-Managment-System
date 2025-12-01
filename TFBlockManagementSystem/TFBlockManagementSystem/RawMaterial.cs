using System;
using System.Data;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

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
        // LOAD MATERIALS
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
        // CHECK DUPLICATE ID
        // ----------------------------
        private bool MaterialIdExists(string id)
        {
            string query = "SELECT COUNT(*) FROM RawMaterials WHERE MaterialID = @id";

            object? result = DbHelper.ExecuteScalar(
                query,
                new SqlParameter[] { new SqlParameter("@id", id) }
            );

            if (result == null)
                return false;

            return Convert.ToInt32(result) > 0;
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

            // ----------- VALIDATION SECTION -----------
            if (id == "" || name == "" || qty == "" || unit == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            // ID must be numeric only (1–10 digits)
            if (!Regex.IsMatch(id, @"^[0-9]{1,10}$"))
            {
                MessageBox.Show("Material ID must contain **numbers only** (1–10 digits).\nExample: 1, 25, 788, 5001");
                return;
            }


            // Duplicate ID check
            if (MaterialIdExists(id))
            {
                MessageBox.Show("This Material ID already exists!");
                return;
            }

            // Quantity validation
            if (!decimal.TryParse(qty, out decimal quantity) || quantity <= 0)
            {
                MessageBox.Show("Quantity must be a positive number.");
                return;
            }

            // ----------- INSERT SECTION -----------
            try
            {
                // CAST to remove .0000
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
        // REMOVE MATERIAL
        // ----------------------------
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row to remove!");
                return;
            }

            string id = dataGridView1.SelectedRows[0].Cells["MaterialID"].Value?.ToString() ?? "";

            if (id == "")
            {
                MessageBox.Show("Invalid selection!");
                return;
            }

            DialogResult dr = MessageBox.Show(
                "Are you sure you want to delete this material?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dr != DialogResult.Yes)
                return;

            try
            {
                DbHelper.ExecuteNonQuery(
                    "DELETE FROM RawMaterials WHERE MaterialID = @id",
                    new SqlParameter[] { new SqlParameter("@id", id) });

                MessageBox.Show("Material removed!");
                LoadMaterials();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing material: " + ex.Message);
            }
        }

    }
}
