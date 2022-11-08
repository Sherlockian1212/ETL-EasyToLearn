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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditQuestion));
            this.lblContent = new System.Windows.Forms.Label();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.rdbC = new System.Windows.Forms.RadioButton();
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.lblIndex = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblContent.Location = new System.Drawing.Point(30, 26);
            this.lblContent.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(71, 35);
            this.lblContent.TabIndex = 0;
            this.lblContent.Text = "Câu hỏi:";
            // 
            // rtbContent
            // 
            this.rtbContent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtbContent.Location = new System.Drawing.Point(115, 23);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(599, 49);
            this.rtbContent.TabIndex = 1;
            this.rtbContent.Text = "";
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNext.Location = new System.Drawing.Point(584, 355);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(130, 41);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Câu tiếp theo";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbA.Location = new System.Drawing.Point(50, 111);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(49, 39);
            this.rdbA.TabIndex = 3;
            this.rdbA.TabStop = true;
            this.rdbA.Text = "A:";
            this.rdbA.UseVisualStyleBackColor = true;
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbB.Location = new System.Drawing.Point(50, 167);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(49, 39);
            this.rdbB.TabIndex = 3;
            this.rdbB.TabStop = true;
            this.rdbB.Text = "B:";
            this.rdbB.UseVisualStyleBackColor = true;
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbC.Location = new System.Drawing.Point(50, 223);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(48, 39);
            this.rdbC.TabIndex = 3;
            this.rdbC.TabStop = true;
            this.rdbC.Text = "C:";
            this.rdbC.UseVisualStyleBackColor = true;
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbD.Location = new System.Drawing.Point(50, 284);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(49, 39);
            this.rdbD.TabIndex = 3;
            this.rdbD.TabStop = true;
            this.rdbD.Text = "D:";
            this.rdbD.UseVisualStyleBackColor = true;
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtA.Location = new System.Drawing.Point(115, 111);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(599, 30);
            this.txtA.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtB.Location = new System.Drawing.Point(115, 167);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(599, 30);
            this.txtB.TabIndex = 3;
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtC.Location = new System.Drawing.Point(115, 223);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(599, 30);
            this.txtC.TabIndex = 4;
            // 
            // txtD
            // 
            this.txtD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtD.Location = new System.Drawing.Point(115, 284);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(599, 30);
            this.txtD.TabIndex = 5;
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblIndex.Location = new System.Drawing.Point(120, 364);
            this.lblIndex.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(112, 35);
            this.lblIndex.TabIndex = 0;
            this.lblIndex.Text = "<Câu hỏi số 1>";
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBack.Location = new System.Drawing.Point(439, 355);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(139, 41);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Câu phía trước";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.Location = new System.Drawing.Point(733, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 41);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOut
            // 
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOut.Location = new System.Drawing.Point(823, 355);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(84, 41);
            this.btnOut.TabIndex = 9;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Location = new System.Drawing.Point(733, 70);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(174, 41);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa câu hỏi";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Bangers", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.Location = new System.Drawing.Point(733, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(174, 41);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm câu hỏi";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmEditQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(919, 431);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.rdbD);
            this.Controls.Add(this.rdbC);
            this.Controls.Add(this.rdbB);
            this.Controls.Add(this.rdbA);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblContent);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmEditQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ETL-v1.0";
            this.Load += new System.EventHandler(this.frmEditQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton rdbA;
        private System.Windows.Forms.RadioButton rdbB;
        private System.Windows.Forms.RadioButton rdbC;
        private System.Windows.Forms.RadioButton rdbD;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}