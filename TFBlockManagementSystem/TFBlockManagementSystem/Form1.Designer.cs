namespace TFBlockManagementSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblUsername = new Label();
            this.lblPassword = new Label();
            this.txtUsername = new TextBox();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.SuspendLayout();

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(207, 137);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Text = "Username:";

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(310, 137);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(150, 31);

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(207, 203);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Text = "Password:";

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(310, 197);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 31);
            this.txtPassword.UseSystemPasswordChar = true;

            // btnLogin
            this.btnLogin.Location = new System.Drawing.Point(327, 285);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 34);
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.Text = "TF Block Management - Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
