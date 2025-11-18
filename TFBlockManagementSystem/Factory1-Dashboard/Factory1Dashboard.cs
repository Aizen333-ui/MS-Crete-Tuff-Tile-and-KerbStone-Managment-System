using Factory1_Dashboard.Pages;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Factory1_Dashboard
{
    public partial class Factory1Dashboard : Form
    {
        public Factory1Dashboard()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Smooth UI
        }

        private void Factory1Dashboard_Load(object sender, EventArgs e)
        {
            // TRANSPARENT SIDE MENU (Dark Glass Effect)
            panelSideMenu.BackColor = Color.FromArgb(150, 30, 30, 30);

            // BUTTON STYLING
            StyleButton(btnRecord);
            StyleButton(btnRaw);
            StyleButton(btnReport);

            // LOGOUT BUTTON RED THEME
            btnLogout.BackColor = Color.Red;
            btnLogout.ForeColor = Color.White;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
        }

        // UNIVERSAL BUTTON STYLE
        private void StyleButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(50, 50, 50);
            btn.ForeColor = Color.White;
            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(70, 70, 70);
            btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(50, 50, 50);
        }

        // LOAD USER CONTROL INSIDE MAIN PANEL
        private void LoadPage(UserControl page)
        {
            panelMain.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panelMain.Controls.Add(page);
            page.BringToFront();
        }

        // BUTTON CALLS
        private void btnRecord_Click(object sender, EventArgs e)
        {
            LoadPage(new RecordProductionPage());
        }

        private void btnRaw_Click(object sender, EventArgs e)
        {
            LoadPage(new RawMaterialPage());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            LoadPage(new ReportPage());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // GRADIENT BACKGROUND
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(230, 230, 230),  // Light top color
                Color.FromArgb(180, 180, 200),  // Soft bottom color
                90F);

            e.Graphics.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
