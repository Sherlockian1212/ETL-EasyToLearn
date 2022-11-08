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
            this.btnHomePage = new System.Windows.Forms.Button();
            this.cboSearchSetOfQuestion = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lstvSetOfQuestion = new System.Windows.Forms.ListView();
            this.clNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cnNumOfQ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.chbShow = new System.Windows.Forms.CheckBox();
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
            // btnHomePage
            // 
            this.btnHomePage.BackColor = System.Drawing.Color.SkyBlue;
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
            resources.ApplyResources(this.lstvSetOfQuestion, "lstvSetOfQuestion");
            this.lstvSetOfQuestion.BackColor = System.Drawing.SystemColors.Window;
            this.lstvSetOfQuestion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clNo,
            this.clName,
            this.cnNumOfQ});
            this.lstvSetOfQuestion.FullRowSelect = true;
            this.lstvSetOfQuestion.GridLines = true;
            this.lstvSetOfQuestion.HideSelection = false;
            this.lstvSetOfQuestion.HoverSelection = true;
            this.lstvSetOfQuestion.MultiSelect = false;
            this.lstvSetOfQuestion.Name = "lstvSetOfQuestion";
            this.lstvSetOfQuestion.UseCompatibleStateImageBehavior = false;
            this.lstvSetOfQuestion.View = System.Windows.Forms.View.Details;
            this.lstvSetOfQuestion.SelectedIndexChanged += new System.EventHandler(this.lstvSetOfQuestion_SelectedIndexChanged);
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
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.frmHomePage_Load);
            // 
            // chbShow
            // 
            resources.ApplyResources(this.chbShow, "chbShow");
            this.chbShow.BackColor = System.Drawing.Color.Transparent;
            this.chbShow.Name = "chbShow";
            this.chbShow.UseVisualStyleBackColor = false;
            this.chbShow.Click += new System.EventHandler(this.chbShow_CheckedChanged);
            // 
            // frmHomePage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Released1.Properties.Resources.BG02;
            this.Controls.Add(this.chbShow);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lstvSetOfQuestion);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cboSearchSetOfQuestion);
            this.Controls.Add(this.btnNewTest);
            this.Controls.Add(this.btnNewSetOfQuestion);
            this.Controls.Add(this.btnHomePage);
            this.Name = "frmHomePage";
            this.Load += new System.EventHandler(this.frmHomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNewSetOfQuestion;
        private System.Windows.Forms.Button btnNewTest;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.ComboBox cboSearchSetOfQuestion;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ListView lstvSetOfQuestion;
        private System.Windows.Forms.ColumnHeader clNo;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader cnNumOfQ;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.CheckBox chbShow;
    }
}

