using System;
using System.Linq;
using System.Windows.Forms;

namespace Factory2_Dashboard.Pages
{
    public partial class RawMaterialUsage2 : UserControl
    {
        public RawMaterialUsage2()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnClear.Click += BtnClear_Click;

            LoadMaterialOptions();
            dateMaterial.MaxDate = DateTime.Today;
        }

        private void LoadMaterialOptions()
        {
            cmbMaterialName.Items.Clear();
            cmbMaterialName.Items.AddRange(new object[]
            {
                "Cement",
                "Sand",
                "Gravel",
                "Steel",
                "Bricks"
            });
            cmbMaterialName.SelectedIndex = -1;
            cmbMaterialName.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            string material = cmbMaterialName.SelectedItem?.ToString();
            string quantityText = txtQuantity.Text.Trim();
            DateTime selectedDate = dateMaterial.Value.Date;

            // ✅ Material Name Validation
            if (string.IsNullOrEmpty(material))
            {
                MessageBox.Show("Please select a Material Name");
                cmbMaterialName.Focus();
                return;
            }

            // ✅ Quantity Validation
            if (string.IsNullOrEmpty(quantityText))
            {
                MessageBox.Show("Please enter Quantity");
                txtQuantity.Focus();
                return;
            }

            if (!int.TryParse(quantityText, out int quantity))
            {
                MessageBox.Show("Quantity must be an integer");
                txtQuantity.Focus();
                return;
            }

            if (quantity <= 0 || quantity > 10000)
            {
                MessageBox.Show("Quantity must be between 1 and 10000");
                txtQuantity.Focus();
                return;
            }

            // ✅ Date Validation
            if (selectedDate > DateTime.Today)
            {
                MessageBox.Show("Future date not allowed");
                return;
            }

            // ✅ Duplicate Entry Check
            bool exists = GlobalStorage.RawMaterials.Any(r =>
                r.MaterialName == material &&
                r.Quantity == quantity &&
                r.Date.Date == selectedDate);

            if (exists)
            {
                MessageBox.Show("Entry already exists for this material, quantity and date");
                return;
            }

            // ✅ Save
            GlobalStorage.RawMaterials.Add(new RawMaterialEntry
            {
                MaterialName = material,
                Quantity = quantity,
                Unit = GetUnitForMaterial(material), // automatically add unit
                Date = selectedDate
            });

            MessageBox.Show("Raw Material Saved!");

            // Clear fields
            ClearFields();
        }

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            cmbMaterialName.SelectedIndex = -1;
            txtQuantity.Clear();
            dateMaterial.Value = DateTime.Today;
        }

        private string GetUnitForMaterial(string material)
        {
            switch (material)
            {
                case "Cement":
                    return "Bag";
                case "Sand":
                case "Gravel":
                    return "Ton";
                case "Steel":
                    return "Kg";
                case "Bricks":
                    return "Pieces";
                default:
                    return "";
            }
        }
    }
}
