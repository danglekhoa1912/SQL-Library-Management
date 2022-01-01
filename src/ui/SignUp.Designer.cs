namespace Library_Management.src.ui
{
    partial class SignUp
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
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.btnRegister = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.lblUserName = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtStudentID = new MetroFramework.Controls.MetroTextBox();
            this.txtRePassword = new MetroFramework.Controls.MetroTextBox();
            this.txtMobile = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.lblErrorName = new MetroFramework.Controls.MetroLabel();
            this.lblErrorUsername = new MetroFramework.Controls.MetroLabel();
            this.lblErrorPassword = new MetroFramework.Controls.MetroLabel();
            this.lblErrorRePassword = new MetroFramework.Controls.MetroLabel();
            this.lblErrorBirthday = new MetroFramework.Controls.MetroLabel();
            this.lblErrorStudentID = new MetroFramework.Controls.MetroLabel();
            this.lblErrorMobile = new MetroFramework.Controls.MetroLabel();
            this.lblErrorEmail = new MetroFramework.Controls.MetroLabel();
            this.lbErrorUsername = new MetroFramework.Controls.MetroLabel();
            this.lblErrorFullname = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.Location = new System.Drawing.Point(25, 803);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(354, 33);
            this.metroCheckBox1.TabIndex = 0;
            this.metroCheckBox1.Text = "I agree to the terms of service";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRegister.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnRegister.Location = new System.Drawing.Point(69, 854);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(121, 50);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseCustomBackColor = true;
            this.btnRegister.UseCustomForeColor = true;
            this.btnRegister.UseSelectable = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnClear.Location = new System.Drawing.Point(230, 854);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 50);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseCustomBackColor = true;
            this.btnClear.UseCustomForeColor = true;
            this.btnClear.UseSelectable = true;
            // 
            // lblName
            // 
            this.lblName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(17, 60);
            this.lblName.Margin = new System.Windows.Forms.Padding(3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(353, 20);
            this.lblName.Style = MetroFramework.MetroColorStyle.Green;
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Full Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(20, 94);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Enter your fullname";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(354, 34);
            this.txtName.TabIndex = 4;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Enter your fullname";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(20, 184);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PromptText = "Enter your username";
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.Size = new System.Drawing.Size(354, 34);
            this.txtUserName.TabIndex = 6;
            this.txtUserName.UseSelectable = true;
            this.txtUserName.WaterMark = "Enter your username";
            this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblUserName
            // 
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserName.Location = new System.Drawing.Point(21, 155);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(349, 20);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "Username";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(20, 275);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "Enter your password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.ShowClearButton = true;
            this.txtPassword.Size = new System.Drawing.Size(354, 34);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "Enter your password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStudentID
            // 
            // 
            // 
            // 
            this.txtStudentID.CustomButton.Image = null;
            this.txtStudentID.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.txtStudentID.CustomButton.Name = "";
            this.txtStudentID.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtStudentID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStudentID.CustomButton.TabIndex = 1;
            this.txtStudentID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStudentID.CustomButton.UseSelectable = true;
            this.txtStudentID.CustomButton.Visible = false;
            this.txtStudentID.Lines = new string[0];
            this.txtStudentID.Location = new System.Drawing.Point(20, 557);
            this.txtStudentID.MaxLength = 32767;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.PasswordChar = '\0';
            this.txtStudentID.PromptText = "Enter Student ID";
            this.txtStudentID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStudentID.SelectedText = "";
            this.txtStudentID.SelectionLength = 0;
            this.txtStudentID.SelectionStart = 0;
            this.txtStudentID.ShortcutsEnabled = true;
            this.txtStudentID.Size = new System.Drawing.Size(354, 34);
            this.txtStudentID.TabIndex = 14;
            this.txtStudentID.UseSelectable = true;
            this.txtStudentID.WaterMark = "Enter Student ID";
            this.txtStudentID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudentID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRePassword
            // 
            // 
            // 
            // 
            this.txtRePassword.CustomButton.Image = null;
            this.txtRePassword.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.txtRePassword.CustomButton.Name = "";
            this.txtRePassword.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtRePassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRePassword.CustomButton.TabIndex = 1;
            this.txtRePassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRePassword.CustomButton.UseSelectable = true;
            this.txtRePassword.CustomButton.Visible = false;
            this.txtRePassword.Lines = new string[0];
            this.txtRePassword.Location = new System.Drawing.Point(22, 366);
            this.txtRePassword.MaxLength = 32767;
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '●';
            this.txtRePassword.PromptText = "Re-enter Password";
            this.txtRePassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRePassword.SelectedText = "";
            this.txtRePassword.SelectionLength = 0;
            this.txtRePassword.SelectionStart = 0;
            this.txtRePassword.ShortcutsEnabled = true;
            this.txtRePassword.Size = new System.Drawing.Size(354, 34);
            this.txtRePassword.TabIndex = 10;
            this.txtRePassword.UseSelectable = true;
            this.txtRePassword.UseSystemPasswordChar = true;
            this.txtRePassword.WaterMark = "Re-enter Password";
            this.txtRePassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRePassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMobile
            // 
            // 
            // 
            // 
            this.txtMobile.CustomButton.Image = null;
            this.txtMobile.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.txtMobile.CustomButton.Name = "";
            this.txtMobile.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtMobile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMobile.CustomButton.TabIndex = 1;
            this.txtMobile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMobile.CustomButton.UseSelectable = true;
            this.txtMobile.CustomButton.Visible = false;
            this.txtMobile.Lines = new string[0];
            this.txtMobile.Location = new System.Drawing.Point(20, 654);
            this.txtMobile.MaxLength = 32767;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.PasswordChar = '\0';
            this.txtMobile.PromptText = "Mobile";
            this.txtMobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMobile.SelectedText = "";
            this.txtMobile.SelectionLength = 0;
            this.txtMobile.SelectionStart = 0;
            this.txtMobile.ShortcutsEnabled = true;
            this.txtMobile.Size = new System.Drawing.Size(354, 34);
            this.txtMobile.TabIndex = 16;
            this.txtMobile.UseSelectable = true;
            this.txtMobile.WaterMark = "Mobile";
            this.txtMobile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMobile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(20, 743);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Enter Email";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(354, 34);
            this.txtEmail.TabIndex = 18;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMark = "Enter Email";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(20, 471);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(354, 30);
            this.metroDateTime1.TabIndex = 20;
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.Location = new System.Drawing.Point(2, 127);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(0, 0);
            this.lblErrorName.TabIndex = 21;
            // 
            // lblErrorUsername
            // 
            this.lblErrorUsername.AutoSize = true;
            this.lblErrorUsername.Location = new System.Drawing.Point(5, 207);
            this.lblErrorUsername.Name = "lblErrorUsername";
            this.lblErrorUsername.Size = new System.Drawing.Size(0, 0);
            this.lblErrorUsername.TabIndex = 22;
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.Location = new System.Drawing.Point(20, 315);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(350, 20);
            this.lblErrorPassword.TabIndex = 23;
            this.lblErrorPassword.Text = " ";
            // 
            // lblErrorRePassword
            // 
            this.lblErrorRePassword.Location = new System.Drawing.Point(25, 422);
            this.lblErrorRePassword.Name = "lblErrorRePassword";
            this.lblErrorRePassword.Size = new System.Drawing.Size(350, 20);
            this.lblErrorRePassword.TabIndex = 24;
            this.lblErrorRePassword.Text = " ";
            // 
            // lblErrorBirthday
            // 
            this.lblErrorBirthday.Location = new System.Drawing.Point(20, 510);
            this.lblErrorBirthday.Name = "lblErrorBirthday";
            this.lblErrorBirthday.Size = new System.Drawing.Size(355, 20);
            this.lblErrorBirthday.TabIndex = 25;
            this.lblErrorBirthday.Text = " ";
            // 
            // lblErrorStudentID
            // 
            this.lblErrorStudentID.Location = new System.Drawing.Point(20, 597);
            this.lblErrorStudentID.Name = "lblErrorStudentID";
            this.lblErrorStudentID.Size = new System.Drawing.Size(353, 20);
            this.lblErrorStudentID.TabIndex = 26;
            this.lblErrorStudentID.Text = " ";
            // 
            // lblErrorMobile
            // 
            this.lblErrorMobile.Location = new System.Drawing.Point(22, 691);
            this.lblErrorMobile.Name = "lblErrorMobile";
            this.lblErrorMobile.Size = new System.Drawing.Size(350, 20);
            this.lblErrorMobile.TabIndex = 27;
            this.lblErrorMobile.Text = " ";
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.Location = new System.Drawing.Point(17, 780);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(354, 20);
            this.lblErrorEmail.TabIndex = 28;
            this.lblErrorEmail.Text = " ";
            // 
            // lbErrorUsername
            // 
            this.lbErrorUsername.Location = new System.Drawing.Point(20, 221);
            this.lbErrorUsername.Name = "lbErrorUsername";
            this.lbErrorUsername.Size = new System.Drawing.Size(354, 20);
            this.lbErrorUsername.TabIndex = 29;
            this.lbErrorUsername.Text = " ";
            // 
            // lblErrorFullname
            // 
            this.lblErrorFullname.Location = new System.Drawing.Point(20, 131);
            this.lblErrorFullname.Name = "lblErrorFullname";
            this.lblErrorFullname.Size = new System.Drawing.Size(354, 20);
            this.lblErrorFullname.TabIndex = 30;
            this.lblErrorFullname.Text = " ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel1.Location = new System.Drawing.Point(25, 246);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(349, 20);
            this.metroLabel1.TabIndex = 31;
            this.metroLabel1.Text = "Password";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel2.Location = new System.Drawing.Point(24, 336);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(125, 20);
            this.metroLabel2.TabIndex = 32;
            this.metroLabel2.Text = "Re-enter Password";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel3.Location = new System.Drawing.Point(25, 442);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(92, 20);
            this.metroLabel3.TabIndex = 33;
            this.metroLabel3.Text = "Your birthday";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel4.Location = new System.Drawing.Point(25, 530);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 20);
            this.metroLabel4.TabIndex = 34;
            this.metroLabel4.Text = "Sudent ID";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel6
            // 
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel6.Location = new System.Drawing.Point(25, 711);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(50, 20);
            this.metroLabel6.TabIndex = 36;
            this.metroLabel6.Text = "Email";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel7.Location = new System.Drawing.Point(25, 617);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(51, 20);
            this.metroLabel7.TabIndex = 37;
            this.metroLabel7.Text = "Moblie";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(401, 929);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblErrorFullname);
            this.Controls.Add(this.lbErrorUsername);
            this.Controls.Add(this.lblErrorEmail);
            this.Controls.Add(this.lblErrorMobile);
            this.Controls.Add(this.lblErrorStudentID);
            this.Controls.Add(this.lblErrorBirthday);
            this.Controls.Add(this.lblErrorRePassword);
            this.Controls.Add(this.lblErrorPassword);
            this.Controls.Add(this.lblErrorUsername);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUp";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroButton btnRegister;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtUserName;
        private MetroFramework.Controls.MetroLabel lblUserName;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtStudentID;
        private MetroFramework.Controls.MetroTextBox txtRePassword;
        private MetroFramework.Controls.MetroTextBox txtMobile;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel lblErrorName;
        private MetroFramework.Controls.MetroLabel lblErrorUsername;
        private MetroFramework.Controls.MetroLabel lblErrorPassword;
        private MetroFramework.Controls.MetroLabel lblErrorRePassword;
        private MetroFramework.Controls.MetroLabel lblErrorBirthday;
        private MetroFramework.Controls.MetroLabel lblErrorStudentID;
        private MetroFramework.Controls.MetroLabel lblErrorMobile;
        private MetroFramework.Controls.MetroLabel lblErrorEmail;
        private MetroFramework.Controls.MetroLabel lbErrorUsername;
        private MetroFramework.Controls.MetroLabel lblErrorFullname;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}