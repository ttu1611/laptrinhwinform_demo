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
    public partial class Bai11 : Form
    {
        public Bai11()
        {
            InitializeComponent();
        }

        private void Bai11_Load(object sender, EventArgs e)
        {
            rad1.Checked = true;
            chklstbox.Items.Add("Thiết kế web");
            chklstbox.Items.Add("Cơ sở dữ liệu");
            chklstbox.Items.Add("Mạng máy tính");
            chklstbox.Items.Add("Triết học Mác-Lênin");
            chklstbox.Items.Add("Giải tích");

            cmblop.Items.Add("12424TN");
            cmblop.Items.Add("124241");
            cmblop.Items.Add("Vuýp");


            cmbnienkhoa.Items.Add("2020");
            cmbnienkhoa.Items.Add("2021");
            cmbnienkhoa.Items.Add("2022");
            cmbnienkhoa.Items.Add("2023");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btndangki_Click(object sender, EventArgs e)
        {
            string hocki = "";
            if (rad1.Checked)
            {
                hocki = "1";
            }
            else if (rad2.Checked)
            {
                hocki = "2";
            }
            else if (rad3.Checked)
            {
                hocki = "3";
            }
            else if (rad4.Checked)
            {
                hocki = "4";
            }

            string monhoc = "";
            for (int i = 0; i < chklstbox.Items.Count; i++)
            {
                if (chklstbox.GetItemChecked(i))
                {
                    monhoc += chklstbox.Items[i].ToString() + " ";
                }
            }

            MessageBox.Show(text: "Mã Sinh Viên" + txtmssv.Text + "Sinh viên :" + txthovaten.Text + "\n" + "Lớp :" + cmblop.Text + "\n" + "Niên khóa :" + cmbnienkhoa.Text + "\n" + "Học kì :" + hocki + "\n" + monhoc);
        }
    }
}
