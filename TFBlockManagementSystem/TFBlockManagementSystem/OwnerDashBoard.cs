using System;
using System.Windows.Forms;

namespace TFBlockManagementSystem
{
    public partial class OwnerDashBoard : Form
    {
        public OwnerDashBoard()
        {
            InitializeComponent();
        }

        private void OwnerDashBoard_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome, Factory Owner!";
        }

        // ----- Button 1: Manage Workers -----
        private void buttonManageWorkers_Click(object sender, EventArgs e)
        {
            // Open worker management form
            ManageWorkers workersForm = new ManageWorkers();
            workersForm.Show();
        }

        // ----- Button 2: Manage Raw Materials -----
        private void buttonRawMaterials_Click(object sender, EventArgs e)
        {
            // Example: Open raw material addition or management form
            RawMaterial materialForm = new RawMaterial();
            materialForm.Show();
        }

        // ----- Button 3: View Payments -----
        private void buttonPayments_Click(object sender, EventArgs e)
        {
            // Open payments record form
            Payments payments = new Payments();
            payments.Show();
        }

        // ----- Button 4: View Reports -----
        private void buttonReports_Click(object sender, EventArgs e)
        {
            // Open reports form
            Reports reports = new Reports();
            reports.Show();
        }

        // ----- Button 5: Logout -----
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TF Block Management System");
        }
    }
}
