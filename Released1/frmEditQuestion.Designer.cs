namespace Released1
{
    partial class frmEditQuestion
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
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.rdbC = new System.Windows.Forms.RadioButton();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(113, 280);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(580, 30);
            this.txtD.TabIndex = 14;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(113, 219);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(580, 30);
            this.txtC.TabIndex = 15;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(113, 163);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(580, 30);
            this.txtB.TabIndex = 16;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(113, 114);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(580, 30);
            this.txtA.TabIndex = 17;
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Location = new System.Drawing.Point(48, 284);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(51, 26);
            this.rdbD.TabIndex = 10;
            this.rdbD.TabStop = true;
            this.rdbD.Text = "D:";
            this.rdbD.UseVisualStyleBackColor = true;
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Location = new System.Drawing.Point(48, 223);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(50, 26);
            this.rdbC.TabIndex = 11;
            this.rdbC.TabStop = true;
            this.rdbC.Text = "C:";
            this.rdbC.UseVisualStyleBackColor = true;
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Location = new System.Drawing.Point(48, 167);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(50, 26);
            this.rdbB.TabIndex = 12;
            this.rdbB.TabStop = true;
            this.rdbB.Text = "B:";
            this.rdbB.UseVisualStyleBackColor = true;
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Location = new System.Drawing.Point(48, 111);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(51, 26);
            this.rdbA.TabIndex = 13;
            this.rdbA.TabStop = true;
            this.rdbA.Text = "A:";
            this.rdbA.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(333, 355);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(177, 41);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Câu phía trước";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(516, 355);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(177, 41);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Câu tiếp theo";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(113, 23);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(580, 49);
            this.rtbContent.TabIndex = 7;
            this.rtbContent.Text = "";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(118, 364);
            this.lblIndex.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(131, 22);
            this.lblIndex.TabIndex = 5;
            this.lblIndex.Text = "<Câu hỏi số 1>";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(28, 26);
            this.lblContent.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(77, 22);
            this.lblContent.TabIndex = 6;
            this.lblContent.Text = "Câu hỏi:";
            // 
            // frmEditQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 434);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.rdbD);
            this.Controls.Add(this.rdbC);
            this.Controls.Add(this.rdbB);
            this.Controls.Add(this.rdbA);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblContent);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEditQuestion";
            this.Text = "frmEditQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.RadioButton rdbD;
        private System.Windows.Forms.RadioButton rdbC;
        private System.Windows.Forms.RadioButton rdbB;
        private System.Windows.Forms.RadioButton rdbA;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label lblContent;
    }
}