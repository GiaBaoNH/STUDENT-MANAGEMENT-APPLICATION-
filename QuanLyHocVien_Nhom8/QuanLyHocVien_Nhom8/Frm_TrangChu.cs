using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;

namespace QuanLyHocVien_Nhom8
{
    public partial class Frm_TrangChu : Form
    {
        public Frm_TrangChu()
        {
            InitializeComponent();
        }

        

        private void Frm_TrangChu_Load(object sender, EventArgs e)
        {
            ShadowForm1.SetShadowForm(this);
        }
        private void container(object _form)
        {
            // Xóa tất cả các điều khiển hiện tại trong Panel_container
            if (Panel_container.Controls.Count > 0) Panel_container.Controls.Clear();

            // Chuyển đổi đối tượng vào dạng Form
            Form frm = _form as Form;
            frm.TopLevel = false; // Đặt form không còn là cấp cao nhất
            frm.FormBorderStyle = FormBorderStyle.None; // Loại bỏ đường viền của form
            frm.Dock = DockStyle.Fill; // Kéo dài form để lấp đầy Panel_container
            Panel_container.Controls.Add(frm); // Thêm form vào Panel_container
            Panel_container.Tag = frm; // Lưu form vào thẻ của Panel_container để có thể truy xuất sau
            frm.Show(); // Hiển thị form
        }

        private void btnQL_SinhVien_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "QUẢN LÝ HỌC VIÊN";
            container(new Frm_HocVien());
        }

        private void btnQL_GV_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "QUẢN LÝ GIẢNG VIÊN";
            container(new Frm_GiangVien());
        }

        private void btnQL_MonHoc_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "QUẢN LÝ MÔN HỌC";
            container(new Frm_MonHoc());
        }

        private void btnQL_Diem_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "QUẢN LÝ ĐIỂM";
            container(new Frm_Diem());
        }

 

        private void btnTrangChu_Click_1(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "TRANG CHỦ";
            container(new Frm_Home());
        }

        private void btn_BaoCao_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "BÁO CÁO";
            container(new Frm_BaoCao());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng Frm_DangNhap mới
            Frm_DangNhap loginForm = new Frm_DangNhap();

            // Ẩn form hiện tại (Frm_TrangChu)
            this.Hide();

            // Hiển thị Frm_DangNhap
            loginForm.FormClosed += (s, args) => this.Show(); // Khi Frm_DangNhap đóng, hiện lại Frm_TrangChu
            loginForm.Show();
        }

        
    }
}
