using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baiTH18
{
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtgiai_Click(object sender, EventArgs e)
        {
            int value;
            if (string.IsNullOrEmpty(txtinta.Text) || !int.TryParse(txtinta.Text, out value) || value <= 0)
            {
                errorProvider1.SetError(txtinta, "Vui lòng nhập một số nguyên dương.");
            }
            else
            {
                errorProvider1.SetError(txtinta, "");
            }
            if (string.IsNullOrEmpty(txtintb.Text))
            {
                errorProvider1.SetError(txtintb, "Số B không thể rỗng");
            }

            int x;
            x = int.Parse(txtintb.Text) / int.Parse(txtinta.Text);
            txtnghiem.Text = x.ToString();    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtinta.Text = "";
            txtintb.Text = "";
            txtnghiem.Text = "";
        }
    }
}
