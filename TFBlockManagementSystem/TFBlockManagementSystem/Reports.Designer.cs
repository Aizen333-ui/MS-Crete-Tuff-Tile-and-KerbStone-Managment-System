namespace TFBlockManagementSystem
{
    partial class OwnerReportsPage
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox comboFactory;
        private DateTimePicker dtFrom;
        private DateTimePicker dtTo;
        private Button btnViewReport;
        private Label lblFactory;
        private Label lblFrom;
        private Label lblTo;
        private RichTextBox txtReport;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboFactory = new ComboBox();
            this.dtFrom = new DateTimePicker();
            this.dtTo = new DateTimePicker();
            this.btnViewReport = new Button();
            this.lblFactory = new Label();
            this.lblFrom = new Label();
            this.lblTo = new Label();
            this.txtReport = new RichTextBox();

            this.SuspendLayout();

            // Factory dropdown
            this.comboFactory.Font = new Font("Segoe UI", 10F);
            this.comboFactory.Items.AddRange(new object[] {
                "Factory 1",
                "Factory 2"
            });
            this.comboFactory.Location = new Point(150, 30);
            this.comboFactory.Size = new Size(200, 30);

            // Labels
            this.lblFactory.Text = "Select Factory:";
            this.lblFactory.Font = new Font("Segoe UI", 10F);
            this.lblFactory.Location = new Point(30, 35);

            this.lblFrom.Text = "From Date:";
            this.lblFrom.Font = new Font("Segoe UI", 10F);
            this.lblFrom.Location = new Point(30, 80);

            this.lblTo.Text = "To Date:";
            this.lblTo.Font = new Font("Segoe UI", 10F);
            this.lblTo.Location = new Point(30, 125);

            // Date pickers
            this.dtFrom.Location = new Point(150, 75);
            this.dtFrom.Size = new Size(200, 30);

            this.dtTo.Location = new Point(150, 120);
            this.dtTo.Size = new Size(200, 30);

            // View Report button
            this.btnViewReport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.BackColor = Color.DodgerBlue;
            this.btnViewReport.ForeColor = Color.White;
            this.btnViewReport.Location = new Point(150, 170);
            this.btnViewReport.Size = new Size(200, 40);
            this.btnViewReport.FlatStyle = FlatStyle.Flat;
            this.btnViewReport.Click += new EventHandler(this.btnViewReport_Click);

            // Report Box
            this.txtReport.Location = new Point(30, 230);
            this.txtReport.Size = new Size(600, 300);
            this.txtReport.Font = new Font("Consolas", 10F);

            // UserControl settings
            this.Controls.Add(this.comboFactory);
            this.Controls.Add(this.lblFactory);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.txtReport);

            this.Size = new Size(700, 600);
            this.ResumeLayout(false);
        }
    }
}
