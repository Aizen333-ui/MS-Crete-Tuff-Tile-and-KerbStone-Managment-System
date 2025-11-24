using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TFBlockManagementSystem
{
    public partial class WorkersAddandView : UserControl
    {
        ErrorProvider error = new ErrorProvider();
        private bool isEditing = false;

        public WorkersAddandView()
        {
            InitializeComponent();

            // Role options
            cmbRole.Items.AddRange(new object[]
            {
                "Labor",
                "Mason",
                "Driver",
                "Helper",
                "Manager",
                "Loader",
                "Machine Operator"
            });

            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;

            
        }

        // Auto Rs add
        private void TxtWage_TextChanged(object sender, EventArgs e)
        {
            if (isEditing) return;

            isEditing = true;
            string txt = txtWage.Text.Replace("Rs", "").Replace(" ", "");

            if (decimal.TryParse(txt, out decimal wage))
            {
                txtWage.Text = "Rs " + wage.ToString();
                txtWage.SelectionStart = txtWage.Text.Length;
            }

            isEditing = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            error.Clear();

            string name = txtName.Text.Trim();
            string role = cmbRole.Text.Trim();
            string wageTxt = txtWage.Text.Replace("Rs", "").Trim();

            // --- NAME VALIDATION ---
            if (!Regex.IsMatch(name, @"^[A-Za-z ]{3,30}$"))
            {
                MessageBox.Show("Worker name must contain alphabets only (3–30 chars).");
                return;
            }

            // --- ROLE VALIDATION ---
            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please select worker role.");
                return;
            }

            // --- WAGE VALIDATION ---
            if (!decimal.TryParse(wageTxt, out decimal wage) || wage < 200 || wage > 5000)
            {
                MessageBox.Show("Daily wage must be between 200 and 5000 PKR.");
                return;
            }

            // --- DUPLICATE CHECK ---
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == name &&
                    row.Cells[1].Value?.ToString() == role)
                {
                    MessageBox.Show("Worker already exists in record.");
                    return;
                }
            }

            // Add to table
            dataGridView1.Rows.Add(name, role, "Rs " + wage.ToString("N0"));

            txtName.Clear();
            txtWage.Clear();
            cmbRole.SelectedIndex = -1;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a worker to remove!");
                return;
            }

            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
        }
    }
}
