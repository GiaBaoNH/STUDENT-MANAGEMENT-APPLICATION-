using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace QuanLyHocVien_Nhom8
{
    public partial class Frm_Home : Form
    {
        private SoundPlayer choiNhac;
        public Frm_Home()
        {
            InitializeComponent();
            choiNhac = new SoundPlayer(@"D:\Picture\NhacDuiDeNe.wav");
        }

        private void Frm_Home_Load(object sender, EventArgs e)
        {

        }

        private void ckb_Nhac_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Nhac.Checked == true)
                choiNhac.Play();
            else
                choiNhac.Stop();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
