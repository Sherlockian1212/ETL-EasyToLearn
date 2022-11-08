namespace Released1
{
    partial class frmShowQuestionInTest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowQuestionInTest));
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.rdbC = new System.Windows.Forms.RadioButton();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.lblTextTime = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.lblIndex = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbD.Location = new System.Drawing.Point(121, 407);
            this.rdbD.Margin = new System.Windows.Forms.Padding(4);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(49, 39);
            this.rdbD.TabIndex = 5;
            this.rdbD.TabStop = true;
            this.rdbD.Text = "D:";
            this.rdbD.UseVisualStyleBackColor = true;
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbC.Location = new System.Drawing.Point(121, 329);
            this.rdbC.Margin = new System.Windows.Forms.Padding(4);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(48, 39);
            this.rdbC.TabIndex = 4;
            this.rdbC.TabStop = true;
            this.rdbC.Text = "C:";
            this.rdbC.UseVisualStyleBackColor = true;
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbB.Location = new System.Drawing.Point(121, 252);
            this.rdbB.Margin = new System.Windows.Forms.Padding(4);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(49, 39);
            this.rdbB.TabIndex = 3;
            this.rdbB.TabStop = true;
            this.rdbB.Text = "B:";
            this.rdbB.UseVisualStyleBackColor = true;
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbA.Location = new System.Drawing.Point(121, 175);
            this.rdbA.Margin = new System.Windows.Forms.Padding(4);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(49, 39);
            this.rdbA.TabIndex = 2;
            this.rdbA.TabStop = true;
            this.rdbA.Text = "A:";
            this.rdbA.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBack.Location = new System.Drawing.Point(513, 510);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(243, 56);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Câu phía trước";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNext.Location = new System.Drawing.Point(764, 510);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(243, 56);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Câu tiếp theo";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // rtbContent
            // 
            this.rtbContent.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtbContent.Location = new System.Drawing.Point(210, 20);
            this.rtbContent.Margin = new System.Windows.Forms.Padding(4);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.ReadOnly = true;
            this.rtbContent.Size = new System.Drawing.Size(796, 121);
            this.rtbContent.TabIndex = 1;
            this.rtbContent.Text = "";
            // 
            // lblTextTime
            // 
            this.lblTextTime.AutoSize = true;
            this.lblTextTime.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTextTime.Location = new System.Drawing.Point(1050, 20);
            this.lblTextTime.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTextTime.Name = "lblTextTime";
            this.lblTextTime.Size = new System.Drawing.Size(135, 35);
            this.lblTextTime.TabIndex = 5;
            this.lblTextTime.Text = "Thời gian còn lại";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblContent.Location = new System.Drawing.Point(94, 20);
            this.lblContent.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(71, 35);
            this.lblContent.TabIndex = 6;
            this.lblContent.Text = "Câu hỏi:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Bangers", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(1071, 108);
            this.lblTime.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(79, 49);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "00:00";
            // 
            // btnShowHide
            // 
            this.btnShowHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowHide.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShowHide.Location = new System.Drawing.Point(1054, 55);
            this.btnShowHide.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(108, 49);
            this.btnShowHide.TabIndex = 8;
            this.btnShowHide.Text = "Ẩn/hiện";
            this.btnShowHide.UseVisualStyleBackColor = true;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIndex.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblIndex.Location = new System.Drawing.Point(207, 527);
            this.lblIndex.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(85, 35);
            this.lblIndex.TabIndex = 5;
            this.lblIndex.Text = "<Câu số 1>";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSubmit.Location = new System.Drawing.Point(1054, 175);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 52);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Nộp bài";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(209, 175);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(72, 22);
            this.lblA.TabIndex = 18;
            this.lblA.Text = "Answer";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(207, 252);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(72, 22);
            this.lblB.TabIndex = 18;
            this.lblB.Text = "Answer";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(209, 329);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(72, 22);
            this.lblC.TabIndex = 18;
            this.lblC.Text = "Answer";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(206, 407);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(72, 22);
            this.lblD.TabIndex = 18;
            this.lblD.Text = "Answer";
            // 
            // frmShowQuestionInTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 619);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rdbD);
            this.Controls.Add(this.rdbC);
            this.Controls.Add(this.rdbB);
            this.Controls.Add(this.rdbA);
            this.Controls.Add(this.btnShowHide);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblTextTime);
            this.Controls.Add(this.lblContent);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmShowQuestionInTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ETL-v1.0";
            this.Load += new System.EventHandler(this.frmShowQuestionInTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbD;
        private System.Windows.Forms.RadioButton rdbC;
        private System.Windows.Forms.RadioButton rdbB;
        private System.Windows.Forms.RadioButton rdbA;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Label lblTextTime;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblD;
    }
}