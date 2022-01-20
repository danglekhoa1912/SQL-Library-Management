namespace Library_Management.src.ui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnUser = new MetroFramework.Controls.MetroButton();
            this.btnBook = new MetroFramework.Controls.MetroButton();
            this.btnIssueBook = new MetroFramework.Controls.MetroButton();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblManage = new System.Windows.Forms.Label();
            this.MENU = new System.Windows.Forms.MenuStrip();
            this.mtsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.MENU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.White;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnUser.Highlight = true;
            this.btnUser.Location = new System.Drawing.Point(20, 32);
            this.btnUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(350, 34);
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
            this.btnBook.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnBook.Highlight = true;
            this.btnBook.Location = new System.Drawing.Point(371, 32);
            this.btnBook.Margin = new System.Windows.Forms.Padding(0, 2, 3, 2);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(350, 34);
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
            this.btnIssueBook.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnIssueBook.Highlight = true;
            this.btnIssueBook.Location = new System.Drawing.Point(722, 32);
            this.btnIssueBook.Margin = new System.Windows.Forms.Padding(0, 2, 3, 2);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(350, 34);
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
            this.txtSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBox.Font = new System.Drawing.Font("Segoe UI Historic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtSearchBox.Location = new System.Drawing.Point(71, 87);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(803, 30);
            this.txtSearchBox.TabIndex = 4;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(20, 186);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1200, 594);
            this.dataGridView.TabIndex = 6;
            // 
            // lblManage
            // 
            this.lblManage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblManage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblManage.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblManage.Location = new System.Drawing.Point(340, 131);
            this.lblManage.Name = "lblManage";
            this.lblManage.Size = new System.Drawing.Size(508, 46);
            this.lblManage.TabIndex = 7;
            this.lblManage.Text = "lblManage";
            this.lblManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MENU
            // 
            this.MENU.AutoSize = false;
            this.MENU.Dock = System.Windows.Forms.DockStyle.None;
            this.MENU.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MENU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsMenu});
            this.MENU.Location = new System.Drawing.Point(1075, 34);
            this.MENU.Name = "MENU";
            this.MENU.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MENU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MENU.Size = new System.Drawing.Size(160, 32);
            this.MENU.TabIndex = 8;
            this.MENU.Text = "msMenu";
            // 
            // mtsMenu
            // 
            this.mtsMenu.CheckOnClick = true;
            this.mtsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAccount,
            this.mtsLanguage,
            this.tmsLogOut,
            this.aboutProgramToolStripMenuItem});
            this.mtsMenu.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.mtsMenu.Name = "mtsMenu";
            this.mtsMenu.Size = new System.Drawing.Size(65, 28);
            this.mtsMenu.Text = "MENU";
            // 
            // tsmAccount
            // 
            this.tsmAccount.Name = "tsmAccount";
            this.tsmAccount.Size = new System.Drawing.Size(224, 26);
            this.tsmAccount.Text = "Acount Info";
            // 
            // mtsLanguage
            // 
            this.mtsLanguage.Name = "mtsLanguage";
            this.mtsLanguage.Size = new System.Drawing.Size(224, 26);
            this.mtsLanguage.Text = "Language";
            // 
            // tmsLogOut
            // 
            this.tmsLogOut.Name = "tmsLogOut";
            this.tmsLogOut.Size = new System.Drawing.Size(224, 26);
            this.tmsLogOut.Text = "Log Out";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutProgramToolStripMenuItem.Text = "About Program";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Historic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(890, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 45);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Historic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(987, 79);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 45);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Historic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1105, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "Refesh";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 800);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblManage);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.btnIssueBook);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.MENU);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.MENU.ResumeLayout(false);
            this.MENU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnUser;
        private MetroFramework.Controls.MetroButton btnBook;
        private MetroFramework.Controls.MetroButton btnIssueBook;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblManage;
        private System.Windows.Forms.MenuStrip MENU;
        private System.Windows.Forms.ToolStripMenuItem mtsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmAccount;
        private System.Windows.Forms.ToolStripMenuItem mtsLanguage;
        private System.Windows.Forms.ToolStripMenuItem tmsLogOut;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}