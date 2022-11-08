namespace Released1
{
    partial class frmNewTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewTest));
            this.lblSetOfQuestion = new System.Windows.Forms.Label();
            this.cboSetOfQuestion = new System.Windows.Forms.ComboBox();
            this.btnBeginTest = new System.Windows.Forms.Button();
            this.lblNumOfQ = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.txtNumOfQ = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSetOfQuestion
            // 
            this.lblSetOfQuestion.AutoSize = true;
            this.lblSetOfQuestion.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSetOfQuestion.Location = new System.Drawing.Point(13, 12);
            this.lblSetOfQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSetOfQuestion.Name = "lblSetOfQuestion";
            this.lblSetOfQuestion.Size = new System.Drawing.Size(134, 35);
            this.lblSetOfQuestion.TabIndex = 0;
            this.lblSetOfQuestion.Text = "Chọn bộ câu hỏi:";
            // 
            // cboSetOfQuestion
            // 
            this.cboSetOfQuestion.FormattingEnabled = true;
            this.cboSetOfQuestion.Location = new System.Drawing.Point(193, 12);
            this.cboSetOfQuestion.Name = "cboSetOfQuestion";
            this.cboSetOfQuestion.Size = new System.Drawing.Size(363, 30);
            this.cboSetOfQuestion.TabIndex = 1;
            this.cboSetOfQuestion.SelectedIndexChanged += new System.EventHandler(this.cboSetOfQuestion_SelectedIndexChanged);
            // 
            // btnBeginTest
            // 
            this.btnBeginTest.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBeginTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeginTest.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBeginTest.Location = new System.Drawing.Point(193, 177);
            this.btnBeginTest.Name = "btnBeginTest";
            this.btnBeginTest.Size = new System.Drawing.Size(213, 50);
            this.btnBeginTest.TabIndex = 4;
            this.btnBeginTest.Text = "Làm bài";
            this.btnBeginTest.UseVisualStyleBackColor = false;
            this.btnBeginTest.Click += new System.EventHandler(this.btnBeginTest_Click);
            // 
            // lblNumOfQ
            // 
            this.lblNumOfQ.AutoSize = true;
            this.lblNumOfQ.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNumOfQ.Location = new System.Drawing.Point(13, 57);
            this.lblNumOfQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumOfQ.Name = "lblNumOfQ";
            this.lblNumOfQ.Size = new System.Drawing.Size(141, 35);
            this.lblNumOfQ.TabIndex = 0;
            this.lblNumOfQ.Text = "Số lượng câu hỏi:";
            // 
            // btnOut
            // 
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOut.Location = new System.Drawing.Point(412, 177);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(144, 50);
            this.btnOut.TabIndex = 5;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // txtNumOfQ
            // 
            this.txtNumOfQ.Location = new System.Drawing.Point(193, 57);
            this.txtNumOfQ.Name = "txtNumOfQ";
            this.txtNumOfQ.Size = new System.Drawing.Size(363, 30);
            this.txtNumOfQ.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTime.Location = new System.Drawing.Point(13, 103);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(85, 35);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Thời gian:";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(193, 103);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 30);
            this.txtTime.TabIndex = 3;
            // 
            // frmNewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 239);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtNumOfQ);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnBeginTest);
            this.Controls.Add(this.cboSetOfQuestion);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblNumOfQ);
            this.Controls.Add(this.lblSetOfQuestion);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNewTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ETL-v1.0";
            this.Load += new System.EventHandler(this.frmNewTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSetOfQuestion;
        private System.Windows.Forms.ComboBox cboSetOfQuestion;
        private System.Windows.Forms.Button btnBeginTest;
        private System.Windows.Forms.Label lblNumOfQ;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.TextBox txtNumOfQ;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
    }
}