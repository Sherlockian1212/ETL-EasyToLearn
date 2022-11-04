using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
                Temp.Data_NameOfQ.Add(Temp.soq._strName);
                Temp.Data_NumberOfQ.Add(Temp.soq._iNumOfQ.ToString());

               
                Temp.soq.checkFile(txtAddress.Text);
                string sourceFile = txtAddress.Text;
                string destFile = System.IO.Path.Combine(Application.StartupPath + @"\SOQ", Temp.soq._strName.Trim() + ".csv");
                System.IO.File.Copy(sourceFile, destFile, true);

                DialogResult r = MessageBox.Show("Bạn có muốn lưu và thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    Temp.soq = new SetOfQuestion();
                    Temp.Check = true;
                    this.Close();

                }
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
