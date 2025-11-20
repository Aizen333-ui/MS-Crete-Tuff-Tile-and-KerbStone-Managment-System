namespace Factory1_Dashboard
{
    partial class Factory1Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnRaw;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelMain;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        

        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnRaw = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();

            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(35, 35, 40);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Width = 220;
            this.panelSideMenu.Padding = new System.Windows.Forms.Padding(10);
            this.panelSideMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // btnRecord
            // 
            this.btnRecord.Text = "   Record Production";
            this.btnRecord.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRecord.ForeColor = System.Drawing.Color.White;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Location = new System.Drawing.Point(50, 75);
            this.btnRecord.Size = new System.Drawing.Size(150, 40);
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);

            // 
            // btnRaw
            // 
            this.btnRaw.Text = "   Raw Material";
            this.btnRaw.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRaw.ForeColor = System.Drawing.Color.White;
            this.btnRaw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaw.Location = new System.Drawing.Point(50, 135);
            this.btnRaw.Size = new System.Drawing.Size(150, 40);
            this.btnRaw.Click += new System.EventHandler(this.btnRaw_Click);

            // 
            // btnReport
            // 
            this.btnReport.Text = "   Report to Owner";
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Location = new System.Drawing.Point(50, 195);
            this.btnReport.Size = new System.Drawing.Size(150, 40);
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);

            // 
            // btnLogout
            // 
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.Height = 55;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // ADD BUTTONS TO SIDEBAR
            this.panelSideMenu.Controls.Add(this.btnRecord);
            this.panelSideMenu.Controls.Add(this.btnRaw);
            this.panelSideMenu.Controls.Add(this.btnReport);
            this.panelSideMenu.Controls.Add(this.btnLogout);

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(25, 25, 30);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 60;

            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Factory 1 Dashboard";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);

            this.panelHeader.Controls.Add(this.lblTitle);

            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.BackColor = System.Drawing.Color.Transparent;

            // 
            // Factory1Dashboard
            // 
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSideMenu);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factory Dashboard";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Load += new System.EventHandler(this.Factory1Dashboard_Load);
        }

        
    }
}
