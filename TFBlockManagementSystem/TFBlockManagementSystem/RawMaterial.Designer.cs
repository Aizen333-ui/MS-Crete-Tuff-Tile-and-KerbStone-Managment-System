namespace TFBlockManagementSystem
{
    partial class RawMaterial
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblMaterialID;
        private Label lblMaterialName;
        private Label lblQuantity;
        private TextBox txtMaterialID;
        private TextBox txtMaterialName;
        private TextBox txtQuantity;
        private Button btnAddMaterial;
        private Button btnRemoveMaterial;
        private ListBox lstMaterials;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblMaterialID = new Label();
            this.lblMaterialName = new Label();
            this.lblQuantity = new Label();
            this.txtMaterialID = new TextBox();
            this.txtMaterialName = new TextBox();
            this.txtQuantity = new TextBox();
            this.btnAddMaterial = new Button();
            this.btnRemoveMaterial = new Button();
            this.lstMaterials = new ListBox();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(180, 20);
            this.lblTitle.Size = new System.Drawing.Size(270, 32);
            this.lblTitle.Text = "Manage Raw Materials";

            // lblMaterialID
            this.lblMaterialID.AutoSize = true;
            this.lblMaterialID.Location = new System.Drawing.Point(50, 80);
            this.lblMaterialID.Size = new System.Drawing.Size(90, 20);
            this.lblMaterialID.Text = "Material ID:";

            // lblMaterialName
            this.lblMaterialName.AutoSize = true;
            this.lblMaterialName.Location = new System.Drawing.Point(50, 120);
            this.lblMaterialName.Size = new System.Drawing.Size(105, 20);
            this.lblMaterialName.Text = "Material Name:";

            // lblQuantity
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(50, 160);
            this.lblQuantity.Size = new System.Drawing.Size(65, 20);
            this.lblQuantity.Text = "Quantity:";

            // txtMaterialID
            this.txtMaterialID.Location = new System.Drawing.Point(170, 77);
            this.txtMaterialID.Size = new System.Drawing.Size(200, 27);

            // txtMaterialName
            this.txtMaterialName.Location = new System.Drawing.Point(170, 117);
            this.txtMaterialName.Size = new System.Drawing.Size(200, 27);

            // txtQuantity
            this.txtQuantity.Location = new System.Drawing.Point(170, 157);
            this.txtQuantity.Size = new System.Drawing.Size(200, 27);

            // btnAddMaterial
            this.btnAddMaterial.Location = new System.Drawing.Point(400, 75);
            this.btnAddMaterial.Size = new System.Drawing.Size(120, 30);
            this.btnAddMaterial.Text = "Add Material";
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);

            // btnRemoveMaterial
            this.btnRemoveMaterial.Location = new System.Drawing.Point(400, 115);
            this.btnRemoveMaterial.Size = new System.Drawing.Size(120, 30);
            this.btnRemoveMaterial.Text = "Remove Material";
            this.btnRemoveMaterial.Click += new System.EventHandler(this.btnRemoveMaterial_Click);

            // lstMaterials
            this.lstMaterials.Location = new System.Drawing.Point(50, 200);
            this.lstMaterials.Size = new System.Drawing.Size(470, 200);

            // RawMaterial Form
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMaterialID);
            this.Controls.Add(this.lblMaterialName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtMaterialID);
            this.Controls.Add(this.txtMaterialName);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnAddMaterial);
            this.Controls.Add(this.btnRemoveMaterial);
            this.Controls.Add(this.lstMaterials);
            this.Name = "RawMaterial";
            this.Text = "Raw Materials Management";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
