namespace TFBlockManagementSystem
{
    partial class Reports
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ListBox lstMaterials;
        private System.Windows.Forms.ListBox lstWorkers;
        private System.Windows.Forms.ListBox lstPayments;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstMaterials = new System.Windows.Forms.ListBox();
            this.lstWorkers = new System.Windows.Forms.ListBox();
            this.lstPayments = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // lstMaterials
            this.lstMaterials.Location = new System.Drawing.Point(20, 20);
            this.lstMaterials.Size = new System.Drawing.Size(400, 150);

            // lstWorkers
            this.lstWorkers.Location = new System.Drawing.Point(20, 190);
            this.lstWorkers.Size = new System.Drawing.Size(400, 150);

            // lstPayments
            this.lstPayments.Location = new System.Drawing.Point(20, 360);
            this.lstPayments.Size = new System.Drawing.Size(400, 150);

            // Reports Form
            this.ClientSize = new System.Drawing.Size(450, 530);
            this.Controls.Add(this.lstMaterials);
            this.Controls.Add(this.lstWorkers);
            this.Controls.Add(this.lstPayments);
            this.Text = "Factory Reports";

            this.ResumeLayout(false);
        }
    }
}
