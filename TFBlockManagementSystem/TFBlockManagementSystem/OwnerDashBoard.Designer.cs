namespace TFBlockManagementSystem
{
    partial class OwnerDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Button btnRawMaterial;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnManageWorkers;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;

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
            this.btnReports = new System.Windows.Forms.Button();
            this.btnManageWorkers = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnRawMaterial = new System.Windows.Forms.Button();

            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();

            this.panelMain = new System.Windows.Forms.Panel();

            this.panelSideMenu.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(32, 56, 100);
            this.panelSideMenu.Controls.Add(this.btnLogout);
            this.panelSideMenu.Controls.Add(this.btnReports);
            this.panelSideMenu.Controls.Add(this.btnManageWorkers);
            this.panelSideMenu.Controls.Add(this.btnPayments);
            this.panelSideMenu.Controls.Add(this.btnRawMaterial);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 600);
            this.panelSideMenu.TabIndex = 0;

            // 
            // btnRawMaterial
            // 
            this.btnRawMaterial.FlatAppearance.BorderSize = 0;
            this.btnRawMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRawMaterial.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRawMaterial.ForeColor = System.Drawing.Color.White;
            this.btnRawMaterial.Location = new System.Drawing.Point(0, 80);
            this.btnRawMaterial.Name = "btnRawMaterial";
            this.btnRawMaterial.Size = new System.Drawing.Size(200, 50);
            this.btnRawMaterial.TabIndex = 0;
            this.btnRawMaterial.Text = "Raw Material";
            this.btnRawMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRawMaterial.UseVisualStyleBackColor = true;
            this.btnRawMaterial.Click += new System.EventHandler(this.btnRawMaterial_Click);

            // 
            // btnPayments
            // 
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.Location = new System.Drawing.Point(0, 140);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(200, 50);
            this.btnPayments.TabIndex = 1;
            this.btnPayments.Text = "Payments";
            this.btnPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);

            // 
            // btnManageWorkers
            // 
            this.btnManageWorkers.FlatAppearance.BorderSize = 0;
            this.btnManageWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageWorkers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnManageWorkers.ForeColor = System.Drawing.Color.White;
            this.btnManageWorkers.Location = new System.Drawing.Point(0, 200);
            this.btnManageWorkers.Name = "btnManageWorkers";
            this.btnManageWorkers.Size = new System.Drawing.Size(200, 50);
            this.btnManageWorkers.TabIndex = 2;
            this.btnManageWorkers.Text = "Manage Workers";
            this.btnManageWorkers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageWorkers.UseVisualStyleBackColor = true;
            this.btnManageWorkers.Click += new System.EventHandler(this.btnManageWorkers_Click);

            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(0, 260);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(200, 50);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);

            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(220, 20, 60);  // Red
            this.btnLogout.Location = new System.Drawing.Point(0, 520);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 50);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(200, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 60);
            this.panelHeader.TabIndex = 1;

            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(32, 56, 100);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 30);
            this.lblTitle.Text = "Owner Dashboard";

            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Location = new System.Drawing.Point(200, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 540);
            this.panelMain.TabIndex = 2;

            // 
            // OwnerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "OwnerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owner Dashboard";

            this.panelSideMenu.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
