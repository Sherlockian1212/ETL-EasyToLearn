namespace Released1
{
    partial class frmHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePage));
            this.btnNewSetOfQuestion = new System.Windows.Forms.Button();
            this.btnNewTest = new System.Windows.Forms.Button();
            this.btnStatistical = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.cboSearchSetOfQuestion = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lstvSetOfQuestion = new System.Windows.Forms.ListView();
            this.clNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cnNumOfQ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnNewSetOfQuestion
            // 
            resources.ApplyResources(this.btnNewSetOfQuestion, "btnNewSetOfQuestion");
            this.btnNewSetOfQuestion.Name = "btnNewSetOfQuestion";
            this.btnNewSetOfQuestion.UseVisualStyleBackColor = true;
            this.btnNewSetOfQuestion.Click += new System.EventHandler(this.btnNewSetOfQuestion_Click);
            // 
            // btnNewTest
            // 
            resources.ApplyResources(this.btnNewTest, "btnNewTest");
            this.btnNewTest.Name = "btnNewTest";
            this.btnNewTest.UseVisualStyleBackColor = true;
            this.btnNewTest.Click += new System.EventHandler(this.btnNewTest_Click);
            // 
            // btnStatistical
            // 
            resources.ApplyResources(this.btnStatistical, "btnStatistical");
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.UseVisualStyleBackColor = true;
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click);
            // 
            // btnHomePage
            // 
            this.btnHomePage.BackColor = System.Drawing.Color.Gold;
            resources.ApplyResources(this.btnHomePage, "btnHomePage");
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.UseVisualStyleBackColor = false;
            // 
            // cboSearchSetOfQuestion
            // 
            resources.ApplyResources(this.cboSearchSetOfQuestion, "cboSearchSetOfQuestion");
            this.cboSearchSetOfQuestion.FormattingEnabled = true;
            this.cboSearchSetOfQuestion.Name = "cboSearchSetOfQuestion";
            // 
            // lblSearch
            // 
            resources.ApplyResources(this.lblSearch, "lblSearch");
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblSearch.Name = "lblSearch";
            // 
            // lstvSetOfQuestion
            // 
            this.lstvSetOfQuestion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clNo,
            this.clName,
            this.cnNumOfQ});
            resources.ApplyResources(this.lstvSetOfQuestion, "lstvSetOfQuestion");
            this.lstvSetOfQuestion.FullRowSelect = true;
            this.lstvSetOfQuestion.GridLines = true;
            this.lstvSetOfQuestion.HideSelection = false;
            this.lstvSetOfQuestion.Name = "lstvSetOfQuestion";
            this.lstvSetOfQuestion.UseCompatibleStateImageBehavior = false;
            this.lstvSetOfQuestion.View = System.Windows.Forms.View.Details;
            // 
            // clNo
            // 
            resources.ApplyResources(this.clNo, "clNo");
            // 
            // clName
            // 
            resources.ApplyResources(this.clName, "clName");
            // 
            // cnNumOfQ
            // 
            resources.ApplyResources(this.cnNumOfQ, "cnNumOfQ");
            // 
            // frmHomePage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstvSetOfQuestion);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cboSearchSetOfQuestion);
            this.Controls.Add(this.btnStatistical);
            this.Controls.Add(this.btnNewTest);
            this.Controls.Add(this.btnNewSetOfQuestion);
            this.Controls.Add(this.btnHomePage);
            this.Name = "frmHomePage";
            this.Load += new System.EventHandler(this.frmHomePage_Load);
            this.Click += new System.EventHandler(this.frmHomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNewSetOfQuestion;
        private System.Windows.Forms.Button btnNewTest;
        private System.Windows.Forms.Button btnStatistical;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.ComboBox cboSearchSetOfQuestion;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ListView lstvSetOfQuestion;
        private System.Windows.Forms.ColumnHeader clNo;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader cnNumOfQ;
    }
}

