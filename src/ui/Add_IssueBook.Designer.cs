
namespace Library_Management.src.ui
{
    partial class Add_IssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_IssueBook));
            this.flpnBookQuantity = new System.Windows.Forms.FlowLayoutPanel();
            this.lblErrorBookID = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lbBookName = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lbBookQuantity = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btDone = new System.Windows.Forms.Button();
            this.flpnBookQuantity.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpnBookQuantity
            // 
            this.flpnBookQuantity.AutoScroll = true;
            this.flpnBookQuantity.Controls.Add(this.lblErrorBookID);
            this.flpnBookQuantity.Controls.Add(this.lblBookID);
            this.flpnBookQuantity.Controls.Add(this.txtBookID);
            this.flpnBookQuantity.Controls.Add(this.lbBookName);
            this.flpnBookQuantity.Location = new System.Drawing.Point(5, 63);
            this.flpnBookQuantity.Name = "flpnBookQuantity";
            this.flpnBookQuantity.Size = new System.Drawing.Size(354, 66);
            this.flpnBookQuantity.TabIndex = 20;
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
            this.lblBookID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBookID.Location = new System.Drawing.Point(9, 0);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(55, 16);
            this.lblBookID.TabIndex = 19;
            this.lblBookID.Text = "Book ID";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(3, 23);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(348, 22);
            this.txtBookID.TabIndex = 18;
            this.txtBookID.TextChanged += new System.EventHandler(this.txtBookID_TextChanged);
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Location = new System.Drawing.Point(3, 48);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(0, 16);
            this.lbBookName.TabIndex = 21;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label.Location = new System.Drawing.Point(3, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(90, 16);
            this.label.TabIndex = 25;
            this.label.Text = "Book Quantity";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label);
            this.flowLayoutPanel1.Controls.Add(this.btnPlus);
            this.flowLayoutPanel1.Controls.Add(this.lbBookQuantity);
            this.flowLayoutPanel1.Controls.Add(this.btnMinus);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 146);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(351, 38);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.White;
            this.btnPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.ForeColor = System.Drawing.Color.White;
            this.btnPlus.Image = ((System.Drawing.Image)(resources.GetObject("btnPlus.Image")));
            this.btnPlus.Location = new System.Drawing.Point(99, 3);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(27, 28);
            this.btnPlus.TabIndex = 21;
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lbBookQuantity
            // 
            this.lbBookQuantity.AutoSize = true;
            this.lbBookQuantity.Location = new System.Drawing.Point(132, 10);
            this.lbBookQuantity.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbBookQuantity.Name = "lbBookQuantity";
            this.lbBookQuantity.Size = new System.Drawing.Size(14, 16);
            this.lbBookQuantity.TabIndex = 26;
            this.lbBookQuantity.Text = "0";
            // 
            // btnMinus
            // 
            this.btnMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.ForeColor = System.Drawing.Color.White;
            this.btnMinus.Image = ((System.Drawing.Image)(resources.GetObject("btnMinus.Image")));
            this.btnMinus.Location = new System.Drawing.Point(152, 3);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(29, 28);
            this.btnMinus.TabIndex = 22;
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btDone
            // 
            this.btDone.BackColor = System.Drawing.Color.SeaShell;
            this.btDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDone.ForeColor = System.Drawing.Color.DarkGreen;
            this.btDone.Image = ((System.Drawing.Image)(resources.GetObject("btDone.Image")));
            this.btDone.Location = new System.Drawing.Point(128, 190);
            this.btDone.Name = "btDone";
            this.btDone.Size = new System.Drawing.Size(109, 36);
            this.btDone.TabIndex = 27;
            this.btDone.Text = "Done";
            this.btDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDone.UseVisualStyleBackColor = false;
            this.btDone.Click += new System.EventHandler(this.btDone_Click);
            // 
            // Add_IssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 233);
            this.Controls.Add(this.btDone);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flpnBookQuantity);
            this.Name = "Add_IssueBook";
            this.flpnBookQuantity.ResumeLayout(false);
            this.flpnBookQuantity.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpnBookQuantity;
        private System.Windows.Forms.Label lblErrorBookID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbBookQuantity;
        private System.Windows.Forms.Button btDone;
    }
}