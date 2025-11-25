using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH1
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void Bai7_Load(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            int tuoi;
            int year;
            bool hasError = false;

            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtyourname.Text))
            {
                errorProvider1.SetError(txtyourname, "Your Name không thể rỗng");
                hasError = true;
            }

            if (!int.TryParse(txtyearofbirth.Text, out year))
            {
                errorProvider1.SetError(txtyearofbirth, "Năm sinh phải là một số nguyên hợp lệ.");
                hasError = true;
            }
            else if (year < 1900 || year > DateTime.Now.Year)
            {
                errorProvider1.SetError(txtyearofbirth, "Năm không thể bé hơn 1900 / Không thể lớn hơn năm hiện tại");
                hasError = true;
            }

            if (hasError)
            {
                return;
            }

            tuoi = DateTime.Now.Year - year;

            MessageBox.Show("Tên là : " + txtyourname.Text + "\n" + "Tuổi : " + tuoi, "Thông tin của bạn là ");
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtyourname.Text = "";
            txtyearofbirth.Text = "";
            txtyourname.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
