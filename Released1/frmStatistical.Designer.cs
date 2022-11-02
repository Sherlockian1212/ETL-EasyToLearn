namespace Released1
{
    partial class frmStatistical
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.clNumOfTest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOut = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMaxScore = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clNumOfTest,
            this.clName,
            this.clScore});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(237, 13);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(677, 274);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clNumOfTest
            // 
            this.clNumOfTest.Text = "STT";
            // 
            // clName
            // 
            this.clName.Text = "Tên bài Test";
            this.clName.Width = 318;
            // 
            // clScore
            // 
            this.clScore.Text = "Điểm số";
            this.clScore.Width = 134;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(774, 325);
            this.btnOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(140, 51);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(626, 325);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 51);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Xóa dữ liệu";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMaxScore
            // 
            this.lblMaxScore.AutoSize = true;
            this.lblMaxScore.Location = new System.Drawing.Point(12, 13);
            this.lblMaxScore.Name = "lblMaxScore";
            this.lblMaxScore.Size = new System.Drawing.Size(177, 22);
            this.lblMaxScore.TabIndex = 2;
            this.lblMaxScore.Text = "Điểm số cao nhất: 10";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(12, 63);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(190, 22);
            this.lblAverage.TabIndex = 2;
            this.lblAverage.Text = "Điểm số trung bình: 10";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(12, 116);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(126, 22);
            this.lblRank.TabIndex = 2;
            this.lblRank.Text = "Xếp loại: Giỏi";
            // 
            // frmStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 427);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblMaxScore);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStatistical";
            this.Text = "frmStatistical";
            this.Load += new System.EventHandler(this.frmStatistical_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clNumOfTest;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clScore;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMaxScore;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblRank;
    }
}