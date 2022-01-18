﻿namespace Library_Management.src.ui
{
    partial class Main
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
            this.btnUser = new MetroFramework.Controls.MetroButton();
            this.btnBook = new MetroFramework.Controls.MetroButton();
            this.btnIssueBook = new MetroFramework.Controls.MetroButton();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.White;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.DisplayFocus = true;
            this.btnUser.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnUser.ForeColor = System.Drawing.Color.Black;
            this.btnUser.Highlight = true;
            this.btnUser.Location = new System.Drawing.Point(20, 32);
            this.btnUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(350, 34);
            this.btnUser.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "USER MANAGE";
            this.btnUser.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnUser.UseCustomBackColor = true;
            this.btnUser.UseCustomForeColor = true;
            this.btnUser.UseSelectable = true;
            this.btnUser.UseStyleColors = true;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.White;
            this.btnBook.DisplayFocus = true;
            this.btnBook.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnBook.Highlight = true;
            this.btnBook.Location = new System.Drawing.Point(371, 32);
            this.btnBook.Margin = new System.Windows.Forms.Padding(0, 2, 3, 2);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(350, 34);
            this.btnBook.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnBook.TabIndex = 2;
            this.btnBook.Text = "BOOK MANAGE";
            this.btnBook.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBook.UseCustomBackColor = true;
            this.btnBook.UseCustomForeColor = true;
            this.btnBook.UseSelectable = true;
            this.btnBook.UseStyleColors = true;
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.BackColor = System.Drawing.Color.White;
            this.btnIssueBook.DisplayFocus = true;
            this.btnIssueBook.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnIssueBook.Highlight = true;
            this.btnIssueBook.Location = new System.Drawing.Point(722, 32);
            this.btnIssueBook.Margin = new System.Windows.Forms.Padding(0, 2, 3, 2);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(350, 34);
            this.btnIssueBook.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnIssueBook.TabIndex = 3;
            this.btnIssueBook.Text = "ISSUE BOOK MANAGE";
            this.btnIssueBook.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnIssueBook.UseCustomBackColor = true;
            this.btnIssueBook.UseCustomForeColor = true;
            this.btnIssueBook.UseSelectable = true;
            this.btnIssueBook.UseStyleColors = true;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(71, 87);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(803, 34);
            this.txtSearchBox.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management.Properties.Resources._5613;
            this.pictureBox1.Location = new System.Drawing.Point(20, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(20, 163);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1160, 617);
            this.dataGridView.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.btnIssueBook);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnUser);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnUser;
        private MetroFramework.Controls.MetroButton btnBook;
        private MetroFramework.Controls.MetroButton btnIssueBook;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}