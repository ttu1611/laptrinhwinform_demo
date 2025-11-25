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
    public partial class Bai10 : Form
    {
        public Bai10()
        {
            InitializeComponent();
        }

        private void Bai10_Load(object sender, EventArgs e)
        {

        }

        private void btnketthuc_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (lstlopb.SelectedItem != null)
            {
                object selectedItem = lstlopb.SelectedItem;

                lstlopa.Items.Add(selectedItem);

                lstlopb.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục từ Lớp b để chuyển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnsangb_Click(object sender, EventArgs e)
        {
            if (lstlopa.SelectedItem != null)
            {
                object selectedItem = lstlopa.SelectedItem;

                lstlopb.Items.Add(selectedItem);

                lstlopa.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục từ Lớp A để chuyển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lstlopa.SelectedItem != null)
            {
                DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa '{lstlopa.SelectedItem}' khỏi Lớp A?", "Xác nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    lstlopa.Items.Remove(lstlopa.SelectedItem);
                }
            }
            else if (lstlopb.SelectedItem != null)
            {
                DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa '{lstlopb.SelectedItem}' khỏi Lớp B?", "Xác nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    lstlopb.Items.Remove(lstlopb.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục từ Lớp A hoặc Lớp B để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
