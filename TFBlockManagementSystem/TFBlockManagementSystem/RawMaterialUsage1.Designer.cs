using System.Windows.Forms;

namespace Factory1_Dashboard.Pages
{
    partial class RawMaterialUsage1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblMaterialName;
        private Label lblQuantity;
        private Label lblDate;

        private ComboBox cmbMaterialName; // changed from TextBox
        private TextBox txtQuantity;
        private DateTimePicker dateMaterial;

        private Button btnSave;
        private Button btnClear;
        private Button btnRemove;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblMaterialName = new Label();
            this.lblQuantity = new Label();
            this.lblDate = new Label();
            this.cmbMaterialName = new ComboBox(); // updated
            this.txtQuantity = new TextBox();
            this.dateMaterial = new DateTimePicker();
            this.btnSave = new Button();
            this.btnRemove = new Button();
            this.btnClear = new Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(40, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(274, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Raw Material Usage";
            // 
            // lblMaterialName
            // 
            this.lblMaterialName.AutoSize = true;
            this.lblMaterialName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMaterialName.Location = new System.Drawing.Point(40, 120);
            this.lblMaterialName.Name = "lblMaterialName";
            this.lblMaterialName.Size = new System.Drawing.Size(116, 21);
            this.lblMaterialName.TabIndex = 1;
            this.lblMaterialName.Text = "Material Name:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblQuantity.Location = new System.Drawing.Point(40, 180);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(104, 21);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDate.Location = new System.Drawing.Point(40, 240);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 21);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date:";
            // 
            // cmbMaterialName
            // 
            this.cmbMaterialName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbMaterialName.Location = new System.Drawing.Point(200, 115);
            this.cmbMaterialName.Name = "cmbMaterialName";
            this.cmbMaterialName.Size = new System.Drawing.Size(300, 29);
            this.cmbMaterialName.TabIndex = 4;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtQuantity.Location = new System.Drawing.Point(200, 175);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(300, 29);
            this.txtQuantity.TabIndex = 5;
            // 
            // dateMaterial
            // 
            this.dateMaterial.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateMaterial.Location = new System.Drawing.Point(200, 235);
            this.dateMaterial.Name = "dateMaterial";
            this.dateMaterial.Size = new System.Drawing.Size(300, 29);
            this.dateMaterial.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(200, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 45);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Entry";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(360, 310);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 45);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;

            //
            // btnRemove
            //
            this.btnRemove.BackColor = System.Drawing.Color.Firebrick;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(520, 310);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(140, 45);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove Entry";
            this.btnRemove.UseVisualStyleBackColor = false;
            
            // 
            // RawMaterialPage
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMaterialName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbMaterialName);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dateMaterial);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Name = "RawMaterialPage";
            this.Size = new System.Drawing.Size(944, 407);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
