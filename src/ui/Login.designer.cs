
namespace Library_Management.src.ui
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.btnSignUp = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtAccount = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogin.Location = new System.Drawing.Point(56, 305);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(95, 37);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseCustomBackColor = true;
            this.btnLogin.UseCustomForeColor = true;
            this.btnLogin.UseMnemonic = false;
            this.btnLogin.UseSelectable = true;
            this.btnLogin.UseStyleColors = true;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnSignUp.Location = new System.Drawing.Point(198, 305);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(95, 37);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseCustomBackColor = true;
            this.btnSignUp.UseCustomForeColor = true;
            this.btnSignUp.UseMnemonic = false;
            this.btnSignUp.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(42, 161);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Username:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(42, 220);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 20);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Password:";
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.IconRight = true;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(42, 243);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PromptText = "Enter your password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(265, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Enter your password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAccount
            // 
            // 
            // 
            // 
            this.txtAccount.CustomButton.Image = null;
            this.txtAccount.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.txtAccount.CustomButton.Name = "";
            this.txtAccount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAccount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccount.CustomButton.TabIndex = 1;
            this.txtAccount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccount.CustomButton.UseSelectable = true;
            this.txtAccount.CustomButton.Visible = false;
            this.txtAccount.DisplayIcon = true;
            this.txtAccount.IconRight = true;
            this.txtAccount.Lines = new string[0];
            this.txtAccount.Location = new System.Drawing.Point(42, 184);
            this.txtAccount.MaxLength = 32767;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.PasswordChar = '\0';
            this.txtAccount.PromptText = "Enter your username";
            this.txtAccount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccount.SelectedText = "";
            this.txtAccount.SelectionLength = 0;
            this.txtAccount.SelectionStart = 0;
            this.txtAccount.ShortcutsEnabled = true;
            this.txtAccount.Size = new System.Drawing.Size(265, 23);
            this.txtAccount.TabIndex = 0;
            this.txtAccount.UseSelectable = true;
            this.txtAccount.WaterMark = "Enter your username";
            this.txtAccount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(127, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CancelButton = this.btnSignUp;
            this.ClientSize = new System.Drawing.Size(350, 400);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnLogin);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(22, 60, 22, 20);
            this.Resizable = false;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnSignUp;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel LOGIN;
        private MetroFramework.Controls.MetroTextBox txtAccount;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnLogin;
    }
}