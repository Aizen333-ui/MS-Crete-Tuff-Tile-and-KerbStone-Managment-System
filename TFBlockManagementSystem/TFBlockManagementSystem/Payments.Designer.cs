namespace TFBlockManagementSystem
{
    partial class Payments
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReason;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePaid;

        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.DataGridView dataGridView1;

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
            this.label1 = new Label();
            this.txtID = new TextBox();

            this.label2 = new Label();
            this.txtAmount = new TextBox();

            this.label3 = new Label();
            this.txtReason = new TextBox();

            this.label4 = new Label();
            this.datePaid = new DateTimePicker();

            this.btnAdd = new Button();
            this.dataGridView1 = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // Payment ID
            this.label1.Text = "Payment ID:";
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.AutoSize = true;

            this.txtID.Location = new System.Drawing.Point(150, 30);
            this.txtID.Width = 220;

            // Amount
            this.label2.Text = "Amount:";
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.AutoSize = true;

            this.txtAmount.Location = new System.Drawing.Point(150, 80);
            this.txtAmount.Width = 220;

            // Reason
            this.label3.Text = "Reason:";
            this.label3.Location = new System.Drawing.Point(30, 130);
            this.label3.AutoSize = true;

            this.txtReason.Location = new System.Drawing.Point(150, 130);
            this.txtReason.Width = 220;

            // Date
            this.label4.Text = "Date Paid:";
            this.label4.Location = new System.Drawing.Point(30, 180);
            this.label4.AutoSize = true;

            this.datePaid.Location = new System.Drawing.Point(150, 180);
            this.datePaid.Width = 220;

            // Add Payment Button
            this.btnAdd.Text = "Add Payment";
            this.btnAdd.Width = 150;
            this.btnAdd.Location = new System.Drawing.Point(150, 230);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // DataGridView Setup
            this.dataGridView1.Location = new System.Drawing.Point(30, 300);
            this.dataGridView1.Size = new System.Drawing.Size(600, 260);
            this.dataGridView1.ColumnCount = 4;
            this.dataGridView1.Columns[0].Name = "Payment ID";
            this.dataGridView1.Columns[1].Name = "Amount";
            this.dataGridView1.Columns[2].Name = "Reason";
            this.dataGridView1.Columns[3].Name = "Date Paid";

            // Add Controls
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datePaid);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);

            this.Size = new System.Drawing.Size(700, 600);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
