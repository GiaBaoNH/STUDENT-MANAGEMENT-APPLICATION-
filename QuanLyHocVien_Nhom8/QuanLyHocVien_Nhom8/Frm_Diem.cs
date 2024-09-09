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
    public partial class Frm_Diem : Form
    {
        DBConnect DB = new DBConnect();
        public Frm_Diem()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dgvDiem.ColumnHeadersVisible = true;
            dgvDiem.ColumnHeadersHeight = 30;
            dgvDiem.ReadOnly = true;
            dgvDiem.AllowUserToAddRows = false;
            string query = "SELECT a.DiemID, a.HocVienID, b.HoTen, a.MonHocID, c.TenMonHoc, a.Diem " +
                            "FROM DIEM a " +
                            "INNER JOIN HOCVIEN b ON a.HocVienID = b.HocVienID " +
                            "INNER JOIN MONHOC c ON a.MonHocID = c.MonHocID";
            dgvDiem.DataSource = DB.getDatatable(query);
            dgvDiem.Columns[0].HeaderText = "";
            dgvDiem.Columns[1].HeaderText = "Mã học viên";
            dgvDiem.Columns[2].HeaderText = "Tên học viên";
            dgvDiem.Columns[3].HeaderText = "Mã môn học";
            dgvDiem.Columns[4].HeaderText = "Tên môn học";
            dgvDiem.Columns[5].HeaderText = "Điểm";
        }
        private void DanhSachHocVien()
        {
            string query = "SELECT * FROM HOCVIEN";
            DataTable dt = DB.getDatatable(query);
            cboHocVienID.DataSource = dt;
            cboHocVienID.DisplayMember = "HoTen";
            cboHocVienID.ValueMember = "HocVienID";
        }
        private void DanhSachMonHoc()
        {
            string query = "SELECT * FROM MONHOC";
            DataTable dt = DB.getDatatable(query);
            cboMonHocID.DataSource = dt;
            cboMonHocID.DisplayMember = "TenMonHoc";
            cboMonHocID.ValueMember = "MonHocID";
        }
        //chỉ cho nhập số nguyên và số thập phân
        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                // Cho phép nhập số, dấu chấm và ký tự điều khiển
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; // Hủy bỏ ký tự không hợp lệ
                    MessageBox.Show("Hãy nhập đúng định dạng của số.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                // Đảm bảo chỉ có một dấu chấm
                else if (e.KeyChar == '.' && textBox.Text.Contains("."))
                {
                    e.Handled = true; // Hủy bỏ dấu chấm thứ hai
                    MessageBox.Show("Hãy nhập đúng định dạng của số.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnCapNhatDiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboMonHocID.Text))
            {
                MessageBox.Show("Mã môn học không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMonHocID.Focus();
                return;
            }

            if (string.IsNullOrEmpty(cboHocVienID.Text))
            {
                MessageBox.Show("Mã sinh viên không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboHocVienID.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDiem.Text))
            {
                MessageBox.Show("Điểm không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiem.Focus();
                return;
            }
            //kiểm tra điểm tồn tại
            string checkQuery = "SELECT COUNT(*) FROM DIEM WHERE HocVienID = @HocVienID AND MonHocID = @MonHocID";
            var checkParams = new Dictionary<string, object>
            {
                { "@HocVienID", cboHocVienID.SelectedValue },
                { "@MonHocID", cboMonHocID.SelectedValue }
            };

            int count = (int)DB.getScalar(checkQuery, checkParams);

            if (count > 0)
            {
                MessageBox.Show("Điểm của học viên này đã được nhập, hãy chỉnh sửa");
                return;
            }

            string insertQuery = "INSERT INTO DIEM (HocVienID, MonHocID, Diem) VALUES (@HocVienID, @MonHocID, @Diem)";
            var insertParams = new Dictionary<string, object>
            {
                { "@HocVienID", cboHocVienID.SelectedValue },
                { "@MonHocID", cboMonHocID.SelectedValue },
                { "@Diem", txtDiem.Text }
            };

            try
            {
                int rowsAffected = DB.getNonQuery(insertQuery, insertParams);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Nhập điểm thành công!");
                    LoadData(); // Reload data after successful addition
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
        private void btnSuaDiem_Click(object sender, EventArgs e)
        {
            if (dgvDiem.Rows.Count == 0) return;

            if (string.IsNullOrEmpty(cboMonHocID.Text))
            {
                MessageBox.Show("Mã môn học không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMonHocID.Focus();
                return;
            }

            if (string.IsNullOrEmpty(cboHocVienID.Text))
            {
                MessageBox.Show("Mã học viên không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboHocVienID.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDiem.Text))
            {
                MessageBox.Show("Điểm không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiem.Focus();
                return;
            }

            string diemIDold = dgvDiem.Rows[dgvDiem.CurrentCell.RowIndex].Cells[0].Value.ToString();

            string updateQuery = "UPDATE DIEM SET HocVienID = @HocVienID, MonHocID = @MonHocID, Diem = @Diem WHERE DiemID = @DiemID";
            var updateParams = new Dictionary<string, object>
            {
                { "@HocVienID", cboHocVienID.SelectedValue },
                { "@MonHocID", cboMonHocID.SelectedValue },
                { "@Diem", txtDiem.Text },
                { "@DiemID", diemIDold }
            };

            try
            {
                int rowsAffected = DB.getNonQuery(updateQuery, updateParams);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sửa thông tin điểm thành công!");
                    LoadData(); // Reload data after successful modification
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DanhSachMonHoc();
                DanhSachHocVien();
                DataGridViewRow row = this.dgvDiem.Rows[e.RowIndex];
                cboHocVienID.SelectedValue = row.Cells[1].Value.ToString();
                cboMonHocID.SelectedValue = row.Cells[3].Value.ToString();
                txtDiem.Text = row.Cells[5].Value.ToString();
            }
        }

        private void Frm_Diem_Load(object sender, EventArgs e)
        {
            DanhSachHocVien();
            DanhSachMonHoc();
            LoadData();
        }

       
    }
}
