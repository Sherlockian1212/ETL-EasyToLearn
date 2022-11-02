namespace Released1
{
    partial class frmImportFileQuestion
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
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(134, 13);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(325, 30);
            this.txtAddress.TabIndex = 0;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(34, 23);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 22);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "File:";
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(134, 82);
            this.btnChoose.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(103, 43);
            this.btnChoose.TabIndex = 2;
            this.btnChoose.Text = "Chọn File";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(245, 82);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 43);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Hoàn tất";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(356, 82);
            this.btnOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(103, 43);
            this.btnOut.TabIndex = 2;
            this.btnOut.Text = "Hủy";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // frmImportFileQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 155);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmImportFileQuestion";
            this.Text = "frmImportFileQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOut;
    }
}