﻿namespace Released1
{
    partial class frmReviewTest
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
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(211, 419);
            this.txtD.Margin = new System.Windows.Forms.Padding(4);
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.Size = new System.Drawing.Size(796, 30);
            this.txtD.TabIndex = 27;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(210, 341);
            this.txtC.Margin = new System.Windows.Forms.Padding(4);
            this.txtC.Name = "txtC";
            this.txtC.ReadOnly = true;
            this.txtC.Size = new System.Drawing.Size(796, 30);
            this.txtC.TabIndex = 28;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(210, 264);
            this.txtB.Margin = new System.Windows.Forms.Padding(4);
            this.txtB.Name = "txtB";
            this.txtB.ReadOnly = true;
            this.txtB.Size = new System.Drawing.Size(796, 30);
            this.txtB.TabIndex = 29;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(210, 187);
            this.txtA.Margin = new System.Windows.Forms.Padding(4);
            this.txtA.Name = "txtA";
            this.txtA.ReadOnly = true;
            this.txtA.Size = new System.Drawing.Size(796, 30);
            this.txtA.TabIndex = 30;
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Location = new System.Drawing.Point(121, 423);
            this.rdbD.Margin = new System.Windows.Forms.Padding(4);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(51, 26);
            this.rdbD.TabIndex = 23;
            this.rdbD.TabStop = true;
            this.rdbD.Text = "D:";
            this.rdbD.UseVisualStyleBackColor = true;
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Location = new System.Drawing.Point(121, 345);
            this.rdbC.Margin = new System.Windows.Forms.Padding(4);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(50, 26);
            this.rdbC.TabIndex = 24;
            this.rdbC.TabStop = true;
            this.rdbC.Text = "C:";
            this.rdbC.UseVisualStyleBackColor = true;
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Location = new System.Drawing.Point(121, 268);
            this.rdbB.Margin = new System.Windows.Forms.Padding(4);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(50, 26);
            this.rdbB.TabIndex = 25;
            this.rdbB.TabStop = true;
            this.rdbB.Text = "B:";
            this.rdbB.UseVisualStyleBackColor = true;
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Location = new System.Drawing.Point(121, 191);
            this.rdbA.Margin = new System.Windows.Forms.Padding(4);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(51, 26);
            this.rdbA.TabIndex = 26;
            this.rdbA.TabStop = true;
            this.rdbA.Text = "A:";
            this.rdbA.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(513, 526);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(243, 56);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Câu phía trước";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(764, 526);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(243, 56);
            this.btnNext.TabIndex = 22;
            this.btnNext.Text = "Câu tiếp theo";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // rtbContent
            // 
            this.rtbContent.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtbContent.Location = new System.Drawing.Point(210, 36);
            this.rtbContent.Margin = new System.Windows.Forms.Padding(4);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.ReadOnly = true;
            this.rtbContent.Size = new System.Drawing.Size(796, 121);
            this.rtbContent.TabIndex = 20;
            this.rtbContent.Text = "";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(207, 543);
            this.lblIndex.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(101, 22);
            this.lblIndex.TabIndex = 18;
            this.lblIndex.Text = "<Câu số 1>";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(94, 36);
            this.lblContent.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(77, 22);
            this.lblContent.TabIndex = 19;
            this.lblContent.Text = "Câu hỏi:";
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.ForeColor = System.Drawing.Color.Red;
            this.lblCorrectAnswer.Location = new System.Drawing.Point(207, 489);
            this.lblCorrectAnswer.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(162, 22);
            this.lblCorrectAnswer.TabIndex = 19;
            this.lblCorrectAnswer.Text = "Câu trả lời đúng: A";
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(399, 526);
            this.btnOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(106, 56);
            this.btnOut.TabIndex = 21;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // frmReviewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.rdbD);
            this.Controls.Add(this.rdbC);
            this.Controls.Add(this.rdbB);
            this.Controls.Add(this.rdbA);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblCorrectAnswer);
            this.Controls.Add(this.lblContent);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmReviewTest";
            this.Text = "frmReviewTest";
            this.Load += new System.EventHandler(this.frmReviewTest_Load);
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
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.Button btnOut;
    }
}