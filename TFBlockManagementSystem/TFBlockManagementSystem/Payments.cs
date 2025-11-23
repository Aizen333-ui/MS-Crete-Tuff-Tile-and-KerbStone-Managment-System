using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TFBlockManagementSystem
{
    public partial class Payments : UserControl
    {
        ErrorProvider error = new ErrorProvider();

        public Payments()
        {
            InitializeComponent();

            // Reason items
            cmbReason.Items.AddRange(new object[]
            {
                "Cement Purchase",
                "Sand Purchase",
                "Crush Purchase",
                "Steel Purchase",
                "Worker Salary",
                "Diesel Expense",
                "Machine Maintenance",
                "Factory Rent",
                "Other Expense"
            });

            cmbReason.DropDownStyle = ComboBoxStyle.DropDownList;

           
        }

        // AUTO ADD "Rs "
        private bool isEditing = false;
        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {
            if (isEditing) return;

            isEditing = true;

            string txt = txtAmount.Text.Replace("Rs", "").Replace(" ", "");
            if (decimal.TryParse(txt, out decimal amount))
            {
                txtAmount.Text = "Rs " + amount.ToString();
                txtAmount.SelectionStart = txtAmount.Text.Length;
            }

            isEditing = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            error.Clear();

            string id = txtID.Text.Trim();
            string amountText = txtAmount.Text.Replace("Rs", "").Trim();
            string reason = cmbReason.Text.Trim();
            DateTime date = datePaid.Value;

            //  PAYMENT ID VALIDATION 
            if (!Regex.IsMatch(id, @"^[0-9]{3,10}$"))
            {
                MessageBox.Show("Payment ID must be 3–10 digits only.");
               
                return;
            }

            // Duplicate check
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == id)
                {
                   
                    MessageBox.Show("Payment ID already exists!");
                    return;
                }
            }

            //  AMOUNT VALIDATION 
            if (!decimal.TryParse(amountText, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Enter valid amount  ");
                return;
            }
            if (amount > 10000000)
            {
                MessageBox.Show( "Amount limit is 10,000,000");
                return;
            }

            string formattedAmount = "Rs " + amount.ToString("N0");

            //  REASON VALIDATION 
            if (string.IsNullOrEmpty(reason))
            {
                MessageBox.Show( "Reason is required");
                return;
            }

            //  DATE VALIDATION 
            DateTime selectedDate = datePaid.Value.Date;
            DateTime today = DateTime.Today;

            if (selectedDate > today)
            {
                MessageBox.Show( "Future date not allowed");
                return;
            }


            //  ADD TO DATAGRID 
            dataGridView1.Rows.Add(
                id,
                formattedAmount,
                reason,
                date.ToShortDateString()
            );

            // Clear fields
            txtID.Clear();
            txtAmount.Clear();
            cmbReason.SelectedIndex = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row to delete!", "Warning");
                return;
            }

            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
        }
    }
}
