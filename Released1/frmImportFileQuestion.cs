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
    public partial class frmImportFileQuestion : Form
    {
        public frmImportFileQuestion()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*|";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtAddress.Text = ofd.FileName; 
            }
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Đọc dữ liệu
            

            if (txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn file", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Temp.soq = new SetOfQuestion();
                Temp.soq.checkFile(txtAddress.Text);
                this.Close();
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
