
namespace QuanLyHocVien_Nhom8
{
    partial class Frm_BaoCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLoaiThongKe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_InBaoCao = new Guna.UI2.WinForms.Guna2Button();
            this.Control = new Guna.UI2.WinForms.Guna2Panel();
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ReportDangKyHoc = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Panel1.SuspendLayout();
            this.Control.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel1.BorderRadius = 10;
            this.Panel1.BorderThickness = 1;
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.cmbLoaiThongKe);
            this.Panel1.Controls.Add(this.btn_InBaoCao);
            this.Panel1.Location = new System.Drawing.Point(23, 15);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.ShadowDecoration.Parent = this.Panel1;
            this.Panel1.Size = new System.Drawing.Size(1529, 241);
            this.Panel1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Loại thống kê";
            // 
            // cmbLoaiThongKe
            // 
            this.cmbLoaiThongKe.BackColor = System.Drawing.Color.Transparent;
            this.cmbLoaiThongKe.BorderRadius = 20;
            this.cmbLoaiThongKe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLoaiThongKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiThongKe.FocusedColor = System.Drawing.Color.Empty;
            this.cmbLoaiThongKe.FocusedState.Parent = this.cmbLoaiThongKe;
            this.cmbLoaiThongKe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbLoaiThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbLoaiThongKe.FormattingEnabled = true;
            this.cmbLoaiThongKe.HoverState.Parent = this.cmbLoaiThongKe;
            this.cmbLoaiThongKe.ItemHeight = 30;
            this.cmbLoaiThongKe.Items.AddRange(new object[] {
            "",
            "Thống kê kết quả"});
            this.cmbLoaiThongKe.ItemsAppearance.Parent = this.cmbLoaiThongKe;
            this.cmbLoaiThongKe.Location = new System.Drawing.Point(196, 52);
            this.cmbLoaiThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLoaiThongKe.Name = "cmbLoaiThongKe";
            this.cmbLoaiThongKe.ShadowDecoration.Parent = this.cmbLoaiThongKe;
            this.cmbLoaiThongKe.Size = new System.Drawing.Size(359, 36);
            this.cmbLoaiThongKe.TabIndex = 16;
            // 
            // btn_InBaoCao
            // 
            this.btn_InBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_InBaoCao.BorderRadius = 20;
            this.btn_InBaoCao.CheckedState.Parent = this.btn_InBaoCao;
            this.btn_InBaoCao.CustomImages.Parent = this.btn_InBaoCao;
            this.btn_InBaoCao.FillColor = System.Drawing.Color.SkyBlue;
            this.btn_InBaoCao.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InBaoCao.ForeColor = System.Drawing.Color.White;
            this.btn_InBaoCao.HoverState.Parent = this.btn_InBaoCao;
            this.btn_InBaoCao.Image = global::QuanLyHocVien_Nhom8.Properties.Resources.Tải_xuống;
            this.btn_InBaoCao.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_InBaoCao.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_InBaoCao.Location = new System.Drawing.Point(967, 33);
            this.btn_InBaoCao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_InBaoCao.Name = "btn_InBaoCao";
            this.btn_InBaoCao.ShadowDecoration.Parent = this.btn_InBaoCao;
            this.btn_InBaoCao.Size = new System.Drawing.Size(230, 55);
            this.btn_InBaoCao.TabIndex = 15;
            this.btn_InBaoCao.Text = "In Báo Cáo";
            this.btn_InBaoCao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_InBaoCao.Click += new System.EventHandler(this.btn_InBaoCao_Click);
            // 
            // Control
            // 
            this.Control.Controls.Add(this.Panel2);
            this.Control.Controls.Add(this.Panel1);
            this.Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Control.Location = new System.Drawing.Point(0, 0);
            this.Control.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Control.Name = "Control";
            this.Control.ShadowDecoration.Parent = this.Control;
            this.Control.Size = new System.Drawing.Size(1573, 897);
            this.Control.TabIndex = 6;
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel2.BorderRadius = 10;
            this.Panel2.BorderThickness = 1;
            this.Panel2.Controls.Add(this.ReportDangKyHoc);
            this.Panel2.Location = new System.Drawing.Point(23, 288);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.ShadowDecoration.Parent = this.Panel2;
            this.Panel2.Size = new System.Drawing.Size(1529, 594);
            this.Panel2.TabIndex = 30;
            // 
            // ReportDangKyHoc
            // 
            this.ReportDangKyHoc.ActiveViewIndex = -1;
            this.ReportDangKyHoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportDangKyHoc.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportDangKyHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportDangKyHoc.Location = new System.Drawing.Point(0, 0);
            this.ReportDangKyHoc.Name = "ReportDangKyHoc";
            this.ReportDangKyHoc.Size = new System.Drawing.Size(1529, 594);
            this.ReportDangKyHoc.TabIndex = 0;
            // 
            // Frm_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1573, 897);
            this.Controls.Add(this.Control);
            this.Name = "Frm_BaoCao";
            this.Text = "Frm_BaoCao";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Control.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal Guna.UI2.WinForms.Guna2Panel Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLoaiThongKe;
        private Guna.UI2.WinForms.Guna2Button btn_InBaoCao;
        private Guna.UI2.WinForms.Guna2Panel Control;
        internal Guna.UI2.WinForms.Guna2Panel Panel2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportDangKyHoc;
        private System.Windows.Forms.Label label1;
    }
}