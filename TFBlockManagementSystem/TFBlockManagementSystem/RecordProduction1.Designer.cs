using System.Windows.Forms;

namespace Factory1_Dashboard.Pages
{
    partial class RecordProduction1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblProductName;
        private Label lblQuantity;
        private Label lblUnit;
        private Label lblDate;

        private ComboBox cmbProductName;
        private TextBox txtQuantity;
        private ComboBox cmbUnit;
        private DateTimePicker dateProduction;

        private Button btnSave;
        private Button btnClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.dateProduction = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(40, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(257, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Record Production";

            // lblProductName
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblProductName.Location = new System.Drawing.Point(40, 120);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(113, 21);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name:";

            // cmbProductName
            this.cmbProductName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbProductName.Location = new System.Drawing.Point(200, 115);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(300, 29);
            this.cmbProductName.TabIndex = 4;
            this.cmbProductName.DropDownStyle = ComboBoxStyle.DropDownList;

            // lblQuantity
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblQuantity.Location = new System.Drawing.Point(40, 180);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(143, 21);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity Produced:";

            // txtQuantity
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtQuantity.Location = new System.Drawing.Point(200, 175);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(180, 29);
            this.txtQuantity.TabIndex = 5;

            // lblUnit
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblUnit.Location = new System.Drawing.Point(400, 180);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(37, 21);
            this.lblUnit.TabIndex = 9;
            this.lblUnit.Text = "Unit:";

            // cmbUnit
            this.cmbUnit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbUnit.Location = new System.Drawing.Point(460, 175);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(100, 29);
            this.cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbUnit.TabIndex = 10;

            // lblDate
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDate.Location = new System.Drawing.Point(40, 240);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(125, 21);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Production Date:";

            // dateProduction
            this.dateProduction.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateProduction.Location = new System.Drawing.Point(200, 235);
            this.dateProduction.Name = "dateProduction";
            this.dateProduction.Size = new System.Drawing.Size(300, 29);
            this.dateProduction.TabIndex = 6;

            // btnSave
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(200, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 45);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;

            // btnClear
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(360, 310);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 45);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;

            // RecordProductionPage
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbProductName);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.dateProduction);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Name = "RecordProductionPage";
            this.Size = new System.Drawing.Size(944, 407);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
