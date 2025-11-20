using System;
using System.Windows.Forms;

namespace TFBlockManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // -------------- OWNER LOGIN --------------
            if (username == "owner" && password == "owner123")
            {
                MessageBox.Show("Owner logged in!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                OwnerDashboard owner = new OwnerDashboard();

                this.Hide();        // Hide login form
                owner.FormClosed += (s, args) => this.Show();  // Show login when dashboard closes
                owner.Show();
                return;
            }

            // -------------- MANAGER LOGIN --------------
            if (username == "manager" && password == "manager123")
            {
                MessageBox.Show("Manager logged in!");

                // TODO: manager dashboard here...

                return;
            }

            // -------------- FACTORY 1 LOGIN --------------
            if (username == "factory1" && password == "f1pass")
            {
                MessageBox.Show("Factory 1 logged in!");

                // TODO: factory 1 dashboard...

                return;
            }

            // INVALID LOGIN
            MessageBox.Show("Invalid username or password!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
       
    }
}
