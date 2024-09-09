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
    public partial class Frm_BaoCao : Form
    {
        public Frm_BaoCao()
        {
            InitializeComponent();
        }

        private void btn_InBaoCao_Click(object sender, EventArgs e)
        {
            if (cmbLoaiThongKe.Text == "")
            {
                MessageBox.Show("Loại thống kê không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbLoaiThongKe.Focus();
                return;
            }

          

            if (cmbLoaiThongKe.Text == "Thống kê kết quả")
            {
                Report_KetQua rpt = new Report_KetQua();
                ReportDangKyHoc.ReportSource = rpt;

                // rpt.SetDatabaseLogon("sa", "sa123", "PC101", "QL_HocVien");

                ReportDangKyHoc.Refresh();
                ReportDangKyHoc.DisplayToolbar = false;
                ReportDangKyHoc.DisplayStatusBar = false;
            }
        }

     
    }
}
