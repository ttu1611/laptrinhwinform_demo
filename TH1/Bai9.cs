using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baiTH19
{
    public partial class Bai9 : Form
    {
        public Bai9()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = lstchienpa.Items.Count;
            lstchienpa.Items[0] = "";
            lstchienpa.Items[n - 1] = ""; 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = lstchienpa.Items.Count - 1; i >= 0; i--)
            {
                int value = Convert.ToInt32(lstchienpa.Items[i]);
                if (value % 2 == 0)
                {
                    lstchienpa.Items.RemoveAt(i);
                }
            }
        }

        private void btnketthuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thoát nhé !!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btntong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            for (int i = 0; i < lstchienpa.Items.Count; i++)
            {
                
                if (int.TryParse(lstchienpa.Items[i].ToString(), out int value))
                {
                    tong += value;
                }
            }
            MessageBox.Show("Tổng là : " + tong);
        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            lstchienpa.Items.Add(txtinput.Text);
            txtinput.Text = "";
        }

        private void btnxoadangchon_Click(object sender, EventArgs e)
        {            
            for (int i = 0; i < lstchienpa.SelectedIndex; i++)
            {
                lstchienpa.Items.RemoveAt(lstchienpa.SelectedIndices[i]);
            }
        }

        private void btntang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstchienpa.Items.Count;i++)
            {
                int value = Convert.ToInt32(lstchienpa.Items[i]) + 2;
                lstchienpa.Items[i] = value;
            }
        }

        private void btnbinhphuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstchienpa.Items.Count; i++)
            {
                int value = Convert.ToInt32(lstchienpa.Items[i]) * Convert.ToInt32(lstchienpa.Items[i]);
                lstchienpa.Items[i] = value;
            }
        }

        private void btnchan_Click(object sender, EventArgs e)
        {
            for (int i = lstchienpa.Items.Count - 1; i >= 0; i--)
            {
                int value = Convert.ToInt32(lstchienpa.Items[i]);
                if (value % 2 != 0)
                {
                    lstchienpa.Items.RemoveAt(i);
                }
            }

        }
    }
}
