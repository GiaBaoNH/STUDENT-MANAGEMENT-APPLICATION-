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
    public partial class Frm_HocVien : Form
    {
        DBConnect DB = new DBConnect();
        public Frm_HocVien()
        {
            InitializeComponent();
        }


        private void LoadData()
        {
            dgvHocVien.ColumnHeadersVisible = true;
            dgvHocVien.ColumnHeadersHeight = 30;
            dgvHocVien.ReadOnly = true;

            string query = "SELECT * FROM HOCVIEN";
            dgvHocVien.DataSource = DB.getDatatable(query);
            dgvHocVien.Columns[0].HeaderText = "Mã học viên";
            dgvHocVien.Columns[1].HeaderText = "Tên học viên";
            dgvHocVien.Columns[2].HeaderText = "Ngày sinh";
            dgvHocVien.Columns[3].HeaderText = "Giới tính";
            dgvHocVien.Columns[4].HeaderText = "Lớp";
            dgvHocVien.Columns[5].HeaderText = "Email";
            dgvHocVien.Columns[6].HeaderText = "Số điện thoại";
        }
        private void DanhSachLop()
        {
            string query = "SELECT * FROM HOCVIEN";
            DataTable dt = DB.getDatatable(query);
            cmbLop.DataSource = dt;
            cmbLop.DisplayMember = "lop";
            cmbLop.ValueMember = "lop";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHocVienID.Text))
            {
                MessageBox.Show("Mã học viên không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHocVienID.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Tên học viên không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return;
            }

            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            string query = "INSERT INTO HOCVIEN (HocVienID, TenHocVien, NgaySinh, GioiTinh, Lop, Email, SoDienThoai) VALUES (@HocVienID, @TenHocVien, @NgaySinh, @GioiTinh, @Lop, @Email, @SoDienThoai)";

            var parameters = new Dictionary<string, object>
            {
                { "@HocVienID", txtHocVienID.Text },
                { "@TenHocVien", txtHoTen.Text },
                { "@NgaySinh", dtPickerNgaySinh.Value.ToString("yyyy-MM-dd") },
                { "@GioiTinh", gioiTinh },
                { "@Lop", cmbLop.SelectedValue.ToString() },
                { "@Email", txtEmail.Text },
                { "@SoDienThoai", txtSoDienThoai.Text }
            };

            try
            {
                int rowsAffected = DB.getNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm học viên thành công!");
                    LoadData(); // Reload data after successful addition
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi!");
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHocVien.Rows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa học viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string HocVienID = dgvHocVien.Rows[dgvHocVien.CurrentCell.RowIndex].Cells[0].Value.ToString();

                string query = "DELETE FROM HOCVIEN WHERE HocVienID = @HocVienID";
                var parameters = new Dictionary<string, object>
                {
                    { "@HocVienID", HocVienID }
                };

                try
                {
                    int rowsAffected = DB.getNonQuery(query, parameters);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa học viên thành công!");
                        LoadData(); // Reload data after successful deletion
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã có lỗi!");
                    return;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHocVienID.Text))
            {
                MessageBox.Show("Mã học viên không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHocVienID.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Tên học viên không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return;
            }

            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            string HocVienIDold = dgvHocVien.Rows[dgvHocVien.CurrentCell.RowIndex].Cells[0].Value.ToString();

            string query = "UPDATE HOCVIEN SET HocVienID = @HocVienID, TenHocVien = @TenHocVien, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, Lop = @Lop, Email = @Email, SoDienThoai = @SoDienThoai WHERE HocVienID = @HocVienIDold";

            var parameters = new Dictionary<string, object>
            {
                { "@HocVienID", txtHocVienID.Text },
                { "@TenHocVien", txtHoTen.Text },
                { "@NgaySinh", dtPickerNgaySinh.Value.ToString("yyyy-MM-dd") },
                { "@GioiTinh", gioiTinh },
                { "@Lop", cmbLop.SelectedValue.ToString() },
                { "@Email", txtEmail.Text },
                { "@SoDienThoai", txtSoDienThoai.Text },
                { "@HocVienIDold", HocVienIDold }
            };

            try
            {
                int rowsAffected = DB.getNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sửa thông tin học viên thành công!");
                    LoadData(); // Reload data after successful modification
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi!");
                return;
            }
        }
    

        private void dgvHocVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DanhSachLop();
                DataGridViewRow row = this.dgvHocVien.Rows[e.RowIndex];
                txtHocVienID.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                dtPickerNgaySinh.Text = row.Cells[2].Value.ToString();
                string gioiTinh = row.Cells[3].Value.ToString();
                if (gioiTinh == "Nam")
                {
                    radNam.Checked = true;
                }
                else if (gioiTinh == "Nữ")
                {
                    radNu.Checked = true;
                }
                cmbLop.SelectedValue = row.Cells[4].Value.ToString();
                txtEmail.Text = row.Cells[5].Value.ToString();
                txtSoDienThoai.Text = row.Cells[6].Value.ToString();
               
            }
        }
        private void Frm_HocVien_Load(object sender, EventArgs e)
        {
            DanhSachLop();
            LoadData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Hãy nhập tên hợp lệ.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
