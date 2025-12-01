namespace Factory2_Dashboard.Pages
{
    partial class Report2
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.dataGridReport = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSendReport = new System.Windows.Forms.Button();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();

            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReport)).BeginInit();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.DarkBlue;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.ForeColor = System.Drawing.Color.White;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1050, 60);
            this.panelHeader.TabIndex = 0;

            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Factory Report to Owner";

            // panelSidebar
            this.panelSidebar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelSidebar.Controls.Add(this.btnReports);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 60);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 540);
            this.panelSidebar.TabIndex = 1;

            // btnReports
            this.btnReports.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Size = new System.Drawing.Size(160, 50);
            this.btnReports.Location = new System.Drawing.Point(
                (panelSidebar.Width - 160) / 2,
                (panelSidebar.Height - 50) / 2
            );
            this.btnReports.Name = "btnReports";
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Provide Report";
            this.btnReports.UseVisualStyleBackColor = false;

            // mainPanel
            this.mainPanel.Controls.Add(this.lblHeading);
            this.mainPanel.Controls.Add(this.dataGridReport);
            this.mainPanel.Controls.Add(this.btnGenerate);
            this.mainPanel.Controls.Add(this.btnSendReport);
            this.mainPanel.Controls.Add(this.dateFrom);
            this.mainPanel.Controls.Add(this.dateTo);
            this.mainPanel.Controls.Add(this.lblFrom);
            this.mainPanel.Controls.Add(this.lblTo);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(850, 540);
            this.mainPanel.TabIndex = 2;

            // lblHeading
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.Location = new System.Drawing.Point(20, 10);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(420, 40);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Generate Monthly Reports";

            // dataGridReport
            this.dataGridReport.BackgroundColor = System.Drawing.Color.White;
            this.dataGridReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReport.Location = new System.Drawing.Point(20, 170);
            this.dataGridReport.Name = "dataGridReport";
            this.dataGridReport.Size = new System.Drawing.Size(810, 350);
            this.dataGridReport.TabIndex = 5;

            // btnGenerate
            this.btnGenerate.BackColor = System.Drawing.Color.DarkBlue;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(350, 120);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(150, 35);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;

            // btnSendReport
            this.btnSendReport.BackColor = System.Drawing.Color.Green;
            this.btnSendReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSendReport.ForeColor = System.Drawing.Color.White;
            this.btnSendReport.Location = new System.Drawing.Point(520, 120);
            this.btnSendReport.Name = "btnSendReport";
            this.btnSendReport.Size = new System.Drawing.Size(150, 35);
            this.btnSendReport.TabIndex = 8;
            this.btnSendReport.Text = "Send to Owner";
            this.btnSendReport.UseVisualStyleBackColor = false;

            // dateFrom
            this.dateFrom.Location = new System.Drawing.Point(90, 80);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(230, 25);
            this.dateFrom.TabIndex = 1;

            // dateTo
            this.dateTo.Location = new System.Drawing.Point(460, 80);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(230, 25);
            this.dateTo.TabIndex = 2;

            // lblFrom
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFrom.Location = new System.Drawing.Point(20, 80);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(70, 25);
            this.lblFrom.TabIndex = 6;
            this.lblFrom.Text = "From:";

            // lblTo
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTo.Location = new System.Drawing.Point(410, 80);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(45, 25);
            this.lblTo.TabIndex = 7;
            this.lblTo.Text = "To:";

            // Report1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "Report1";
            this.Text = "Report to Owner";

            this.panelHeader.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReport)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.DataGridView dataGridReport;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSendReport;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
    }


}
