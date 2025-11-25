using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = "Tên đăng nhập là: ";
            thongbao += this.txtlogin.Text;
            thongbao += "\n\rMật khẩu là: ";
            thongbao += this.txtpass.Text;
            if (this.chkghinho.Checked == true)
            {
                { thongbao += "\n\rBạn có ghi nhớ."; }
                MessageBox.Show(thongbao, "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtlogin.Text = "";
            txtpass.Text = "";
        }

        private void btndung_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
