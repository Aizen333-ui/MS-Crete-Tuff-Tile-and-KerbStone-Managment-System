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
        private System.Windows.Forms.ComboBox cmbReason;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePaid;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();

            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();

            this.label3 = new System.Windows.Forms.Label();
            this.cmbReason = new System.Windows.Forms.ComboBox();

            this.label4 = new System.Windows.Forms.Label();
            this.datePaid = new System.Windows.Forms.DateTimePicker();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // Payment ID
            this.label1.Text = "Payment ID:";
            this.label1.Location = new System.Drawing.Point(30, 30);

            this.txtID.Location = new System.Drawing.Point(150, 30);
            this.txtID.Width = 220;

            // Amount
            this.label2.Text = "Amount:";
            this.label2.Location = new System.Drawing.Point(30, 80);

            this.txtAmount.Location = new System.Drawing.Point(150, 80);
            this.txtAmount.Width = 220;

            // Reason
            this.label3.Text = "Reason:";
            this.label3.Location = new System.Drawing.Point(30, 130);

            this.cmbReason.Location = new System.Drawing.Point(150, 130);
            this.cmbReason.Width = 220;

            // Date
            this.label4.Text = "Date Paid:";
            this.label4.Location = new System.Drawing.Point(30, 180);

            this.datePaid.Location = new System.Drawing.Point(150, 180);
            this.datePaid.Width = 220;

            // Add Button
            this.btnAdd.Text = "Add Payment";
            this.btnAdd.Width = 150;
            this.btnAdd.Location = new System.Drawing.Point(150, 230);
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // Delete Button
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.Width = 150;
            this.btnDelete.Location = new System.Drawing.Point(310, 230);
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // DataGrid
            this.dataGridView1.Location = new System.Drawing.Point(30, 300);
            this.dataGridView1.Size = new System.Drawing.Size(620, 260);
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

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
            this.Controls.Add(this.cmbReason);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datePaid);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);

            this.Size = new System.Drawing.Size(700, 600);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
