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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void Bai5_Load(object sender, EventArgs e)
        {

        }

        private void txtinput_TextChanged(object sender, EventArgs e)
        {
            lblhienthi.Text = txtinput.Text;
        }

        private void radred_CheckedChanged(object sender, EventArgs e)
        {
            lblhienthi.ForeColor = radred.ForeColor;
        }

        private void radgreen_CheckedChanged(object sender, EventArgs e)
        {
            lblhienthi.ForeColor = radgreen.ForeColor;
        }

        private void radblue_CheckedChanged(object sender, EventArgs e)
        {
            lblhienthi.ForeColor = radblue.ForeColor;
        }

        private void radblack_CheckedChanged(object sender, EventArgs e)
        {
            lblhienthi.ForeColor = radblack.ForeColor;
        }

        private void chkbold_CheckedChanged(object sender, EventArgs e)
        {
            lblhienthi.Font = new Font(lblhienthi.Font.Name, lblhienthi.Font.Size, lblhienthi.Font.Style ^ FontStyle.Bold);
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
            this.Close();
        }
    }
}
