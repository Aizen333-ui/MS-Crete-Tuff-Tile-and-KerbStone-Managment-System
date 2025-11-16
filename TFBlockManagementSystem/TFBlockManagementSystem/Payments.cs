using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TFBlockManagementSystem
{
    public partial class Payments : Form
    {
        private List<PaymentItem> payments;
        private List<WorkerItem> workers;

        public Payments(List<PaymentItem> payments, List<WorkerItem> workers)
        {
            InitializeComponent();
            this.payments = payments;
            this.workers = workers;
            UpdatePaymentList();
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            // Validate Payment ID
            if (!int.TryParse(txtPaymentID.Text.Trim(), out int id) || id <= 0)
            {
                MessageBox.Show("Payment ID must be a positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Amount
            if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Amount must be a positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add new payment
            payments.Add(new PaymentItem(id, amount));
            MessageBox.Show("Payment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearInputs();
            UpdatePaymentList();
        }


        private void UpdatePaymentList()
        {
            lstPayments.Items.Clear();
            if (payments.Count == 0)
                lstPayments.Items.Add("No payments yet.");
            else
                foreach (var p in payments)
                    lstPayments.Items.Add(p.ToString());
        }

        private void ClearInputs()
        {
            txtPaymentID.Clear();
            txtWorkerName.Clear();
            txtAmount.Clear();
            txtReason.Clear();
        }
    }
}
