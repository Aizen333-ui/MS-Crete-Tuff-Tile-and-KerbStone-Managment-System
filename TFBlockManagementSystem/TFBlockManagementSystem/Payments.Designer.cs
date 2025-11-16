namespace TFBlockManagementSystem
{
    partial class Payments
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPaymentID;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtPaymentID;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.ListBox lstPayments;
        private System.Windows.Forms.TextBox txtWorkerName;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPaymentID = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.lstPayments = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(180, 20);
            this.lblTitle.Size = new System.Drawing.Size(150, 32);
            this.lblTitle.Text = "Manage Payments";

            // lblPaymentID
            this.lblPaymentID.AutoSize = true;
            this.lblPaymentID.Location = new System.Drawing.Point(50, 80);
            this.lblPaymentID.Size = new System.Drawing.Size(85, 20);
            this.lblPaymentID.Text = "Payment ID:";

            // lblAmount
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(50, 120);
            this.lblAmount.Size = new System.Drawing.Size(60, 20);
            this.lblAmount.Text = "Amount:";

            // lblReason
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(50, 160);
            this.lblReason.Size = new System.Drawing.Size(55, 20);
            this.lblReason.Text = "Reason:";

            // txtPaymentID
            this.txtPaymentID.Location = new System.Drawing.Point(150, 77);
            this.txtPaymentID.Size = new System.Drawing.Size(200, 27);

            // txtAmount
            this.txtAmount.Location = new System.Drawing.Point(150, 117);
            this.txtAmount.Size = new System.Drawing.Size(200, 27);

            // txtReason
            this.txtReason.Location = new System.Drawing.Point(150, 157);
            this.txtReason.Size = new System.Drawing.Size(200, 27);

            // btnAddPayment
            this.btnAddPayment.Location = new System.Drawing.Point(380, 77);
            this.btnAddPayment.Size = new System.Drawing.Size(120, 30);
            this.btnAddPayment.Text = "Add Payment";
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);

            // lstPayments
            this.lstPayments.Location = new System.Drawing.Point(50, 200);
            this.lstPayments.Size = new System.Drawing.Size(450, 200);

            //Worker Name 
            this.txtWorkerName = new TextBox();
            this.txtWorkerName.Location = new Point(170, 50);
            this.txtWorkerName.Size = new Size(200, 27);
            // Payments Form
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPaymentID);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.txtPaymentID);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.lstPayments);
            this.Controls.Add(txtWorkerName);
            this.Name = "Payments";
            this.Text = "Payments Management";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
