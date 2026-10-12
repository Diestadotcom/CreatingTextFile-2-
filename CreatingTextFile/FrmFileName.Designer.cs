using System.Drawing;
using System.Windows.Forms;

namespace LabStream
{
    partial class FrmFileName
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblEnterFileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnOkay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterFileName
            // 
            this.lblEnterFileName.AutoSize = true;
            this.lblEnterFileName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.lblEnterFileName.Location = new System.Drawing.Point(0, -1);
            this.lblEnterFileName.Name = "lblEnterFileName";
            this.lblEnterFileName.Size = new System.Drawing.Size(168, 30);
            this.lblEnterFileName.TabIndex = 0;
            this.lblEnterFileName.Text = "Enter File Name";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(12, 58);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(271, 20);
            this.txtFileName.TabIndex = 1;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // btnOkay
            // 
            this.btnOkay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkay.Location = new System.Drawing.Point(99, 118);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(100, 30);
            this.btnOkay.TabIndex = 2;
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // FrmFileName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblEnterFileName);
            this.Name = "FrmFileName";
            this.Text = "Enter File Name";
            this.Load += new System.EventHandler(this.FrmFileName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnOkay;
    }
}