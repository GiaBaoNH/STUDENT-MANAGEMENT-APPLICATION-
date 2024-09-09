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
    public partial class Frm_MonHoc : Form
    {
        DBConnect DB = new DBConnect();
        public Frm_MonHoc()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dgvMonHoc.ColumnHeadersVisible = true;
            dgvMonHoc.ColumnHeadersHeight = 30;
            dgvMonHoc.ReadOnly = true;
            //truy vấn tất cả môn học
            string query = "SELECT * FROM MONHOC";
            dgvMonHoc.DataSource = DB.getDatatable(query);
            dgvMonHoc.Columns[0].HeaderText = "Mã môn học";
            dgvMonHoc.Columns[1].HeaderText = "Tên môn học";
            dgvMonHoc.Columns[2].HeaderText = "Học phí";
            dgvMonHoc.Columns[3].HeaderText = "Ngày bắt đầu";
            dgvMonHoc.Columns[4].HeaderText = "Ngày kết thúc";
            dgvMonHoc.Columns[5].HeaderText = "Giảng viên";
        }
        //Tải danh sách giảng viên vào combox
        private void DanhSachGiangVien()
        {
            string query = "SELECT * FROM GIANGVIEN";
            DataTable dt = DB.getDatatable(query);
            cboGiangVienID.DataSource = dt;
            cboGiangVienID.DisplayMember = "HoTen";//Hiển thị giảng viên
            cboGiangVienID.ValueMember = "GiangVienID";//Giá trị lưu trữ
        }
        //Xử lí khi bấm nút thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMonHocID.Text))
            {
                MessageBox.Show("Mã môn học không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonHocID.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTenMonHoc.Text))
            {
                MessageBox.Show("Tên môn học không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenMonHoc.Focus();
                return;
            }

            string query = "INSERT INTO MONHOC (MonHocID, TenMonHoc, HocPhi, NgayBatDau, NgayKetThuc, GiangVienID) VALUES (@MonHocID, @TenMonHoc, @HocPhi, @NgayBatDau, @NgayKetThuc, @GiangVienID)";
            //Tạo một đối tượng Dictionary để lưu trữ các tham số cho câu lệnh sql
            var parameters = new Dictionary<string, object>
            {
                { "@MonHocID", txtMonHocID.Text },
                { "@TenMonHoc", txtTenMonHoc.Text },
                { "@HocPhi", txtHocPhi.Text },
                { "@NgayBatDau", dtNgayBatDau.Value.ToString("yyyy-MM-dd") },
                { "@NgayKetThuc", dtNgayKetThuc.Value.ToString("yyyy-MM-dd") },
                { "@GiangVienID", cboGiangVienID.SelectedValue.ToString() }
            };

            try
            {
                int rowsAffected = DB.getNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm môn học thành công!");
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
            if (dgvMonHoc.Rows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa môn học này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string MonHocID = dgvMonHoc.Rows[dgvMonHoc.CurrentCell.RowIndex].Cells[0].Value.ToString();

                string query = "DELETE FROM MONHOC WHERE MonHocID = @MonHocID";
                var parameters = new Dictionary<string, object>
                {
                    { "@MonHocID", MonHocID }
                };

                try
                {
                    //thực thi truy vấn cập nhật môn học
                    int rowsAffected = DB.getNonQuery(query, parameters);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa môn học thành công!");
                        LoadData(); // Reload data after successful deletion
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại, dữ liệu môn học này đã liên kết khóa ngoại ở bảng khác!");
                    return;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMonHocID.Text))
            {
                MessageBox.Show("Mã môn học không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonHocID.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTenMonHoc.Text))
            {
                MessageBox.Show("Tên môn học không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenMonHoc.Focus();
                return;
            }

            if (dgvMonHoc.Rows.Count == 0) return;
            //Lấy mã cũ để cập nhật
            string MonHocIDold = dgvMonHoc.Rows[dgvMonHoc.CurrentCell.RowIndex].Cells[0].Value.ToString();

            string query = "UPDATE MONHOC SET MonHocID = @MonHocID, TenMonHoc = @TenMonHoc, HocPhi = @HocPhi, NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc, GiangVienID = @GiangVienID WHERE MonHocID = @MonHocIDold";

            var parameters = new Dictionary<string, object>
            {
                { "@MonHocID", txtMonHocID.Text },
                { "@TenMonHoc", txtTenMonHoc.Text },
                { "@HocPhi", txtHocPhi.Text },
                { "@NgayBatDau", dtNgayBatDau.Value.ToString("yyyy-MM-dd") },
                { "@NgayKetThuc", dtNgayKetThuc.Value.ToString("yyyy-MM-dd") },
                { "@GiangVienID", cboGiangVienID.SelectedValue.ToString() },
                { "@MonHocIDold", MonHocIDold }
            };

            try
            {
                int rowsAffected = DB.getNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sửa thông tin môn học thành công!");
                    LoadData(); // Reload data after successful modification
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra!");
                return;
            }
        }

    
        // xử lý sự kiện khi nhấp vào một ô

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DanhSachGiangVien();
                DataGridViewRow row = this.dgvMonHoc.Rows[e.RowIndex];
                txtMonHocID.Text = row.Cells[0].Value.ToString();
                txtTenMonHoc.Text = row.Cells[1].Value.ToString();
                txtHocPhi.Text = row.Cells[2].Value.ToString();
                dtNgayBatDau.Text = row.Cells[3].Value.ToString();
                dtNgayKetThuc.Text = row.Cells[4].Value.ToString();
                cboGiangVienID.SelectedValue = row.Cells[5].Value.ToString();
            }
        }

        private void Frm_MonHoc_Load(object sender, EventArgs e)
        {
            DanhSachGiangVien();
            LoadData();
        }
    }
}
