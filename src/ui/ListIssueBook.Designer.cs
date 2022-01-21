
namespace Library_Management.src.ui
{
    partial class ListIssueBook
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
            this.dgvIssueDetail = new System.Windows.Forms.DataGridView();
            this.lblIssueId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIssueDetail
            // 
            this.dgvIssueDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssueDetail.Location = new System.Drawing.Point(13, 89);
            this.dgvIssueDetail.Name = "dgvIssueDetail";
            this.dgvIssueDetail.RowHeadersWidth = 51;
            this.dgvIssueDetail.RowTemplate.Height = 24;
            this.dgvIssueDetail.Size = new System.Drawing.Size(751, 356);
            this.dgvIssueDetail.TabIndex = 0;
            // 
            // lblIssueId
            // 
            this.lblIssueId.AutoSize = true;
            this.lblIssueId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueId.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblIssueId.Location = new System.Drawing.Point(512, 34);
            this.lblIssueId.Name = "lblIssueId";
            this.lblIssueId.Size = new System.Drawing.Size(79, 29);
            this.lblIssueId.TabIndex = 1;
            this.lblIssueId.Text = "label1";
            // 
            // ListIssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.lblIssueId);
            this.Controls.Add(this.dgvIssueDetail);
            this.Name = "ListIssueBook";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIssueDetail;
        private System.Windows.Forms.Label lblIssueId;
    }
}