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
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }

        private void Bai8_Load(object sender, EventArgs e)
        {

        }

        private void txtgiai_Click(object sender, EventArgs e)
        {
            int a, b;
            if (!int.TryParse(txtinta.Text, out a) || a <= 0)
            {
                errorProvider1.SetError(txtinta, "Vui lòng nhập số nguyên dương (A > 0).");
                return;
            }
            else
            {
                errorProvider1.SetError(txtinta, "");
            }
            if (!int.TryParse(txtintb.Text, out b))
            {
                errorProvider1.SetError(txtintb, "Vui lòng nhập số nguyên hợp lệ.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtintb, "");
            }
            int x = b / a;
            txtnghiem.Text = x.ToString();

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtinta.Text = "";
            txtintb.Text = "";
            txtnghiem.Text = "";
        }
    }
}
