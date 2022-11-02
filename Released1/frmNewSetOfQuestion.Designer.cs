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
            this.lblName = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescribe = new System.Windows.Forms.TextBox();
            this.rdbImportFile = new System.Windows.Forms.RadioButton();
            this.rdbNewQuestion = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNumOfQ = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(86, 20);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(127, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên bộ câu hỏi";
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(484, 219);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(142, 38);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(246, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(384, 30);
            this.txtName.TabIndex = 2;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(86, 69);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(56, 22);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Mô tả";
            // 
            // txtDescribe
            // 
            this.txtDescribe.Location = new System.Drawing.Point(246, 61);
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.Size = new System.Drawing.Size(384, 30);
            this.txtDescribe.TabIndex = 2;
            // 
            // rdbImportFile
            // 
            this.rdbImportFile.AutoSize = true;
            this.rdbImportFile.Location = new System.Drawing.Point(246, 176);
            this.rdbImportFile.Name = "rdbImportFile";
            this.rdbImportFile.Size = new System.Drawing.Size(166, 26);
            this.rdbImportFile.TabIndex = 3;
            this.rdbImportFile.TabStop = true;
            this.rdbImportFile.Text = "Nhập file (.CSV)";
            this.rdbImportFile.UseVisualStyleBackColor = true;
            // 
            // rdbNewQuestion
            // 
            this.rdbNewQuestion.AutoSize = true;
            this.rdbNewQuestion.Location = new System.Drawing.Point(454, 176);
            this.rdbNewQuestion.Name = "rdbNewQuestion";
            this.rdbNewQuestion.Size = new System.Drawing.Size(176, 26);
            this.rdbNewQuestion.TabIndex = 3;
            this.rdbNewQuestion.TabStop = true;
            this.rdbNewQuestion.Text = "Thêm từng câu hỏi";
            this.rdbNewQuestion.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(246, 219);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(232, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm câu hỏi";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNumOfQ
            // 
            this.lblNumOfQ.AutoSize = true;
            this.lblNumOfQ.Location = new System.Drawing.Point(86, 119);
            this.lblNumOfQ.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumOfQ.Name = "lblNumOfQ";
            this.lblNumOfQ.Size = new System.Drawing.Size(144, 22);
            this.lblNumOfQ.TabIndex = 0;
            this.lblNumOfQ.Text = "Số lượng câu hỏi";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(246, 111);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(166, 30);
            this.txtNumber.TabIndex = 2;
            this.txtNumber.Leave += new System.EventHandler(this.txtNumber_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmNewSetOfQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 279);
            this.Controls.Add(this.rdbNewQuestion);
            this.Controls.Add(this.rdbImportFile);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtDescribe);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.lblNumOfQ);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmNewSetOfQuestion";
            this.Text = "frmNewSetOfQuestion";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescribe;
        private System.Windows.Forms.RadioButton rdbImportFile;
        private System.Windows.Forms.RadioButton rdbNewQuestion;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNumOfQ;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}