﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Issue));
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblErrorUserID = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.btnCheckUser = new System.Windows.Forms.Button();
            this.lblErrorIssueDate = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblErrorReturnDueDate = new System.Windows.Forms.Label();
            this.lblReturnDueDate = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.dpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.dpReturnDueDate = new System.Windows.Forms.DateTimePicker();
            this.btAddIssueBook = new System.Windows.Forms.Button();
            this.flpListIssueBook = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblUserID.Location = new System.Drawing.Point(50, 27);
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
            this.lblErrorUserID.Size = new System.Drawing.Size(0, 20);
            this.lblErrorUserID.TabIndex = 1;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(43, 53);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(202, 29);
            this.txtUserID.TabIndex = 2;
            // 
            // btnCheckUser
            // 
            this.btnCheckUser.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnCheckUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckUser.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCheckUser.Location = new System.Drawing.Point(43, 96);
            this.btnCheckUser.Name = "btnCheckUser";
            this.btnCheckUser.Size = new System.Drawing.Size(109, 35);
            this.btnCheckUser.TabIndex = 3;
            this.btnCheckUser.Text = "Check User";
            this.btnCheckUser.UseVisualStyleBackColor = false;
            this.btnCheckUser.Click += new System.EventHandler(this.btnCheckUser_Click);
            // 
            // lblErrorIssueDate
            // 
            this.lblErrorIssueDate.AutoSize = true;
            this.lblErrorIssueDate.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorIssueDate.Location = new System.Drawing.Point(50, 182);
            this.lblErrorIssueDate.Name = "lblErrorIssueDate";
            this.lblErrorIssueDate.Size = new System.Drawing.Size(0, 20);
            this.lblErrorIssueDate.TabIndex = 5;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.ForeColor = System.Drawing.Color.DodgerBlue;
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
            this.lblErrorReturnDueDate.Size = new System.Drawing.Size(0, 20);
            this.lblErrorReturnDueDate.TabIndex = 8;
            // 
            // lblReturnDueDate
            // 
            this.lblReturnDueDate.AutoSize = true;
            this.lblReturnDueDate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblReturnDueDate.Location = new System.Drawing.Point(50, 197);
            this.lblReturnDueDate.Name = "lblReturnDueDate";
            this.lblReturnDueDate.Size = new System.Drawing.Size(133, 23);
            this.lblReturnDueDate.TabIndex = 7;
            this.lblReturnDueDate.Text = "Return Due Date";
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Linen;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDone.Location = new System.Drawing.Point(162, 457);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(110, 40);
            this.btnDone.TabIndex = 18;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // dpIssueDate
            // 
            this.dpIssueDate.Location = new System.Drawing.Point(45, 160);
            this.dpIssueDate.Name = "dpIssueDate";
            this.dpIssueDate.Size = new System.Drawing.Size(200, 29);
            this.dpIssueDate.TabIndex = 20;
            // 
            // dpReturnDueDate
            // 
            this.dpReturnDueDate.Location = new System.Drawing.Point(45, 223);
            this.dpReturnDueDate.Name = "dpReturnDueDate";
            this.dpReturnDueDate.Size = new System.Drawing.Size(200, 29);
            this.dpReturnDueDate.TabIndex = 20;
            // 
            // btAddIssueBook
            // 
            this.btAddIssueBook.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btAddIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddIssueBook.ForeColor = System.Drawing.Color.DarkGreen;
            this.btAddIssueBook.Image = ((System.Drawing.Image)(resources.GetObject("btAddIssueBook.Image")));
            this.btAddIssueBook.Location = new System.Drawing.Point(54, 393);
            this.btAddIssueBook.Name = "btAddIssueBook";
            this.btAddIssueBook.Size = new System.Drawing.Size(171, 38);
            this.btAddIssueBook.TabIndex = 21;
            this.btAddIssueBook.Text = "Add Book";
            this.btAddIssueBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAddIssueBook.UseVisualStyleBackColor = false;
            this.btAddIssueBook.Click += new System.EventHandler(this.btAddIssueBook_Click);
            // 
            // flpListIssueBook
            // 
            this.flpListIssueBook.AutoScroll = true;
            this.flpListIssueBook.Location = new System.Drawing.Point(27, 296);
            this.flpListIssueBook.Name = "flpListIssueBook";
            this.flpListIssueBook.Size = new System.Drawing.Size(390, 91);
            this.flpListIssueBook.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(27, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Book Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(313, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Quantity";
            // 
            // Add_Issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 510);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpListIssueBook);
            this.Controls.Add(this.btAddIssueBook);
            this.Controls.Add(this.dpReturnDueDate);
            this.Controls.Add(this.dpIssueDate);
            this.Controls.Add(this.btnDone);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Issue";
            this.Padding = new System.Windows.Forms.Padding(23, 78, 23, 26);
            this.Resizable = false;
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
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.DateTimePicker dpIssueDate;
        private System.Windows.Forms.DateTimePicker dpReturnDueDate;
        private System.Windows.Forms.Button btAddIssueBook;
        private System.Windows.Forms.FlowLayoutPanel flpListIssueBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}