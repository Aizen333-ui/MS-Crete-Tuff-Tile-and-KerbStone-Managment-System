namespace TFBlockManagementSystem
{
    partial class RawMaterial
    {
        private System.ComponentModel.IContainer components = null;


    private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbName;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQty;

        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.TextBox txtUnit;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateAdded;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;

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
            this.cmbName = new System.Windows.Forms.ComboBox();

            this.label3 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();

            this.labelUnit = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();

            this.label4 = new System.Windows.Forms.Label();
            this.dateAdded = new System.Windows.Forms.DateTimePicker();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();

            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // Label 1: Material ID
            this.label1.Text = "Material ID:";
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10);

            this.txtID.Location = new System.Drawing.Point(160, 30);
            this.txtID.Width = 220;

            // Label 2: Material Name
            this.label2.Text = "Material Name:";
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10);

            this.cmbName.Location = new System.Drawing.Point(160, 80);
            this.cmbName.Width = 220;
            this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbName.Items.AddRange(new object[]
            {
            "Cement", "Sand", "Crush", "Steel", "Mold Oil"
            });

            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbName_SelectedIndexChanged);

            // Label 3: Quantity
            this.label3.Text = "Quantity:";
            this.label3.Location = new System.Drawing.Point(30, 130);
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10);

            this.txtQty.Location = new System.Drawing.Point(160, 130);
            this.txtQty.Width = 220;

            this.txtQty.KeyPress += (s, e) =>
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
                    e.Handled = true;
            };

            // Unit
            this.labelUnit.Text = "Unit:";
            this.labelUnit.Location = new System.Drawing.Point(30, 180);
            this.labelUnit.Font = new System.Drawing.Font("Segoe UI", 10);

            this.txtUnit.Location = new System.Drawing.Point(160, 180);
            this.txtUnit.Width = 220;
            this.txtUnit.ReadOnly = true;
            this.txtUnit.BackColor = System.Drawing.Color.White;

            // Date Added
            this.label4.Text = "Date Added:";
            this.label4.Location = new System.Drawing.Point(30, 230);
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10);

            this.dateAdded.Location = new System.Drawing.Point(160, 230);
            this.dateAdded.Width = 220;

            // Add Button
            this.btnAdd.Text = "Add Material";
            this.btnAdd.Location = new System.Drawing.Point(160, 280);
            this.btnAdd.Width = 120;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(32, 56, 100);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // Remove Button
            this.btnRemove.Text = "Remove Material";
            this.btnRemove.Location = new System.Drawing.Point(290, 280);
            this.btnRemove.Width = 150;
            this.btnRemove.BackColor = System.Drawing.Color.Firebrick;
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);

            // DataGridView
            this.dataGridView1.Location = new System.Drawing.Point(30, 340);
            this.dataGridView1.Size = new System.Drawing.Size(630, 240);
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.AutoGenerateColumns = true;

            // Add controls to UserControl
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);

            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbName);

            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQty);

            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.txtUnit);

            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateAdded);

            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);

            this.Controls.Add(this.dataGridView1);

            this.Size = new System.Drawing.Size(700, 600);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }


}
