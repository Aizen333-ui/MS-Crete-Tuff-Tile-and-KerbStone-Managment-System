using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TFBlockManagementSystem
{
    public partial class OwnerDashBoard : Form
    {
        private List<WorkerItem> workers;
        private List<RawMaterialItem> rawMaterials;
        private List<PaymentItem> payments;

        public OwnerDashBoard(List<WorkerItem> workers, List<RawMaterialItem> rawMaterials, List<PaymentItem> payments)
        {
            InitializeComponent();
            this.workers = workers;
            this.rawMaterials = rawMaterials;
            this.payments = payments;
        }

        private void OwnerDashBoard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, Factory Owner!";
        }

        private void buttonManageWorkers_Click(object sender, EventArgs e)
        {
            ManageWorkers mwForm = new ManageWorkers(workers);
            mwForm.ShowDialog();
        }

        private void buttonRawMaterials_Click(object sender, EventArgs e)
        {
            RawMaterial rmForm = new RawMaterial(rawMaterials);
            rmForm.ShowDialog();
        }

        private void buttonPayments_Click(object sender, EventArgs e)
        {
            Payments paymentForm = new Payments(payments, workers);
            paymentForm.ShowDialog();

        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            Reports repForm = new Reports(workers, rawMaterials, payments);
            repForm.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
