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
    public partial class Frm_DangNhap : Form
    {
        DBConnect DB = new DBConnect();
        public Frm_DangNhap()
        {
            InitializeComponent();
        }

        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {
            ShadowForm1.SetShadowForm(this);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            // Câu lệnh SQL với các tham số
            string sql = "SELECT Quyen FROM TAIKHOAN WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";

            // Tạo Dictionary để chứa tham số
            var parameters = new Dictionary<string, object>
            {
                { "@TenDangNhap", username },
                { "@MatKhau", password }
            };

            // Sử dụng getScalar với prepared statement
            object result = DB.getScalar(sql, parameters);

            if (result != null)
            {
                this.Hide();

                string role = result.ToString();

                if (role == "Admin")
                {
                    Frm_TrangChu adminForm = new Frm_TrangChu();
                    //adminForm.FormClosed += (s, args) => this.Show();
                    adminForm.Show();
                }
                else if (role == "User")
                {
                    Frm_TrangChu_User homeForm = new Frm_TrangChu_User();
                    //homeForm.FormClosed += (s, args) => this.Show();
                    homeForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
        //Trong TxtUserName_KeyDown và TxtPassword_KeyDown, nếu phím nhấn là Keys.Enter, phương thức btnDangNhap_Click sẽ được gọi để thực hiện hành động đăng nhập.
        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e); // Gọi phương thức đăng nhập khi nhấn Enter
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e); // Gọi phương thức đăng nhập khi nhấn Enter
            }
        }
    }
}
