using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocVien_Nhom8
{
    public partial class Frm_TrangChu_User : Form
    {
        public Frm_TrangChu_User()
        {
            InitializeComponent();
        }

        private void Frm_TrangChu_User_Load(object sender, EventArgs e)
        {
            ShadowForm1.SetShadowForm(this);
        }
        private void container(object _form)
        {

            if (Panel_container.Controls.Count > 0) Panel_container.Controls.Clear();

            Form frm = _form as Form;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            Panel_container.Controls.Add(frm);
            Panel_container.Tag = frm;
            frm.Show();

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "TRANG CHỦ";
            container(new Frm_Home());
        }

        private void btnQL_SinhVien_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "QUẢN LÝ HỌC VIÊN";
            container(new Frm_HocVien());
        }

        private void btnQL_Diem_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "QUẢN LÝ ĐIỂM";
            container(new Frm_Diem());
        }

        private void btn_BaoCao_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "BÁO CÁO";
            container(new Frm_BaoCao());
        }

        private void btnDangXuatU_Click(object sender, EventArgs e)
        {
            Frm_DangNhap homeForm = new Frm_DangNhap();
            homeForm.FormClosed += (s, args) => this.Show();
            homeForm.Show();
        }

        private void ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
