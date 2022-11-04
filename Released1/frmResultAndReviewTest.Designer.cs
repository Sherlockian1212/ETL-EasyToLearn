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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(119, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bộ câu hỏi:";
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(48, 264);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(119, 42);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(253, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tào lao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thời gian làm bài:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(253, 89);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(56, 22);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "15:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số câu đúng:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(253, 144);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(56, 22);
            this.lblAnswer.TabIndex = 0;
            this.lblAnswer.Text = "10/10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Điểm số:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(253, 201);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(30, 22);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "10";
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(173, 264);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(119, 42);
            this.btnReview.TabIndex = 1;
            this.btnReview.Text = "Xem chi tiết";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnBeginTestAgain
            // 
            this.btnBeginTestAgain.Location = new System.Drawing.Point(298, 264);
            this.btnBeginTestAgain.Name = "btnBeginTestAgain";
            this.btnBeginTestAgain.Size = new System.Drawing.Size(119, 42);
            this.btnBeginTestAgain.TabIndex = 1;
            this.btnBeginTestAgain.Text = "Làm lại";
            this.btnBeginTestAgain.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmResultAndReviewTest";
            this.Text = "frmResultAndReviewTest";
            this.Load += new System.EventHandler(this.frmResultAndReviewTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Button btnBeginTestAgain;
    }
}