using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TFBlockManagementSystem
{
    public partial class RawMaterial : Form
    {
        private List<RawMaterialItem> rawMaterials;

        public RawMaterial(List<RawMaterialItem> rawMaterials)
        {
            InitializeComponent();
            this.rawMaterials = rawMaterials;
            UpdateMaterialList();
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaterialID.Text.Trim(), out int id) || id <= 0)
            {
                MessageBox.Show("Material ID must be a positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtMaterialName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Material name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQuantity.Text.Trim(), out int qty) || qty <= 0)
            {
                MessageBox.Show("Quantity must be a positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prevent duplicate ID with different name
            RawMaterialItem existing = rawMaterials.Find(m => m.ID == id);
            if (existing != null)
            {
                if (existing.Name != name)
                {
                    MessageBox.Show("This Material ID is already used for another material.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                existing.Quantity += qty;
            }
            else
            {
                rawMaterials.Add(new RawMaterialItem(id, name, qty));
            }

            MessageBox.Show("Raw material added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
            UpdateMaterialList();
        }

        private void btnRemoveMaterial_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaterialID.Text.Trim(), out int id))
            {
                MessageBox.Show("Material ID must be valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQuantity.Text.Trim(), out int removeQty))
            {
                MessageBox.Show("Quantity must be valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RawMaterialItem existing = rawMaterials.Find(m => m.ID == id);
            if (existing == null)
            {
                MessageBox.Show("Material ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (removeQty >= existing.Quantity)
                rawMaterials.Remove(existing);
            else
                existing.Quantity -= removeQty;

            MessageBox.Show("Raw material updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
            UpdateMaterialList();
        }

        private void UpdateMaterialList()
        {
            lstMaterials.Items.Clear();
            if (rawMaterials.Count == 0)
                lstMaterials.Items.Add("No raw materials available.");
            else
                foreach (var m in rawMaterials)
                    lstMaterials.Items.Add(m.ToString());
        }

        private void ClearInputs()
        {
            txtMaterialID.Clear();
            txtMaterialName.Clear();
            txtQuantity.Clear();
        }
    }
}
