namespace Released1
{
    partial class frmResultAndReviewTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultAndReviewTest));
            this.label1 = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnBeginTestAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(119, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bộ câu hỏi:";
            // 
            // btnOut
            // 
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOut.Location = new System.Drawing.Point(49, 264);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(119, 46);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblName.Location = new System.Drawing.Point(253, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 35);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Noname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(108, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số câu đúng:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAnswer.Location = new System.Drawing.Point(253, 93);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(60, 35);
            this.lblAnswer.TabIndex = 0;
            this.lblAnswer.Text = "00/00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(138, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 35);
            this.label7.TabIndex = 0;
            this.label7.Text = "Điểm số:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblScore.Location = new System.Drawing.Point(253, 144);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(30, 35);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "10";
            // 
            // btnReview
            // 
            this.btnReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReview.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReview.Location = new System.Drawing.Point(173, 264);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(119, 46);
            this.btnReview.TabIndex = 2;
            this.btnReview.Text = "Xem chi tiết";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnBeginTestAgain
            // 
            this.btnBeginTestAgain.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBeginTestAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeginTestAgain.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBeginTestAgain.Location = new System.Drawing.Point(298, 264);
            this.btnBeginTestAgain.Name = "btnBeginTestAgain";
            this.btnBeginTestAgain.Size = new System.Drawing.Size(119, 46);
            this.btnBeginTestAgain.TabIndex = 3;
            this.btnBeginTestAgain.Text = "Làm lại";
            this.btnBeginTestAgain.UseVisualStyleBackColor = false;
            this.btnBeginTestAgain.Click += new System.EventHandler(this.btnBeginTestAgain_Click);
            // 
            // frmResultAndReviewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 351);
            this.Controls.Add(this.btnBeginTestAgain);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmResultAndReviewTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ETL-v1.0";
            this.Load += new System.EventHandler(this.frmResultAndReviewTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Button btnBeginTestAgain;
    }
}