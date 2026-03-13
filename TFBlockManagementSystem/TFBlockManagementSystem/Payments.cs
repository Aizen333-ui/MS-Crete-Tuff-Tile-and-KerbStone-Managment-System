using System;
using System.Data;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace TFBlockManagementSystem
{
    public partial class Payments : UserControl
    {
        ErrorProvider error = new ErrorProvider();

        public Payments()
        {
            InitializeComponent();

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

            LoadPayments();
        }

        private void LoadPayments()
        {
            try
            {
                DataTable dt = DbHelper.ExecuteDataTable("SELECT * FROM Payments ORDER BY PaymentID DESC");

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;

                // Amount column Rs format
                if (dataGridView1.Columns.Contains("Amount"))
                {
                    dataGridView1.Columns["Amount"].DefaultCellStyle.Format = "'Rs '0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payments: " + ex.Message);
            }
        }


        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text.Replace("Rs", "").Trim(), out decimal amount))
            {
                txtAmount.Text = "Rs " + amount.ToString();
                txtAmount.SelectionStart = txtAmount.Text.Length;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            string amountText = txtAmount.Text.Replace("Rs", "").Trim();
            string reason = cmbReason.Text.Trim();
            DateTime date = datePaid.Value;

            if (!Regex.IsMatch(id, @"^[1-9]{1,10}$"))
            {
                MessageBox.Show("Payment ID must be 1–10 digits.");
                return;
            }

            if (!decimal.TryParse(amountText, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Enter valid amount.");
                return;
            }

            if (string.IsNullOrEmpty(reason))
            {
                MessageBox.Show("Reason required.");
                return;
            }
            if (date.Date > DateTime.Today)
            {
                MessageBox.Show("Future date not allowed. Only today or past date allowed.");
                return;
            }



            try
            {
                string query =
                    "INSERT INTO Payments (PaymentID, Amount, Reason, DatePaid) VALUES (@id, @amount, @reason, @date)";

                SqlParameter[] p =
                {
                    new SqlParameter("@id", Convert.ToInt32(id)),
                    new SqlParameter("@amount", amount),
                    new SqlParameter("@reason", reason),
                    new SqlParameter("@date", date)
                };

                DbHelper.ExecuteNonQuery(query, p);
                MessageBox.Show("Payment added!");

                LoadPayments();

                txtID.Clear();
                txtAmount.Clear();
                cmbReason.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row to delete!");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PaymentID"].Value);

            // ✔ Confirmation message
            DialogResult dr = MessageBox.Show(
                "Are you sure you want to delete this payment?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dr != DialogResult.Yes)
                return;

            try
            {
                DbHelper.ExecuteNonQuery("DELETE FROM Payments WHERE PaymentID = @id",
                    new SqlParameter[] { new SqlParameter("@id", id) });

                MessageBox.Show("Payment deleted!");
                LoadPayments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting: " + ex.Message);
            }
        }
    }
}
