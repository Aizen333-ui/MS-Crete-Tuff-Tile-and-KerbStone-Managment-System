/*namespace TFBlockManagementSystem
{
    partial class ManageWorkers
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWorkerID;
        private System.Windows.Forms.Label lblWorkerName;
        private System.Windows.Forms.TextBox txtWorkerID;
        private System.Windows.Forms.TextBox txtWorkerName;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.Button btnRemoveWorker;
        private System.Windows.Forms.ListBox lstWorkers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWorkerID = new System.Windows.Forms.Label();
            this.lblWorkerName = new System.Windows.Forms.Label();
            this.txtWorkerID = new System.Windows.Forms.TextBox();
            this.txtWorkerName = new System.Windows.Forms.TextBox();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.btnRemoveWorker = new System.Windows.Forms.Button();
            this.lstWorkers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(180, 20);
            this.lblTitle.Size = new System.Drawing.Size(200, 32);
            this.lblTitle.Text = "Manage Workers";

            // lblWorkerID
            this.lblWorkerID.AutoSize = true;
            this.lblWorkerID.Location = new System.Drawing.Point(50, 80);
            this.lblWorkerID.Size = new System.Drawing.Size(70, 20);
            this.lblWorkerID.Text = "Worker ID:";

            // lblWorkerName
            this.lblWorkerName.AutoSize = true;
            this.lblWorkerName.Location = new System.Drawing.Point(50, 120);
            this.lblWorkerName.Size = new System.Drawing.Size(95, 20);
            this.lblWorkerName.Text = "Worker Name:";

            // txtWorkerID
            this.txtWorkerID.Location = new System.Drawing.Point(170, 77);
            this.txtWorkerID.Size = new System.Drawing.Size(200, 27);

            // txtWorkerName
            this.txtWorkerName.Location = new System.Drawing.Point(170, 117);
            this.txtWorkerName.Size = new System.Drawing.Size(200, 27);

            // btnAddWorker
            this.btnAddWorker.Location = new System.Drawing.Point(400, 75);
            this.btnAddWorker.Size = new System.Drawing.Size(120, 30);
            this.btnAddWorker.Text = "Add Worker";
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);

            // btnRemoveWorker
            this.btnRemoveWorker.Location = new System.Drawing.Point(400, 115);
            this.btnRemoveWorker.Size = new System.Drawing.Size(120, 30);
            this.btnRemoveWorker.Text = "Remove Worker";
            this.btnRemoveWorker.Click += new System.EventHandler(this.btnRemoveWorker_Click);

            // lstWorkers
            this.lstWorkers.Location = new System.Drawing.Point(50, 160);
            this.lstWorkers.Size = new System.Drawing.Size(470, 200);

            // ManageWorkers Form
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblWorkerID);
            this.Controls.Add(this.lblWorkerName);
            this.Controls.Add(this.txtWorkerID);
            this.Controls.Add(this.txtWorkerName);
            this.Controls.Add(this.btnAddWorker);
            this.Controls.Add(this.btnRemoveWorker);
            this.Controls.Add(this.lstWorkers);

            this.Name = "ManageWorkers";
            this.Text = "Manage Workers";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
*/