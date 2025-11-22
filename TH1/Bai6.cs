using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baiTH16
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void radtimenewroman_CheckedChanged(object sender, EventArgs e)
        {
            if (radtimenewroman.Checked)
            {
                txtinput.Font = new Font(radtimenewroman.Font.Name, radtimenewroman.Font.Size, radtimenewroman.Font.Style^FontStyle.Regular);
            }
        }

        private void radarial_CheckedChanged(object sender, EventArgs e)
        {
            txtinput.Font = new Font(radarial.Font.Name, radarial.Font.Size, radarial.Font.Style ^ FontStyle.Regular);
        }

        private void radrahoma_CheckedChanged(object sender, EventArgs e)
        {
            txtinput.Font = new Font(radtahoma.Font.Name, radtahoma.Font.Size, radtahoma.Font.Style ^ FontStyle.Regular);
        }
    }
}
