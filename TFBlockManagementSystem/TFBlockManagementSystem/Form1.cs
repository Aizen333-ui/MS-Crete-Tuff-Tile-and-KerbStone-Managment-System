using System;
using System.Windows.Forms;

namespace TFBlockManagementSystem
{
    public partial class Form1 : Form
    {
        private List<WorkerItem> workers = new List<WorkerItem>();
        private List<RawMaterialItem> rawMaterials = new List<RawMaterialItem>();
        private List<PaymentItem> payments = new List<PaymentItem>();

        public Form1()
        {
            InitializeComponent();
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            // You can leave this empty if you don't need any logic here
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "owner" && password == "owner123")
            {
                MessageBox.Show("Owner logged in!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();  // Hide the login form
                OwnerDashBoard ownerForm = new OwnerDashBoard(workers, rawMaterials, payments); // Pass the shared lists
                ownerForm.ShowDialog();  // Show the owner dashboard
                this.Show();  // Show the login form again when the owner dashboard is closed
            }
            else if (username == "manager" && password == "manager123")
            {
                // manager login code...
            }
            else if (username == "factory1" && password == "f1pass")
            {
                // factory login code...
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
