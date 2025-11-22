using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baiTH1bai11
{
    public partial class Bai11 : Form
    {
        public Bai11()
        {
            InitializeComponent();
        }

        private void lblmssv_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtmssv.Text = "";
            txthovaten.Text = "";
            cmblop.SelectedIndex = -1;
            cmbnienkhoa.SelectedIndex = -1;
            rad1.Checked = false;
            rad2.Checked = false;
            rad3.Checked = false;
            rad4.Checked = false;
            chklstbox.ClearSelected();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rad1.Checked = true;
            chklstbox.Items.Add("LT Windows");
            chklstbox.Items.Add("Cơ sở dữ liệu");
            chklstbox.Items.Add("Mạng máy tính");
            chklstbox.Items.Add("Lập trình web");
            chklstbox.Items.Add("Lập trình thiết bị di động");

            cmblop.Items.Add("TH01");
            cmblop.Items.Add("TH02");
            cmblop.Items.Add("TH03");
            

            cmbnienkhoa.Items.Add("2007");
            cmbnienkhoa.Items.Add("2008");
            cmbnienkhoa.Items.Add("2009");
            cmbnienkhoa.Items.Add("2010");

            

        }

        private void btndangki_Click(object sender, EventArgs e)
        {
            string hockinhe = "";
            if (rad1.Checked)
            {
                hockinhe = "1";
            }
            else if (rad2.Checked)
            {
                hockinhe = "2";
            }
            else if (rad3.Checked)
            {
                hockinhe = "3";
            }
            else if (rad4.Checked)
            {
                hockinhe = "4";
            }

            string monhoc = "";
            for (int i = 0; i < chklstbox.Items.Count; i++)
            {
                if (chklstbox.GetItemChecked(i))
                {
                    monhoc += chklstbox.Items[i].ToString() + " ";
                }
            }

            MessageBox.Show(text: "Mã Sinh Viên" + txtmssv.Text + "Sinh viên :" + txthovaten.Text + "\n" + "Lớp :" + cmblop.Text + "\n" + "Niên khóa :" + cmbnienkhoa.Text + "\n" + "Học kì :" + hockinhe + "\n" + monhoc);
        }
    }
}
