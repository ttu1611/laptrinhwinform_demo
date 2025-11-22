using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baiTH17
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            int tuoi;
            int year;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtyourname.Text))
            {
                errorProvider1.SetError(txtyourname, "Your Name không thể rỗng");
            }
            
            if (!int.TryParse(txtyearofbirth.Text, out year) || year < 1900 || year > DateTime.Now.Year)
            {
                errorProvider1.SetError(txtyearofbirth, "Năm không thể bé hơn 1900/ Không thể lớn hơn năm hiện tại");
            }

            tuoi = DateTime.Now.Year - int.Parse(txtyearofbirth.Text);

            MessageBox.Show("Tên là : " + txtyourname.Text + "\t" + "\n" + "Tuổi : " + tuoi, "Thông tin của bạn là ");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close(); ;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtyourname.Text = "";
            txtyearofbirth.Text = "";
            txtyourname.Focus();
        }
    }
}
