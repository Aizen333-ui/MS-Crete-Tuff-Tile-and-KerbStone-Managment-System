using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace TFBlockManagementSystem
{
    partial class OwnerDashBoard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            buttonManageWorkers = new Button();
            buttonRawMaterials = new Button();
            buttonPayments = new Button();
            buttonReports = new Button();
            buttonLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(250, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(291, 38);
            label1.TabIndex = 0;
            label1.Text = "Owner Dashboard";
            label1.Click += label1_Click;
            // 
            // buttonManageWorkers
            // 
            buttonManageWorkers.Location = new System.Drawing.Point(310, 120);
            buttonManageWorkers.Name = "buttonManageWorkers";
            buttonManageWorkers.Size = new System.Drawing.Size(180, 40);
            buttonManageWorkers.TabIndex = 1;
            buttonManageWorkers.Text = "Manage Workers";
            buttonManageWorkers.UseVisualStyleBackColor = true;
            buttonManageWorkers.Click += buttonManageWorkers_Click;
            // 
            // buttonRawMaterials
            // 
            buttonRawMaterials.Location = new System.Drawing.Point(310, 180);
            buttonRawMaterials.Name = "buttonRawMaterials";
            buttonRawMaterials.Size = new System.Drawing.Size(180, 40);
            buttonRawMaterials.TabIndex = 2;
            buttonRawMaterials.Text = "Manage Raw Materials";
            buttonRawMaterials.UseVisualStyleBackColor = true;
            buttonRawMaterials.Click += buttonRawMaterials_Click;
            // 
            // buttonPayments
            // 
            buttonPayments.Location = new System.Drawing.Point(310, 240);
            buttonPayments.Name = "buttonPayments";
            buttonPayments.Size = new System.Drawing.Size(180, 40);
            buttonPayments.TabIndex = 3;
            buttonPayments.Text = "View Payments";
            buttonPayments.UseVisualStyleBackColor = true;
            buttonPayments.Click += buttonPayments_Click;
            // 
            // buttonReports
            // 
            buttonReports.Location = new System.Drawing.Point(310, 300);
            buttonReports.Name = "buttonReports";
            buttonReports.Size = new System.Drawing.Size(180, 40);
            buttonReports.TabIndex = 4;
            buttonReports.Text = "View Reports";
            buttonReports.UseVisualStyleBackColor = true;
            buttonReports.Click += buttonReports_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new System.Drawing.Point(310, 360);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new System.Drawing.Size(180, 40);
            buttonLogout.TabIndex = 5;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // OwnerDashBoard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(buttonLogout);
            Controls.Add(buttonReports);
            Controls.Add(buttonPayments);
            Controls.Add(buttonRawMaterials);
            Controls.Add(buttonManageWorkers);
            Controls.Add(label1);
            Name = "OwnerDashBoard";
            Text = "Owner Dashboard";
            Load += OwnerDashBoard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonManageWorkers;
        private Button buttonRawMaterials;
        private Button buttonPayments;
        private Button buttonReports;
        private Button buttonLogout;
    }
}
