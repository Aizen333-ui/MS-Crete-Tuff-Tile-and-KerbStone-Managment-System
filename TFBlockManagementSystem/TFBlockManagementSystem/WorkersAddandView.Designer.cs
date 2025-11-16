namespace TFBlockManagementSystem
{
    partial class WorkersAddandView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelName = new Label();
            labelRole = new Label();
            labelWage = new Label();
            textBoxName = new TextBox();
            textBoxRole = new TextBox();
            textBoxWage = new TextBox();
            buttonAdd = new Button();
            buttonRemove = new Button();
            listBoxWorkers = new ListBox();

            SuspendLayout();

            // labelName
            labelName.AutoSize = true;
            labelName.Location = new Point(50, 40);
            labelName.Name = "labelName";
            labelName.Size = new Size(120, 25);
            labelName.Text = "Worker Name:";

            // textBoxName
            textBoxName.Location = new Point(200, 40);
            textBoxName.Size = new Size(200, 31);

            // labelRole
            labelRole.AutoSize = true;
            labelRole.Location = new Point(50, 90);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(100, 25);
            labelRole.Text = "Role / Job:";

            // textBoxRole
            textBoxRole.Location = new Point(200, 90);
            textBoxRole.Size = new Size(200, 31);

            // labelWage
            labelWage.AutoSize = true;
            labelWage.Location = new Point(50, 140);
            labelWage.Name = "labelWage";
            labelWage.Size = new Size(120, 25);
            labelWage.Text = "Daily Wage (PKR):";

            // textBoxWage
            textBoxWage.Location = new Point(200, 140);
            textBoxWage.Size = new Size(200, 31);

            // buttonAdd
            buttonAdd.Location = new Point(50, 200);
            buttonAdd.Size = new Size(150, 40);
            buttonAdd.Text = "Add Worker";
            buttonAdd.Click += buttonAdd_Click;

            // buttonRemove
            buttonRemove.Location = new Point(250, 200);
            buttonRemove.Size = new Size(150, 40);
            buttonRemove.Text = "Remove Selected";
            buttonRemove.Click += buttonRemove_Click;

            // listBoxWorkers
            listBoxWorkers.Location = new Point(450, 40);
            listBoxWorkers.Size = new Size(300, 200);

            // ManageWorkers Form
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 300);
            Controls.Add(labelName);
            Controls.Add(labelRole);
            Controls.Add(labelWage);
            Controls.Add(textBoxName);
            Controls.Add(textBoxRole);
            Controls.Add(textBoxWage);
            Controls.Add(buttonAdd);
            Controls.Add(buttonRemove);
            Controls.Add(listBoxWorkers);
            Name = "ManageWorkers";
            Text = "Manage Workers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelRole;
        private Label labelWage;
        private TextBox textBoxName;
        private TextBox textBoxRole;
        private TextBox textBoxWage;
        private Button buttonAdd;
        private Button buttonRemove;
        private ListBox listBoxWorkers;
    }
}
