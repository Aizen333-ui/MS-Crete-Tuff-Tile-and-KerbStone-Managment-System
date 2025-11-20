namespace TFBlockManagementSystem
{
    partial class RawMaterial
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateAdded;

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
            this.label1 = new Label();
            this.txtID = new TextBox();
            this.label2 = new Label();
            this.txtName = new TextBox();
            this.label3 = new Label();
            this.txtQty = new TextBox();
            this.label4 = new Label();
            this.dateAdded = new DateTimePicker();
            this.btnAdd = new Button();
            this.btnRemove = new Button();
            this.dataGridView1 = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // Material ID
            this.label1.Text = "Material ID:";
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.AutoSize = true;

            this.txtID.Location = new System.Drawing.Point(150, 30);
            this.txtID.Width = 200;

            // Material Name
            this.label2.Text = "Material Name:";
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.AutoSize = true;

            this.txtName.Location = new System.Drawing.Point(150, 80);
            this.txtName.Width = 200;

            // Quantity
            this.label3.Text = "Quantity:";
            this.label3.Location = new System.Drawing.Point(30, 130);
            this.label3.AutoSize = true;

            this.txtQty.Location = new System.Drawing.Point(150, 130);
            this.txtQty.Width = 200;

            // Date Added
            this.label4.Text = "Date Added:";
            this.label4.Location = new System.Drawing.Point(30, 180);
            this.label4.AutoSize = true;

            this.dateAdded.Location = new System.Drawing.Point(150, 180);
            this.dateAdded.Width = 200;

            // Add Button
            this.btnAdd.Text = "Add Material";
            this.btnAdd.Location = new System.Drawing.Point(150, 230);
            this.btnAdd.Width = 120;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // Remove Button
            this.btnRemove.Text = "Remove Material";
            this.btnRemove.Location = new System.Drawing.Point(280, 230);
            this.btnRemove.Width = 150;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // DataGridView
            this.dataGridView1.Location = new System.Drawing.Point(30, 300);
            this.dataGridView1.Size = new System.Drawing.Size(550, 250);
            this.dataGridView1.ColumnCount = 4;
            this.dataGridView1.Columns[0].Name = "Material ID";
            this.dataGridView1.Columns[1].Name = "Material Name";
            this.dataGridView1.Columns[2].Name = "Quantity";
            this.dataGridView1.Columns[3].Name = "Date Added";

            // UserControl Setup
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateAdded);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dataGridView1);

            this.Size = new System.Drawing.Size(650, 600);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
