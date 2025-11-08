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

        // This method runs when the Login button is clicked
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "owner" && password == "owner123")
            {
                MessageBox.Show("Owner logged in!");
            }
            else if (username == "manager" && password == "manager123")
            {
                MessageBox.Show("Manager logged in!");
            }
            else if (username == "factory1" && password == "f1pass")
            {
                MessageBox.Show("Factory Manager logged in!");
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }
    }
}
