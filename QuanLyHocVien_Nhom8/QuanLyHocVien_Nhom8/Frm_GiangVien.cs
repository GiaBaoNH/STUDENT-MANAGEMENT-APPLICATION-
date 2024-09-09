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
    public partial class Frm_GiangVien : Form
    {
        DBConnect DB = new DBConnect();
        public Frm_GiangVien()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dgvGiangVien.ColumnHeadersVisible = true;
            dgvGiangVien.ColumnHeadersHeight = 30;
            dgvGiangVien.ReadOnly = true;

            string query = "SELECT * FROM GIANGVIEN";
            dgvGiangVien.DataSource = DB.getDatatable(query);
            dgvGiangVien.Columns[0].HeaderText = "Mã giảng viên";
            dgvGiangVien.Columns[1].HeaderText = "Tên giảng viên";
            dgvGiangVien.Columns[2].HeaderText = "Ngày sinh";
            dgvGiangVien.Columns[3].HeaderText = "Giới tính";
            dgvGiangVien.Columns[4].HeaderText = "Email";
            dgvGiangVien.Columns[5].HeaderText = "Số điện thoại";
        }
     
        private void Frm_GiangVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGiangVienID.Text))
            {
                MessageBox.Show("Mã giảng viên không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGiangVienID.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtHoTenGV.Text))
            {
                MessageBox.Show("Tên giảng viên không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTenGV.Focus();
                return;
            }

            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            string query = "INSERT INTO GIANGVIEN (GiangVienID, TenGiangVien, NgaySinh, GioiTinh, Email, SoDienThoai) VALUES (@GiangVienID, @TenGiangVien, @NgaySinh, @GioiTinh, @Email, @SoDienThoai)";

            var parameters = new Dictionary<string, object>
            {
                { "@GiangVienID", txtGiangVienID.Text },
                { "@TenGiangVien", txtHoTenGV.Text },
                { "@NgaySinh", dtPickerNgaySinh.Value.ToString("yyyy-MM-dd") },
                { "@GioiTinh", gioiTinh },
                { "@Email", txtEmailGV.Text },
                { "@SoDienThoai", txtSoDienThoaiGV.Text }
            };

            try
            {
                int rowsAffected = DB.getNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm giảng viên thành công!");
                    LoadData(); // Reload data after successful addition
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi!");
                return;
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dgvGiangVien.Rows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa giảng viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string GiangVienID = dgvGiangVien.Rows[dgvGiangVien.CurrentCell.RowIndex].Cells[0].Value.ToString();

                string query = "DELETE FROM GIANGVIEN WHERE GiangVienID = @GiangVienID";
                var parameters = new Dictionary<string, object>
                {
                    { "@GiangVienID", GiangVienID }
                };

                try
                {
                    int rowsAffected = DB.getNonQuery(query, parameters);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa giảng viên thành công!");
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
            if (string.IsNullOrEmpty(txtGiangVienID.Text))
            {
                MessageBox.Show("Mã giảng viên không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGiangVienID.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtHoTenGV.Text))
            {
                MessageBox.Show("Tên giảng viên không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTenGV.Focus();
                return;
            }

            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            string GiangVienIDold = dgvGiangVien.Rows[dgvGiangVien.CurrentCell.RowIndex].Cells[0].Value.ToString();

            string query = "UPDATE GIANGVIEN SET GiangVienID = @GiangVienID, TenGiangVien = @TenGiangVien, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, Email = @Email, SoDienThoai = @SoDienThoai WHERE GiangVienID = @GiangVienIDold";

            var parameters = new Dictionary<string, object>
            {
                { "@GiangVienID", txtGiangVienID.Text },
                { "@TenGiangVien", txtHoTenGV.Text },
                { "@NgaySinh", dtPickerNgaySinh.Value.ToString("yyyy-MM-dd") },
                { "@GioiTinh", gioiTinh },
                { "@Email", txtEmailGV.Text },
                { "@SoDienThoai", txtSoDienThoaiGV.Text },
                { "@GiangVienIDold", GiangVienIDold }
            };

            try
            {
                int rowsAffected = DB.getNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sửa thông tin giảng viên thành công!");
                    LoadData(); // Reload data after successful modification
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi!");
                return;
            }
        }

        private void dgvGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvGiangVien.Rows[e.RowIndex];
            txtGiangVienID.Text = row.Cells[0].Value.ToString();
            txtHoTenGV.Text = row.Cells[1].Value.ToString();
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

            txtEmailGV.Text = row.Cells[4].Value.ToString();
            txtSoDienThoaiGV.Text = row.Cells[5].Value.ToString();
        }

        private void txtHoTenGV_KeyPress(object sender, KeyPressEventArgs e)
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
