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
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void Bai6_Load(object sender, EventArgs e)
        {

        }

        private void radtimenewroman_CheckedChanged(object sender, EventArgs e)
        {
            txtinput.Font = new Font(radtimenewroman.Font.Name, radtimenewroman.Font.Size, radtimenewroman.Font.Style ^ FontStyle.Regular);
        }

        private void radarial_CheckedChanged(object sender, EventArgs e)
        {
            txtinput.Font = new Font(radarial.Font.Name, radarial.Font.Size, radarial.Font.Style ^ FontStyle.Regular);
        }

        private void radtahoma_CheckedChanged(object sender, EventArgs e)
        {
            txtinput.Font = new Font(radtahoma.Font.Name, radtahoma.Font.Size, radtahoma.Font.Style ^ FontStyle.Regular);
        }

        private void radcouriernew_CheckedChanged(object sender, EventArgs e)
        {
            txtinput.Font = new Font(radcouriernew.Font.Name, radcouriernew.Font.Size, radcouriernew.Font.Style ^ FontStyle.Regular);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
