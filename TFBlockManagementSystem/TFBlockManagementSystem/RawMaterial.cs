using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TFBlockManagementSystem
{
    public partial class RawMaterial : UserControl
    {
        public RawMaterial()
        {
            InitializeComponent();
        }

        //   Unit Auto 
        private string GetUnit(string materialName)
        {
            switch (materialName)
            {
                case "Cement": return "Tons";
                case "Sand": return "CFT";
                case "Crush": return "CFT";
                case "Steel": return "KG";
                case "Fly Ash": return "Bags";
                case "Mold Oil": return "Liters";
                default: return "";
            }
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUnit.Text = GetUnit(cmbName.SelectedItem?.ToString() ?? "");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            string name = cmbName.SelectedItem?.ToString() ?? "";
            string qty = txtQty.Text.Trim();
            string unit = txtUnit.Text.Trim();

            // Required fields
            if (id == "" || name == "" || qty == "" || unit == "")
            {
                MessageBox.Show("Please fill all fields!", "Warning");
                return;
            }

            // Material ID validation
            if (!Regex.IsMatch(id, @"^[a-zA-Z0-9]{3,10}$"))
            {
                MessageBox.Show("Material ID must be 3–10 characters (letters/numbers only).\nExample: RM001", "Invalid ID");
                return;
            }

            // Duplicate ID
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == id)
                {
                    MessageBox.Show("Material ID already exists!", "Duplicate ID");
                    return;
                }
            }

            // Quantity
            if (!decimal.TryParse(qty, out decimal quantity) || quantity <= 0)
            {
                MessageBox.Show("Quantity must be a number greater than 0.", "Invalid Quantity");
                return;
            }

            // ADD ROW
            dataGridView1.Rows.Add(id, name, quantity + " " + unit, dateAdded.Value.ToShortDateString());

            // CLEAR
            txtID.Clear();
            txtQty.Clear();
            txtUnit.Clear();
            cmbName.SelectedIndex = -1;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Please select a row to remove!");
            }
        }
    }
}
