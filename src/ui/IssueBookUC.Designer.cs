
namespace Library_Management.src.ui
{
    partial class IssueBookUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpnBookQuantity = new System.Windows.Forms.FlowLayoutPanel();
            this.lbBookName = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblErrorBookID = new System.Windows.Forms.Label();
            this.lbQuantityBook = new System.Windows.Forms.Label();
            this.flpnBookQuantity.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpnBookQuantity
            // 
            this.flpnBookQuantity.AutoScroll = true;
            this.flpnBookQuantity.Controls.Add(this.lbBookName);
            this.flpnBookQuantity.Controls.Add(this.lblBookName);
            this.flpnBookQuantity.Controls.Add(this.lbQuantityBook);
            this.flpnBookQuantity.Controls.Add(this.lblErrorBookID);
            this.flpnBookQuantity.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpnBookQuantity.Location = new System.Drawing.Point(3, 3);
            this.flpnBookQuantity.Name = "flpnBookQuantity";
            this.flpnBookQuantity.Size = new System.Drawing.Size(357, 51);
            this.flpnBookQuantity.TabIndex = 21;
            // 
            // lbBookName
            // 
            this.lbBookName.Location = new System.Drawing.Point(5, 0);
            this.lbBookName.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(307, 17);
            this.lbBookName.TabIndex = 21;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(5, 27);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(0, 17);
            this.lblBookName.TabIndex = 22;
            // 
            // lblErrorBookID
            // 
            this.lblErrorBookID.AutoSize = true;
            this.lblErrorBookID.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorBookID.Location = new System.Drawing.Point(318, 17);
            this.lblErrorBookID.Name = "lblErrorBookID";
            this.lblErrorBookID.Size = new System.Drawing.Size(0, 20);
            this.lblErrorBookID.TabIndex = 20;
            // 
            // lbQuantityBook
            // 
            this.lbQuantityBook.AutoSize = true;
            this.lbQuantityBook.Location = new System.Drawing.Point(325, 0);
            this.lbQuantityBook.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lbQuantityBook.Name = "lbQuantityBook";
            this.lbQuantityBook.Size = new System.Drawing.Size(0, 17);
            this.lbQuantityBook.TabIndex = 22;
            // 
            // IssueBookUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpnBookQuantity);
            this.Name = "IssueBookUC";
            this.Size = new System.Drawing.Size(402, 58);
            this.flpnBookQuantity.ResumeLayout(false);
            this.flpnBookQuantity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpnBookQuantity;
        private System.Windows.Forms.Label lblErrorBookID;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label lbQuantityBook;
        private System.Windows.Forms.Label lblBookName;
    }
}
