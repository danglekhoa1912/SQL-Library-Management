
namespace Library_Management.src.ui
{
    partial class Add_Issue
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
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblErrorUserID = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.btnCheckUser = new System.Windows.Forms.Button();
            this.lblErrorIssueDate = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblErrorReturnDueDate = new System.Windows.Forms.Label();
            this.lblReturnDueDate = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lblButtonPlus = new System.Windows.Forms.Label();
            this.lblButtonMinus = new System.Windows.Forms.Label();
            this.lblBookQuantity = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.flpnBookQuantity = new System.Windows.Forms.FlowLayoutPanel();
            this.lblErrorBookID = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.dpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.dpReturnDueDate = new System.Windows.Forms.DateTimePicker();
            this.lbBookName = new System.Windows.Forms.Label();
            this.flpnBookQuantity.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(50, 33);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(64, 23);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "User ID";
            // 
            // lblErrorUserID
            // 
            this.lblErrorUserID.AutoSize = true;
            this.lblErrorUserID.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorUserID.Location = new System.Drawing.Point(50, 78);
            this.lblErrorUserID.Name = "lblErrorUserID";
            this.lblErrorUserID.Size = new System.Drawing.Size(153, 20);
            this.lblErrorUserID.TabIndex = 1;
            this.lblErrorUserID.Text = "aaaaaaaaaaaaaaaaaa";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(43, 53);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(348, 29);
            this.txtUserID.TabIndex = 2;
            // 
            // btnCheckUser
            // 
            this.btnCheckUser.Location = new System.Drawing.Point(43, 96);
            this.btnCheckUser.Name = "btnCheckUser";
            this.btnCheckUser.Size = new System.Drawing.Size(109, 35);
            this.btnCheckUser.TabIndex = 3;
            this.btnCheckUser.Text = "Check User";
            this.btnCheckUser.UseVisualStyleBackColor = true;
            this.btnCheckUser.Click += new System.EventHandler(this.btnCheckUser_Click);
            // 
            // lblErrorIssueDate
            // 
            this.lblErrorIssueDate.AutoSize = true;
            this.lblErrorIssueDate.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorIssueDate.Location = new System.Drawing.Point(50, 182);
            this.lblErrorIssueDate.Name = "lblErrorIssueDate";
            this.lblErrorIssueDate.Size = new System.Drawing.Size(153, 20);
            this.lblErrorIssueDate.TabIndex = 5;
            this.lblErrorIssueDate.Text = "aaaaaaaaaaaaaaaaaa";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(50, 134);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(86, 23);
            this.lblIssueDate.TabIndex = 4;
            this.lblIssueDate.Text = "Issue Date";
            // 
            // lblErrorReturnDueDate
            // 
            this.lblErrorReturnDueDate.AutoSize = true;
            this.lblErrorReturnDueDate.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorReturnDueDate.Location = new System.Drawing.Point(50, 245);
            this.lblErrorReturnDueDate.Name = "lblErrorReturnDueDate";
            this.lblErrorReturnDueDate.Size = new System.Drawing.Size(153, 20);
            this.lblErrorReturnDueDate.TabIndex = 8;
            this.lblErrorReturnDueDate.Text = "aaaaaaaaaaaaaaaaaa";
            // 
            // lblReturnDueDate
            // 
            this.lblReturnDueDate.AutoSize = true;
            this.lblReturnDueDate.Location = new System.Drawing.Point(50, 197);
            this.lblReturnDueDate.Name = "lblReturnDueDate";
            this.lblReturnDueDate.Size = new System.Drawing.Size(133, 23);
            this.lblReturnDueDate.TabIndex = 7;
            this.lblReturnDueDate.Text = "Return Due Date";
            // 
            // btnMinus
            // 
            this.btnMinus.BackgroundImage = global::Library_Management.Properties.Resources._261368_200;
            this.btnMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinus.Location = new System.Drawing.Point(224, 263);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(27, 25);
            this.btnMinus.TabIndex = 12;
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            this.btnPlus.BackgroundImage = global::Library_Management.Properties.Resources.download_removebg_preview;
            this.btnPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlus.Location = new System.Drawing.Point(141, 263);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(27, 25);
            this.btnPlus.TabIndex = 11;
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lblButtonPlus
            // 
            this.lblButtonPlus.AutoSize = true;
            this.lblButtonPlus.Location = new System.Drawing.Point(174, 267);
            this.lblButtonPlus.Name = "lblButtonPlus";
            this.lblButtonPlus.Size = new System.Drawing.Size(57, 23);
            this.lblButtonPlus.TabIndex = 13;
            this.lblButtonPlus.Text = "Button";
            // 
            // lblButtonMinus
            // 
            this.lblButtonMinus.AutoSize = true;
            this.lblButtonMinus.Location = new System.Drawing.Point(257, 267);
            this.lblButtonMinus.Name = "lblButtonMinus";
            this.lblButtonMinus.Size = new System.Drawing.Size(57, 23);
            this.lblButtonMinus.TabIndex = 14;
            this.lblButtonMinus.Text = "Button";
            // 
            // lblBookQuantity
            // 
            this.lblBookQuantity.AutoSize = true;
            this.lblBookQuantity.Location = new System.Drawing.Point(50, 267);
            this.lblBookQuantity.Name = "lblBookQuantity";
            this.lblBookQuantity.Size = new System.Drawing.Size(114, 23);
            this.lblBookQuantity.TabIndex = 15;
            this.lblBookQuantity.Text = "Book Quantity";
            // 
            // btnDone
            // 
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDone.Location = new System.Drawing.Point(162, 394);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(110, 40);
            this.btnDone.TabIndex = 18;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // flpnBookQuantity
            // 
            this.flpnBookQuantity.AutoScroll = true;
            this.flpnBookQuantity.Controls.Add(this.lblErrorBookID);
            this.flpnBookQuantity.Controls.Add(this.lblBookID);
            this.flpnBookQuantity.Controls.Add(this.txtBookID);
            this.flpnBookQuantity.Controls.Add(this.lbBookName);
            this.flpnBookQuantity.Location = new System.Drawing.Point(37, 291);
            this.flpnBookQuantity.Name = "flpnBookQuantity";
            this.flpnBookQuantity.Size = new System.Drawing.Size(354, 97);
            this.flpnBookQuantity.TabIndex = 19;
            // 
            // lblErrorBookID
            // 
            this.lblErrorBookID.AutoSize = true;
            this.lblErrorBookID.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorBookID.Location = new System.Drawing.Point(3, 0);
            this.lblErrorBookID.Name = "lblErrorBookID";
            this.lblErrorBookID.Size = new System.Drawing.Size(0, 20);
            this.lblErrorBookID.TabIndex = 20;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(9, 0);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(68, 23);
            this.lblBookID.TabIndex = 19;
            this.lblBookID.Text = "Book ID";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(3, 26);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(348, 29);
            this.txtBookID.TabIndex = 18;
            this.txtBookID.TextChanged += new System.EventHandler(this.txtBookID_TextChanged);
            // 
            // dpIssueDate
            // 
            this.dpIssueDate.Location = new System.Drawing.Point(54, 160);
            this.dpIssueDate.Name = "dpIssueDate";
            this.dpIssueDate.Size = new System.Drawing.Size(200, 29);
            this.dpIssueDate.TabIndex = 20;
            // 
            // dpReturnDueDate
            // 
            this.dpReturnDueDate.Location = new System.Drawing.Point(54, 223);
            this.dpReturnDueDate.Name = "dpReturnDueDate";
            this.dpReturnDueDate.Size = new System.Drawing.Size(200, 29);
            this.dpReturnDueDate.TabIndex = 20;
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Location = new System.Drawing.Point(3, 58);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(0, 23);
            this.lbBookName.TabIndex = 21;
            // 
            // Add_Issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.dpReturnDueDate);
            this.Controls.Add(this.dpIssueDate);
            this.Controls.Add(this.flpnBookQuantity);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblBookQuantity);
            this.Controls.Add(this.lblButtonMinus);
            this.Controls.Add(this.lblButtonPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblErrorReturnDueDate);
            this.Controls.Add(this.lblReturnDueDate);
            this.Controls.Add(this.lblErrorIssueDate);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.btnCheckUser);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.lblErrorUserID);
            this.Controls.Add(this.lblUserID);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Add_Issue";
            this.Padding = new System.Windows.Forms.Padding(23, 78, 23, 26);
            this.flpnBookQuantity.ResumeLayout(false);
            this.flpnBookQuantity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblErrorUserID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Button btnCheckUser;
        private System.Windows.Forms.Label lblErrorIssueDate;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblErrorReturnDueDate;
        private System.Windows.Forms.Label lblReturnDueDate;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label lblButtonPlus;
        private System.Windows.Forms.Label lblButtonMinus;
        private System.Windows.Forms.Label lblBookQuantity;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.FlowLayoutPanel flpnBookQuantity;
        private System.Windows.Forms.Label lblErrorBookID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.DateTimePicker dpIssueDate;
        private System.Windows.Forms.DateTimePicker dpReturnDueDate;
        private System.Windows.Forms.Label lbBookName;
    }
}