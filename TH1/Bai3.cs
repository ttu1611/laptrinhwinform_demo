using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace baiTH13
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            cbbSo.Items.Add(txtnhapso.Text);
            txtnhapso.Text = "";
            txtnhapso.Focus();
        }

        private void cbbSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstuocso.Items.Clear();

            int n = Convert.ToInt32(cbbSo.SelectedItem);

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    lstuocso.Items.Add(i);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtnhapso.Focus();
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach (int i in lstuocso.Items)
            {
                tong += i;
            }
            MessageBox.Show("Tổng các ước là :" + tong, "Kết quả", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void btnsoluongcacuocchan_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (int i in lstuocso.Items)
            {
                if (i % 2 == 0)
                {
                    dem++;
                }
            }
            MessageBox.Show("Sô lượng ước chẵn :" + dem, "Kết quả", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
        private bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        private void btnsoluonguocnguyento_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (int x in lstuocso.Items)
                if (IsPrime(x))
                    dem++;
            MessageBox.Show("Số lượng số nguyên tố :" + dem, "Kết quả", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
    }
}
