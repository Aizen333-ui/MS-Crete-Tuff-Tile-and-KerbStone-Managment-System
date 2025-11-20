namespace TFBlockManagementSystem
{
    partial class WorkersAddandView
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;

        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtRole;

        private System.Windows.Forms.Label lblWage;
        private System.Windows.Forms.TextBox txtWage;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;

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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();

            this.lblRole = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();

            this.lblWage = new System.Windows.Forms.Label();
            this.txtWage = new System.Windows.Forms.TextBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();

            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // Label: Worker Name
            this.lblName.Text = "Worker Name:";
            this.lblName.Location = new System.Drawing.Point(30, 30);
            this.lblName.AutoSize = true;

            this.txtName.Location = new System.Drawing.Point(150, 30);
            this.txtName.Width = 220;

            // Label: Job / Role
            this.lblRole.Text = "Job / Role:";
            this.lblRole.Location = new System.Drawing.Point(30, 80);
            this.lblRole.AutoSize = true;

            this.txtRole.Location = new System.Drawing.Point(150, 80);
            this.txtRole.Width = 220;

            // Label: Daily Wage
            this.lblWage.Text = "Daily Wage (PKR):";
            this.lblWage.Location = new System.Drawing.Point(30, 130);
            this.lblWage.AutoSize = true;

            this.txtWage.Location = new System.Drawing.Point(150, 130);
            this.txtWage.Width = 220;

            // Add button
            this.btnAdd.Text = "Add Worker";
            this.btnAdd.Location = new System.Drawing.Point(150, 180);
            this.btnAdd.Width = 140;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // Remove button
            this.btnRemove.Text = "Remove Selected";
            this.btnRemove.Location = new System.Drawing.Point(300, 180);
            this.btnRemove.Width = 140;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // DataGridView
            this.dataGridView1.Location = new System.Drawing.Point(30, 250);
            this.dataGridView1.Size = new System.Drawing.Size(650, 300);

            this.dataGridView1.ColumnCount = 3;
            this.dataGridView1.Columns[0].Name = "Worker Name";
            this.dataGridView1.Columns[1].Name = "Job / Role";
            this.dataGridView1.Columns[2].Name = "Daily Wage (PKR)";

            // Adding Controls
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);

            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtRole);

            this.Controls.Add(this.lblWage);
            this.Controls.Add(this.txtWage);

            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);

            this.Controls.Add(this.dataGridView1);

            this.Size = new System.Drawing.Size(750, 600);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
