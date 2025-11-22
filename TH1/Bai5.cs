using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baiTH15
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radred_CheckedChanged(object sender, EventArgs e)
        {
            if (radred.Checked)
            {
                lblhienthi.ForeColor = radred.ForeColor;
            }
        }

        private void txtinput_TextChanged(object sender, EventArgs e)
        {
            lblhienthi.Text = txtinput.Text;
        }

        private void radgreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radgreen.Checked)
            {
                lblhienthi.ForeColor = radgreen.ForeColor;
            }
        }

        private void radblue_CheckedChanged(object sender, EventArgs e)
        {
            if (radblue.Checked)
            {
                lblhienthi.ForeColor = radblue.ForeColor;
            }
        }

        private void radblack_CheckedChanged(object sender, EventArgs e)
        {
            if (radblack.Checked)
            {
                lblhienthi.ForeColor = radblack.ForeColor;
            }
        }

        private void chkbold_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbold.Checked)
            {

                lblhienthi.Font = new Font(lblhienthi.Font.Name , lblhienthi.Font.Size , lblhienthi.Font.Style ^ FontStyle.Bold);
                    
                    
               

            }
        }

        private void chkitalic_CheckedChanged(object sender, EventArgs e)
        {
            lblhienthi.Font = new Font(lblhienthi.Font.Name, lblhienthi.Font.Size, lblhienthi.Font.Style ^ FontStyle.Italic);
        }

        private void chkunderline_CheckedChanged(object sender, EventArgs e)
        {
            lblhienthi.Font = new Font(lblhienthi.Font.Name, lblhienthi.Font.Size, lblhienthi.Font.Style ^ FontStyle.Underline);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
