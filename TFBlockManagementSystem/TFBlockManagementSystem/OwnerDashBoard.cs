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

        // --- PAGE LOAD FUNCTION ---
        private void LoadPage(UserControl page)
        {
            panelMain.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panelMain.Controls.Add(page);
            page.BringToFront();
        }

        // --- MENU CLICK EVENTS ---

        private void btnRawMaterial_Click(object sender, EventArgs e)
        {
            LoadPage(new RawMaterial());
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            LoadPage(new Payments());
        }

        private void btnManageWorkers_Click(object sender, EventArgs e)
        {
            LoadPage(new WorkersAddandView());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            LoadPage(new OwnerReportsPage());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to Logout?", "Confirm",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
