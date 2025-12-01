using Factory1_Dashboard.Pages;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TFBlockManagementSystem
{
    public partial class Factory1Dashboard : Form
    {
        public Factory1Dashboard()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Factory1Dashboard_Load(object sender, EventArgs e)
        {
            // Transparent side menu
            panelSideMenu.BackColor = Color.FromArgb(150, 30, 30, 30);

            // Button styling
            StyleButton(btnRecord);
            StyleButton(btnRaw);
            StyleButton(btnReport);

            // Logout button style
            btnLogout.BackColor = Color.Red;
            btnLogout.ForeColor = Color.White;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
        }

        // Universal style method
        private void StyleButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(50, 50, 50);
            btn.ForeColor = Color.White;
            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(70, 70, 70);
            btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(50, 50, 50);
        }

        // Load content inside main panel
        private void LoadPage(UserControl page)
        {
            panelMain.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panelMain.Controls.Add(page);
            page.BringToFront();
        }

        // BUTTON NAVIGATION
        private void btnRecord_Click(object sender, EventArgs e)
        {
            LoadPage(new RecordProduction1());
        }

        private void btnRaw_Click(object sender, EventArgs e)
        {
            LoadPage(new RawMaterialUsage1());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            LoadPage(new Report1());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to Logout?", "Confirm",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // GRADIENT BACKGROUND
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(230, 230, 230),
                Color.FromArgb(180, 180, 200),
                90F);

            e.Graphics.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
