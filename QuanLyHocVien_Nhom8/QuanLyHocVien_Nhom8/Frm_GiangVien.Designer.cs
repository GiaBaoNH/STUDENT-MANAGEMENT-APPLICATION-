
namespace QuanLyHocVien_Nhom8
{
    partial class Frm_GiangVien
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvGiangVien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.txtSoDienThoaiGV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtEmailGV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.radNu = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.radNam = new Guna.UI2.WinForms.Guna2RadioButton();
            this.dtPickerNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtHoTenGV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtGiangVienID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHocVienID = new System.Windows.Forms.Label();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel2.BorderRadius = 10;
            this.Panel2.BorderThickness = 1;
            this.Panel2.Controls.Add(this.dgvGiangVien);
            this.Panel2.Location = new System.Drawing.Point(32, 403);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.ShadowDecoration.Parent = this.Panel2;
            this.Panel2.Size = new System.Drawing.Size(1527, 432);
            this.Panel2.TabIndex = 36;
            // 
            // dgvGiangVien
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvGiangVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGiangVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGiangVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiangVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvGiangVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGiangVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGiangVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGiangVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGiangVien.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGiangVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGiangVien.EnableHeadersVisualStyles = false;
            this.dgvGiangVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGiangVien.Location = new System.Drawing.Point(4, 22);
            this.dgvGiangVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGiangVien.Name = "dgvGiangVien";
            this.dgvGiangVien.ReadOnly = true;
            this.dgvGiangVien.RowHeadersVisible = false;
            this.dgvGiangVien.RowHeadersWidth = 51;
            this.dgvGiangVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiangVien.Size = new System.Drawing.Size(1490, 391);
            this.dgvGiangVien.TabIndex = 27;
            this.dgvGiangVien.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvGiangVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGiangVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvGiangVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvGiangVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvGiangVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvGiangVien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvGiangVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGiangVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvGiangVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGiangVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvGiangVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvGiangVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvGiangVien.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvGiangVien.ThemeStyle.ReadOnly = true;
            this.dgvGiangVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGiangVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGiangVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvGiangVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvGiangVien.ThemeStyle.RowsStyle.Height = 22;
            this.dgvGiangVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGiangVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvGiangVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiangVien_CellClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyHocVien_Nhom8.Properties.Resources.Screenshot_2023_11_21_220656;
            this.pictureBox2.Location = new System.Drawing.Point(568, 299);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyHocVien_Nhom8.Properties.Resources.Screenshot_2023_11_21_220551;
            this.pictureBox1.Location = new System.Drawing.Point(202, 299);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // Panel3
            // 
            this.Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel3.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel3.BorderRadius = 10;
            this.Panel3.BorderThickness = 1;
            this.Panel3.Controls.Add(this.pictureBox3);
            this.Panel3.Controls.Add(this.pictureBox2);
            this.Panel3.Controls.Add(this.pictureBox1);
            this.Panel3.Controls.Add(this.btnXoa);
            this.Panel3.Controls.Add(this.btnSua);
            this.Panel3.Controls.Add(this.btnThem);
            this.Panel3.Controls.Add(this.txtSoDienThoaiGV);
            this.Panel3.Controls.Add(this.lblSoDienThoai);
            this.Panel3.Controls.Add(this.txtEmailGV);
            this.Panel3.Controls.Add(this.lblEmail);
            this.Panel3.Controls.Add(this.radNu);
            this.Panel3.Controls.Add(this.lblGioiTinh);
            this.Panel3.Controls.Add(this.radNam);
            this.Panel3.Controls.Add(this.dtPickerNgaySinh);
            this.Panel3.Controls.Add(this.lblNgaySinh);
            this.Panel3.Controls.Add(this.txtHoTenGV);
            this.Panel3.Controls.Add(this.lblHoTen);
            this.Panel3.Controls.Add(this.txtGiangVienID);
            this.Panel3.Controls.Add(this.lblHocVienID);
            this.Panel3.Location = new System.Drawing.Point(32, 29);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4);
            this.Panel3.Name = "Panel3";
            this.Panel3.ShadowDecoration.Parent = this.Panel3;
            this.Panel3.Size = new System.Drawing.Size(1527, 355);
            this.Panel3.TabIndex = 35;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QuanLyHocVien_Nhom8.Properties.Resources.Screenshot_2023_11_21_220635;
            this.pictureBox3.Location = new System.Drawing.Point(962, 300);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 47;
            this.pictureBox3.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 10;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.Firebrick;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Location = new System.Drawing.Point(462, 295);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(179, 53);
            this.btnXoa.TabIndex = 44;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BorderRadius = 10;
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Location = new System.Drawing.Point(856, 295);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(179, 53);
            this.btnSua.TabIndex = 42;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 10;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(94)))), ((int)(((byte)(121)))));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Location = new System.Drawing.Point(99, 295);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(179, 53);
            this.btnThem.TabIndex = 41;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // txtSoDienThoaiGV
            // 
            this.txtSoDienThoaiGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoDienThoaiGV.Animated = true;
            this.txtSoDienThoaiGV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSoDienThoaiGV.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtSoDienThoaiGV.BorderRadius = 5;
            this.txtSoDienThoaiGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDienThoaiGV.DefaultText = "";
            this.txtSoDienThoaiGV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoDienThoaiGV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoDienThoaiGV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoaiGV.DisabledState.Parent = this.txtSoDienThoaiGV;
            this.txtSoDienThoaiGV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoaiGV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoaiGV.FocusedState.Parent = this.txtSoDienThoaiGV;
            this.txtSoDienThoaiGV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoaiGV.ForeColor = System.Drawing.Color.Black;
            this.txtSoDienThoaiGV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoaiGV.HoverState.Parent = this.txtSoDienThoaiGV;
            this.txtSoDienThoaiGV.Location = new System.Drawing.Point(938, 228);
            this.txtSoDienThoaiGV.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSoDienThoaiGV.Name = "txtSoDienThoaiGV";
            this.txtSoDienThoaiGV.PasswordChar = '\0';
            this.txtSoDienThoaiGV.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSoDienThoaiGV.PlaceholderText = "Số điện thoại";
            this.txtSoDienThoaiGV.SelectedText = "";
            this.txtSoDienThoaiGV.ShadowDecoration.Parent = this.txtSoDienThoaiGV;
            this.txtSoDienThoaiGV.Size = new System.Drawing.Size(357, 44);
            this.txtSoDienThoaiGV.TabIndex = 39;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoai.Location = new System.Drawing.Point(938, 203);
            this.lblSoDienThoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(108, 21);
            this.lblSoDienThoai.TabIndex = 37;
            this.lblSoDienThoai.Text = "Số điện thoại";
            // 
            // txtEmailGV
            // 
            this.txtEmailGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailGV.Animated = true;
            this.txtEmailGV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmailGV.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtEmailGV.BorderRadius = 5;
            this.txtEmailGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailGV.DefaultText = "";
            this.txtEmailGV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmailGV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmailGV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailGV.DisabledState.Parent = this.txtEmailGV;
            this.txtEmailGV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailGV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailGV.FocusedState.Parent = this.txtEmailGV;
            this.txtEmailGV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailGV.ForeColor = System.Drawing.Color.Black;
            this.txtEmailGV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailGV.HoverState.Parent = this.txtEmailGV;
            this.txtEmailGV.Location = new System.Drawing.Point(938, 139);
            this.txtEmailGV.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmailGV.Name = "txtEmailGV";
            this.txtEmailGV.PasswordChar = '\0';
            this.txtEmailGV.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtEmailGV.PlaceholderText = "Email";
            this.txtEmailGV.SelectedText = "";
            this.txtEmailGV.ShadowDecoration.Parent = this.txtEmailGV;
            this.txtEmailGV.Size = new System.Drawing.Size(357, 44);
            this.txtEmailGV.TabIndex = 40;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(938, 117);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 21);
            this.lblEmail.TabIndex = 38;
            this.lblEmail.Text = "Email";
            // 
            // radNu
            // 
            this.radNu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radNu.AutoSize = true;
            this.radNu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radNu.CheckedState.BorderThickness = 0;
            this.radNu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radNu.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radNu.CheckedState.InnerOffset = -4;
            this.radNu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.Location = new System.Drawing.Point(1122, 55);
            this.radNu.Margin = new System.Windows.Forms.Padding(4);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(54, 25);
            this.radNu.TabIndex = 11;
            this.radNu.Text = "Nữ";
            this.radNu.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radNu.UncheckedState.BorderThickness = 2;
            this.radNu.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radNu.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(934, 57);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(76, 21);
            this.lblGioiTinh.TabIndex = 10;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // radNam
            // 
            this.radNam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radNam.AutoSize = true;
            this.radNam.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radNam.CheckedState.BorderThickness = 0;
            this.radNam.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radNam.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radNam.CheckedState.InnerOffset = -4;
            this.radNam.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(1043, 55);
            this.radNam.Margin = new System.Windows.Forms.Padding(4);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(66, 25);
            this.radNam.TabIndex = 9;
            this.radNam.Text = "Nam";
            this.radNam.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radNam.UncheckedState.BorderThickness = 2;
            this.radNam.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radNam.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // dtPickerNgaySinh
            // 
            this.dtPickerNgaySinh.BorderColor = System.Drawing.Color.DodgerBlue;
            this.dtPickerNgaySinh.BorderRadius = 5;
            this.dtPickerNgaySinh.BorderThickness = 1;
            this.dtPickerNgaySinh.CheckedState.Parent = this.dtPickerNgaySinh;
            this.dtPickerNgaySinh.FillColor = System.Drawing.Color.White;
            this.dtPickerNgaySinh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerNgaySinh.HoverState.Parent = this.dtPickerNgaySinh;
            this.dtPickerNgaySinh.Location = new System.Drawing.Point(101, 228);
            this.dtPickerNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtPickerNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPickerNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPickerNgaySinh.Name = "dtPickerNgaySinh";
            this.dtPickerNgaySinh.ShadowDecoration.Parent = this.dtPickerNgaySinh;
            this.dtPickerNgaySinh.Size = new System.Drawing.Size(357, 44);
            this.dtPickerNgaySinh.TabIndex = 8;
            this.dtPickerNgaySinh.Value = new System.DateTime(2021, 7, 5, 12, 52, 33, 197);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(101, 203);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(84, 21);
            this.lblNgaySinh.TabIndex = 7;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // txtHoTenGV
            // 
            this.txtHoTenGV.Animated = true;
            this.txtHoTenGV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtHoTenGV.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtHoTenGV.BorderRadius = 5;
            this.txtHoTenGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTenGV.DefaultText = "";
            this.txtHoTenGV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTenGV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTenGV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTenGV.DisabledState.Parent = this.txtHoTenGV;
            this.txtHoTenGV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTenGV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTenGV.FocusedState.Parent = this.txtHoTenGV;
            this.txtHoTenGV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenGV.ForeColor = System.Drawing.Color.Black;
            this.txtHoTenGV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTenGV.HoverState.Parent = this.txtHoTenGV;
            this.txtHoTenGV.Location = new System.Drawing.Point(101, 139);
            this.txtHoTenGV.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtHoTenGV.Name = "txtHoTenGV";
            this.txtHoTenGV.PasswordChar = '\0';
            this.txtHoTenGV.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtHoTenGV.PlaceholderText = "Họ tên";
            this.txtHoTenGV.SelectedText = "";
            this.txtHoTenGV.ShadowDecoration.Parent = this.txtHoTenGV;
            this.txtHoTenGV.Size = new System.Drawing.Size(357, 44);
            this.txtHoTenGV.TabIndex = 6;
            this.txtHoTenGV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTenGV_KeyPress);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(101, 117);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(60, 21);
            this.lblHoTen.TabIndex = 5;
            this.lblHoTen.Text = "Họ tên";
            // 
            // txtGiangVienID
            // 
            this.txtGiangVienID.Animated = true;
            this.txtGiangVienID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGiangVienID.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtGiangVienID.BorderRadius = 5;
            this.txtGiangVienID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiangVienID.DefaultText = "";
            this.txtGiangVienID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiangVienID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiangVienID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiangVienID.DisabledState.Parent = this.txtGiangVienID;
            this.txtGiangVienID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiangVienID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiangVienID.FocusedState.Parent = this.txtGiangVienID;
            this.txtGiangVienID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiangVienID.ForeColor = System.Drawing.Color.Black;
            this.txtGiangVienID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiangVienID.HoverState.Parent = this.txtGiangVienID;
            this.txtGiangVienID.Location = new System.Drawing.Point(101, 57);
            this.txtGiangVienID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtGiangVienID.Name = "txtGiangVienID";
            this.txtGiangVienID.PasswordChar = '\0';
            this.txtGiangVienID.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtGiangVienID.PlaceholderText = "Giảng viên ID";
            this.txtGiangVienID.SelectedText = "";
            this.txtGiangVienID.ShadowDecoration.Parent = this.txtGiangVienID;
            this.txtGiangVienID.Size = new System.Drawing.Size(357, 44);
            this.txtGiangVienID.TabIndex = 4;
            // 
            // lblHocVienID
            // 
            this.lblHocVienID.AutoSize = true;
            this.lblHocVienID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocVienID.Location = new System.Drawing.Point(101, 34);
            this.lblHocVienID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHocVienID.Name = "lblHocVienID";
            this.lblHocVienID.Size = new System.Drawing.Size(113, 21);
            this.lblHocVienID.TabIndex = 3;
            this.lblHocVienID.Text = "Giảng viên ID";
            // 
            // Frm_GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 864);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel3);
            this.Name = "Frm_GiangVien";
            this.Text = "Frm_GiangVien";
            this.Load += new System.EventHandler(this.Frm_GiangVien_Load);
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm1;
        internal Guna.UI2.WinForms.Guna2Panel Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGiangVien;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal Guna.UI2.WinForms.Guna2Panel Panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        internal Guna.UI2.WinForms.Guna2Button btnXoa;
        internal Guna.UI2.WinForms.Guna2Button btnSua;
        internal Guna.UI2.WinForms.Guna2Button btnThem;
        internal Guna.UI2.WinForms.Guna2TextBox txtSoDienThoaiGV;
        internal System.Windows.Forms.Label lblSoDienThoai;
        internal Guna.UI2.WinForms.Guna2TextBox txtEmailGV;
        internal System.Windows.Forms.Label lblEmail;
        internal Guna.UI2.WinForms.Guna2RadioButton radNu;
        internal System.Windows.Forms.Label lblGioiTinh;
        internal Guna.UI2.WinForms.Guna2RadioButton radNam;
        internal Guna.UI2.WinForms.Guna2DateTimePicker dtPickerNgaySinh;
        internal System.Windows.Forms.Label lblNgaySinh;
        internal Guna.UI2.WinForms.Guna2TextBox txtHoTenGV;
        internal System.Windows.Forms.Label lblHoTen;
        internal Guna.UI2.WinForms.Guna2TextBox txtGiangVienID;
        internal System.Windows.Forms.Label lblHocVienID;
    }
}