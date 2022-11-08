namespace Released1
{
    partial class frmNewSetOfQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewSetOfQuestion));
            this.lblName = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rdbImportFile = new System.Windows.Forms.RadioButton();
            this.rdbNewQuestion = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNumOfQ = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMethodText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblName.Location = new System.Drawing.Point(14, 7);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 35);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên bộ câu hỏi:";
            // 
            // btnOut
            // 
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOut.Location = new System.Drawing.Point(297, 172);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(142, 48);
            this.btnOut.TabIndex = 6;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 7);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(384, 30);
            this.txtName.TabIndex = 1;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // rdbImportFile
            // 
            this.rdbImportFile.AutoSize = true;
            this.rdbImportFile.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbImportFile.Location = new System.Drawing.Point(175, 118);
            this.rdbImportFile.Name = "rdbImportFile";
            this.rdbImportFile.Size = new System.Drawing.Size(146, 39);
            this.rdbImportFile.TabIndex = 3;
            this.rdbImportFile.TabStop = true;
            this.rdbImportFile.Text = "Nhập file (.CSV)";
            this.rdbImportFile.UseVisualStyleBackColor = true;
            this.rdbImportFile.CheckedChanged += new System.EventHandler(this.rdbImportFile_CheckedChanged);
            // 
            // rdbNewQuestion
            // 
            this.rdbNewQuestion.AutoSize = true;
            this.rdbNewQuestion.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbNewQuestion.Location = new System.Drawing.Point(383, 118);
            this.rdbNewQuestion.Name = "rdbNewQuestion";
            this.rdbNewQuestion.Size = new System.Drawing.Size(165, 39);
            this.rdbNewQuestion.TabIndex = 4;
            this.rdbNewQuestion.TabStop = true;
            this.rdbNewQuestion.Text = "Thêm từng câu hỏi";
            this.rdbNewQuestion.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.Location = new System.Drawing.Point(574, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 48);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm câu hỏi";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNumOfQ
            // 
            this.lblNumOfQ.AutoSize = true;
            this.lblNumOfQ.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNumOfQ.Location = new System.Drawing.Point(14, 58);
            this.lblNumOfQ.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumOfQ.Name = "lblNumOfQ";
            this.lblNumOfQ.Size = new System.Drawing.Size(141, 35);
            this.lblNumOfQ.TabIndex = 0;
            this.lblNumOfQ.Text = "Số lượng câu hỏi:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(175, 58);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(166, 30);
            this.txtNumber.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblMethodText
            // 
            this.lblMethodText.AutoSize = true;
            this.lblMethodText.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMethodText.Location = new System.Drawing.Point(14, 120);
            this.lblMethodText.Name = "lblMethodText";
            this.lblMethodText.Size = new System.Drawing.Size(148, 35);
            this.lblMethodText.TabIndex = 4;
            this.lblMethodText.Text = "Phương thức nhập:";
            // 
            // frmNewSetOfQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 242);
            this.Controls.Add(this.lblMethodText);
            this.Controls.Add(this.rdbNewQuestion);
            this.Controls.Add(this.rdbImportFile);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.lblNumOfQ);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmNewSetOfQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ETL-v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rdbImportFile;
        private System.Windows.Forms.RadioButton rdbNewQuestion;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNumOfQ;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblMethodText;
    }
}