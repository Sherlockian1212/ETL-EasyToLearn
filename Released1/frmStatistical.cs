using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Released1
{
    public partial class frmStatistical : Form
    {
        public frmStatistical()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStatistical_Load(object sender, EventArgs e)
        {

            lblMaxScore.Text = "Điểm số cao nhất: " + Statistical.dMaxScore.ToString();
            double aver;
            if (Statistical.iCount != 0)
                aver = Statistical.dScore.Sum() / Statistical.iCount;
            else
            {
                aver = 0;
            }
            lblAverage.Text = "Điểm số trung bình: " + aver.ToString();
            if (aver >= 8) lblRank.Text = "Xếp loại: Giỏi";
            else if (aver >= 6.5) lblRank.Text = "Xếp loại: Khá";
            else if (aver >= 5) lblRank.Text = "Xếp loại: Trung bình";
            else if (aver >= 4.5) lblRank.Text = "Xếp loại: Yếu";
            else lblRank.Text = "Xếp loại: Kém";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Statistical.iCount = 0;
            Statistical.strName = new List<string>();
            Statistical.dScore = new List<double>();
            Statistical.dMaxScore = 0;
    }
}
}
