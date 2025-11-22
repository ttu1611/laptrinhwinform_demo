using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baiTH110
{
    public partial class Bai10 : Form
    {
        public Bai10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0;i < lstlopa.Items.Count;i++)
            {
                lstlopb.Items.Add(lstlopa.SelectedItems[i]);
                lstlopa.Items.RemoveAt(i);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                
                while (lstlopa.SelectedItems.Count > 0)
                {
                    lstlopa.Items.Remove(lstlopa.SelectedItems[0]);
                }
            }
        }

        private void lstlopa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txthovaten.Text == "")
            {
                errorProvider1.SetError(txthovaten, "Vui lòng nhập họ và tên");
            }
            lstlopa.Items.Add(txthovaten.Text);
            txthovaten.Text = "";
        }

        private void btnsanga_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstlopb.Items.Count; i++)
            {
                lstlopa.Items.Add(lstlopb.SelectedItems[i]);
                lstlopb.Items.RemoveAt(i);
            }
        }

        private void btnsangb1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < lstlopa.SelectedItems.Count)
            {
                string value = lstlopa.SelectedItems[i].ToString();
                lstlopb.Items.Add(value);
                lstlopa.Items.Remove(value);

            }
        }

        private void btnsanga1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < lstlopb.SelectedItems.Count)
            {
                string value = lstlopb.SelectedItems[i].ToString();
                lstlopa.Items.Add(value);
                lstlopb.Items.Remove(value);

            }
        }

        private void btnketthuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn kết thúc không?", "Xác nhận kết thúc", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
