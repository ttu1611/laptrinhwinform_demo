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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void Bai4_Load(object sender, EventArgs e)
        {

        }

        private void radcong_CheckedChanged(object sender, EventArgs e)
        {
            int tong;

            tong = int.Parse(txtinta.Text) + int.Parse(txtintb.Text);

            txtketqua.Text = tong.ToString();
        }

        private void radtru_CheckedChanged(object sender, EventArgs e)
        {
            int tru;

            tru = int.Parse(txtinta.Text) - int.Parse(txtintb.Text);

            txtketqua.Text = tru.ToString();
        }

        private void radnhan_CheckedChanged(object sender, EventArgs e)
        {
            int nhan;
            nhan = int.Parse(txtinta.Text) * int.Parse(txtintb.Text);

            txtketqua.Text = nhan.ToString();
        }

        private void radchia_CheckedChanged(object sender, EventArgs e)
        {
            int chia;

            chia = int.Parse(txtinta.Text) / int.Parse(txtintb.Text);

            txtketqua.Text = chia.ToString();
        }
    }
}
