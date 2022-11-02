namespace Released1
{
    partial class frmEditSetOfQuestion
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
            this.rdbNewQuestion = new System.Windows.Forms.RadioButton();
            this.rdbImportFile = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.lblNumOfQ = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdbNewQuestion
            // 
            this.rdbNewQuestion.AutoSize = true;
            this.rdbNewQuestion.Location = new System.Drawing.Point(451, 178);
            this.rdbNewQuestion.Name = "rdbNewQuestion";
            this.rdbNewQuestion.Size = new System.Drawing.Size(176, 26);
            this.rdbNewQuestion.TabIndex = 13;
            this.rdbNewQuestion.TabStop = true;
            this.rdbNewQuestion.Text = "Thêm từng câu hỏi";
            this.rdbNewQuestion.UseVisualStyleBackColor = true;
            // 
            // rdbImportFile
            // 
            this.rdbImportFile.AutoSize = true;
            this.rdbImportFile.Location = new System.Drawing.Point(243, 178);
            this.rdbImportFile.Name = "rdbImportFile";
            this.rdbImportFile.Size = new System.Drawing.Size(166, 26);
            this.rdbImportFile.TabIndex = 14;
            this.rdbImportFile.TabStop = true;
            this.rdbImportFile.Text = "Nhập file (.CSV)";
            this.rdbImportFile.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(243, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(166, 30);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(243, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(384, 30);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 30);
            this.textBox1.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(243, 221);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(384, 38);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm câu hỏi";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(337, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 38);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(485, 274);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(142, 38);
            this.btnOut.TabIndex = 9;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            // 
            // lblNumOfQ
            // 
            this.lblNumOfQ.AutoSize = true;
            this.lblNumOfQ.Location = new System.Drawing.Point(83, 121);
            this.lblNumOfQ.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumOfQ.Name = "lblNumOfQ";
            this.lblNumOfQ.Size = new System.Drawing.Size(144, 22);
            this.lblNumOfQ.TabIndex = 4;
            this.lblNumOfQ.Text = "Số lượng câu hỏi";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(83, 71);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(56, 22);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Mô tả";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(83, 22);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(127, 22);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Tên bộ câu hỏi";
            // 
            // frmEditSetOfQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 348);
            this.Controls.Add(this.rdbNewQuestion);
            this.Controls.Add(this.rdbImportFile);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.lblNumOfQ);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEditSetOfQuestion";
            this.Text = "frmEditSetOfQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbNewQuestion;
        private System.Windows.Forms.RadioButton rdbImportFile;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Label lblNumOfQ;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
    }
}