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
    public partial class Bai9 : Form
    {
        public Bai9()
        {
            InitializeComponent();
        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            lstpt.Items.Add(txtinput.Text);
            txtinput.Text = "";
        }

        private void btntong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            for (int i = 0; i < lstpt.Items.Count; i++)
            {

                if (int.TryParse(lstpt.Items[i].ToString(), out int value))
                {
                    tong += value;
                }
            }
            MessageBox.Show("Tổng là : " + tong);
        }

        private void btnxoadaucuoi_Click(object sender, EventArgs e)
        {
            int n = lstpt.Items.Count;
            lstpt.Items[0] = "";
            lstpt.Items[n - 1] = "";
        }

        private void btnxoadangchon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstpt.SelectedIndex; i++)
            {
                lstpt.Items.RemoveAt(lstpt.SelectedIndices[i]);
            }
        }

        private void btntang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstpt.Items.Count; i++)
            {
                int value = Convert.ToInt32(lstpt.Items[i]) + 2;
                lstpt.Items[i] = value;
            }
        }

        private void btnbinhphuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstpt.Items.Count; i++)
            {
                int value = Convert.ToInt32(lstpt.Items[i]) * Convert.ToInt32(lstpt.Items[i]);
                lstpt.Items[i] = value;
            }
        }

        private void btnchan_Click(object sender, EventArgs e)
        {
            lstpt.ClearSelected();
            for (int i = 0; i < lstpt.Items.Count; i++)
            {
                int value = Convert.ToInt32(lstpt.Items[i]);
                if (value % 2 == 0)
                {
                    lstpt.SetSelected(i, true);
                }
            }
        }

        private void btnchonsole_Click(object sender, EventArgs e)
        {
            lstpt.ClearSelected();
            for (int i = 0; i < lstpt.Items.Count; i++)
            {
                int value = Convert.ToInt32(lstpt.Items[i]);
                if (value % 2 != 0)
                {
                    lstpt.SetSelected(i, true);
                }
            }
        }

        private void btnketthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
