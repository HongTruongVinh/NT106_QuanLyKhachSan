namespace QuanLyKhachSan
{
    partial class fGuestMgmt
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
            this.pn_NhapTuKhoa = new System.Windows.Forms.Panel();
            this.tb_NhapTuKhoa = new System.Windows.Forms.TextBox();
            this.btn_TiemKiem = new System.Windows.Forms.Button();
            this.btn_CapNhap = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.pn_HoTen = new System.Windows.Forms.Panel();
            this.tb_HoTen = new System.Windows.Forms.TextBox();
            this.lb_HoTen = new System.Windows.Forms.Label();
            this.lb_MaKH = new System.Windows.Forms.Label();
            this.pn_MaKH = new System.Windows.Forms.Panel();
            this.tb_MaKH = new System.Windows.Forms.TextBox();
            this.lb_ID = new System.Windows.Forms.Label();
            this.pn_ID = new System.Windows.Forms.Panel();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lb_SDT = new System.Windows.Forms.Label();
            this.pn_SDT = new System.Windows.Forms.Panel();
            this.tb_SDT = new System.Windows.Forms.TextBox();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.pn_DiaChi = new System.Windows.Forms.Panel();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pn_LoaiKH = new System.Windows.Forms.Panel();
            this.cb_LoaiKH = new System.Windows.Forms.ComboBox();
            this.lb_LoaiKH = new System.Windows.Forms.Label();
            this.lb_TTKH = new System.Windows.Forms.Label();
            this.pn_TTKH = new System.Windows.Forms.Panel();
            this.pn_TimKiem = new System.Windows.Forms.Panel();
            this.btn_TimKiemNangCao = new System.Windows.Forms.Button();
            this.lb_TimKiem = new System.Windows.Forms.Label();
            this.dgv_TTKH = new System.Windows.Forms.DataGridView();
            this.pn_NhapTuKhoa.SuspendLayout();
            this.pn_HoTen.SuspendLayout();
            this.pn_MaKH.SuspendLayout();
            this.pn_ID.SuspendLayout();
            this.pn_SDT.SuspendLayout();
            this.pn_DiaChi.SuspendLayout();
            this.pn_LoaiKH.SuspendLayout();
            this.pn_TTKH.SuspendLayout();
            this.pn_TimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TTKH)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_NhapTuKhoa
            // 
            this.pn_NhapTuKhoa.AutoSize = true;
            this.pn_NhapTuKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_NhapTuKhoa.Controls.Add(this.tb_NhapTuKhoa);
            this.pn_NhapTuKhoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pn_NhapTuKhoa.Location = new System.Drawing.Point(160, 21);
            this.pn_NhapTuKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_NhapTuKhoa.Name = "pn_NhapTuKhoa";
            this.pn_NhapTuKhoa.Padding = new System.Windows.Forms.Padding(11, 15, 11, 15);
            this.pn_NhapTuKhoa.Size = new System.Drawing.Size(213, 49);
            this.pn_NhapTuKhoa.TabIndex = 3;
            // 
            // tb_NhapTuKhoa
            // 
            this.tb_NhapTuKhoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_NhapTuKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_NhapTuKhoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NhapTuKhoa.ForeColor = System.Drawing.Color.DimGray;
            this.tb_NhapTuKhoa.Location = new System.Drawing.Point(11, 15);
            this.tb_NhapTuKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_NhapTuKhoa.Name = "tb_NhapTuKhoa";
            this.tb_NhapTuKhoa.Size = new System.Drawing.Size(189, 20);
            this.tb_NhapTuKhoa.TabIndex = 0;
            this.tb_NhapTuKhoa.Text = "Nhập từ khóa...";
            // 
            // btn_TiemKiem
            // 
            this.btn_TiemKiem.BackColor = System.Drawing.Color.Black;
            this.btn_TiemKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_TiemKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TiemKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TiemKiem.ForeColor = System.Drawing.Color.White;
            this.btn_TiemKiem.Location = new System.Drawing.Point(389, 21);
            this.btn_TiemKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TiemKiem.Name = "btn_TiemKiem";
            this.btn_TiemKiem.Size = new System.Drawing.Size(128, 49);
            this.btn_TiemKiem.TabIndex = 6;
            this.btn_TiemKiem.Text = "Tìm kiếm";
            this.btn_TiemKiem.UseVisualStyleBackColor = false;
            // 
            // btn_CapNhap
            // 
            this.btn_CapNhap.BackColor = System.Drawing.Color.Black;
            this.btn_CapNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_CapNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhap.ForeColor = System.Drawing.Color.White;
            this.btn_CapNhap.Location = new System.Drawing.Point(360, 382);
            this.btn_CapNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CapNhap.Name = "btn_CapNhap";
            this.btn_CapNhap.Size = new System.Drawing.Size(128, 52);
            this.btn_CapNhap.TabIndex = 2;
            this.btn_CapNhap.Text = "Cập nhập";
            this.btn_CapNhap.UseVisualStyleBackColor = false;
            this.btn_CapNhap.Click += new System.EventHandler(this.btn_CapNhap_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Black;
            this.btn_Xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(196, 382);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(128, 52);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Black;
            this.btn_Them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(32, 382);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(128, 52);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // pn_HoTen
            // 
            this.pn_HoTen.AutoSize = true;
            this.pn_HoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_HoTen.Controls.Add(this.tb_HoTen);
            this.pn_HoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pn_HoTen.Location = new System.Drawing.Point(292, 137);
            this.pn_HoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_HoTen.Name = "pn_HoTen";
            this.pn_HoTen.Padding = new System.Windows.Forms.Padding(11, 15, 11, 15);
            this.pn_HoTen.Size = new System.Drawing.Size(213, 49);
            this.pn_HoTen.TabIndex = 4;
            // 
            // tb_HoTen
            // 
            this.tb_HoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_HoTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_HoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_HoTen.ForeColor = System.Drawing.Color.Black;
            this.tb_HoTen.Location = new System.Drawing.Point(11, 15);
            this.tb_HoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_HoTen.Name = "tb_HoTen";
            this.tb_HoTen.Size = new System.Drawing.Size(189, 20);
            this.tb_HoTen.TabIndex = 0;
            this.tb_HoTen.Text = "Nguyễn Văn A";
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.AutoSize = true;
            this.lb_HoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HoTen.Location = new System.Drawing.Point(288, 114);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.Size = new System.Drawing.Size(56, 20);
            this.lb_HoTen.TabIndex = 5;
            this.lb_HoTen.Text = "Họ Tên";
            // 
            // lb_MaKH
            // 
            this.lb_MaKH.AutoSize = true;
            this.lb_MaKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaKH.Location = new System.Drawing.Point(45, 114);
            this.lb_MaKH.Name = "lb_MaKH";
            this.lb_MaKH.Size = new System.Drawing.Size(109, 20);
            this.lb_MaKH.TabIndex = 10;
            this.lb_MaKH.Text = "Mã khách hàng";
            // 
            // pn_MaKH
            // 
            this.pn_MaKH.AutoSize = true;
            this.pn_MaKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_MaKH.Controls.Add(this.tb_MaKH);
            this.pn_MaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pn_MaKH.Location = new System.Drawing.Point(49, 137);
            this.pn_MaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_MaKH.Name = "pn_MaKH";
            this.pn_MaKH.Padding = new System.Windows.Forms.Padding(11, 15, 11, 15);
            this.pn_MaKH.Size = new System.Drawing.Size(213, 49);
            this.pn_MaKH.TabIndex = 9;
            // 
            // tb_MaKH
            // 
            this.tb_MaKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_MaKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_MaKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaKH.ForeColor = System.Drawing.Color.Black;
            this.tb_MaKH.Location = new System.Drawing.Point(11, 15);
            this.tb_MaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_MaKH.Name = "tb_MaKH";
            this.tb_MaKH.Size = new System.Drawing.Size(189, 20);
            this.tb_MaKH.TabIndex = 0;
            this.tb_MaKH.Text = "1";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID.Location = new System.Drawing.Point(45, 203);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(97, 20);
            this.lb_ID.TabIndex = 14;
            this.lb_ID.Text = "CCCD/CMND";
            // 
            // pn_ID
            // 
            this.pn_ID.AutoSize = true;
            this.pn_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_ID.Controls.Add(this.tb_ID);
            this.pn_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pn_ID.Location = new System.Drawing.Point(49, 224);
            this.pn_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_ID.Name = "pn_ID";
            this.pn_ID.Padding = new System.Windows.Forms.Padding(11, 15, 11, 15);
            this.pn_ID.Size = new System.Drawing.Size(213, 49);
            this.pn_ID.TabIndex = 13;
            // 
            // tb_ID
            // 
            this.tb_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.ForeColor = System.Drawing.Color.Black;
            this.tb_ID.Location = new System.Drawing.Point(11, 15);
            this.tb_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(189, 20);
            this.tb_ID.TabIndex = 0;
            this.tb_ID.Text = "1";
            // 
            // lb_SDT
            // 
            this.lb_SDT.AutoSize = true;
            this.lb_SDT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SDT.Location = new System.Drawing.Point(288, 203);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(97, 20);
            this.lb_SDT.TabIndex = 12;
            this.lb_SDT.Text = "Số điện thoại";
            // 
            // pn_SDT
            // 
            this.pn_SDT.AutoSize = true;
            this.pn_SDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_SDT.Controls.Add(this.tb_SDT);
            this.pn_SDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pn_SDT.Location = new System.Drawing.Point(292, 224);
            this.pn_SDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_SDT.Name = "pn_SDT";
            this.pn_SDT.Padding = new System.Windows.Forms.Padding(11, 15, 11, 15);
            this.pn_SDT.Size = new System.Drawing.Size(213, 49);
            this.pn_SDT.TabIndex = 11;
            // 
            // tb_SDT
            // 
            this.tb_SDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_SDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_SDT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SDT.ForeColor = System.Drawing.Color.Black;
            this.tb_SDT.Location = new System.Drawing.Point(11, 15);
            this.tb_SDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_SDT.Name = "tb_SDT";
            this.tb_SDT.Size = new System.Drawing.Size(189, 20);
            this.tb_SDT.TabIndex = 0;
            this.tb_SDT.Text = "Nguyễn Văn A";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DiaChi.Location = new System.Drawing.Point(45, 290);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(55, 20);
            this.lb_DiaChi.TabIndex = 18;
            this.lb_DiaChi.Text = "Địa chỉ";
            // 
            // pn_DiaChi
            // 
            this.pn_DiaChi.AutoSize = true;
            this.pn_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_DiaChi.Controls.Add(this.tb_DiaChi);
            this.pn_DiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pn_DiaChi.Location = new System.Drawing.Point(49, 311);
            this.pn_DiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_DiaChi.Name = "pn_DiaChi";
            this.pn_DiaChi.Padding = new System.Windows.Forms.Padding(11, 15, 11, 15);
            this.pn_DiaChi.Size = new System.Drawing.Size(213, 49);
            this.pn_DiaChi.TabIndex = 17;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_DiaChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_DiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DiaChi.ForeColor = System.Drawing.Color.Black;
            this.tb_DiaChi.Location = new System.Drawing.Point(11, 15);
            this.tb_DiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(189, 20);
            this.tb_DiaChi.TabIndex = 0;
            this.tb_DiaChi.Text = "Tp. Thủ Đức";
            // 
            // pn_LoaiKH
            // 
            this.pn_LoaiKH.AutoSize = true;
            this.pn_LoaiKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_LoaiKH.Controls.Add(this.cb_LoaiKH);
            this.pn_LoaiKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pn_LoaiKH.Location = new System.Drawing.Point(292, 311);
            this.pn_LoaiKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_LoaiKH.Name = "pn_LoaiKH";
            this.pn_LoaiKH.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pn_LoaiKH.Size = new System.Drawing.Size(213, 49);
            this.pn_LoaiKH.TabIndex = 19;
            // 
            // cb_LoaiKH
            // 
            this.cb_LoaiKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_LoaiKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_LoaiKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_LoaiKH.FormattingEnabled = true;
            this.cb_LoaiKH.Location = new System.Drawing.Point(11, 10);
            this.cb_LoaiKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_LoaiKH.Name = "cb_LoaiKH";
            this.cb_LoaiKH.Size = new System.Drawing.Size(189, 28);
            this.cb_LoaiKH.TabIndex = 21;
            this.cb_LoaiKH.Text = "Khách du lịch";
            // 
            // lb_LoaiKH
            // 
            this.lb_LoaiKH.AutoSize = true;
            this.lb_LoaiKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LoaiKH.Location = new System.Drawing.Point(288, 290);
            this.lb_LoaiKH.Name = "lb_LoaiKH";
            this.lb_LoaiKH.Size = new System.Drawing.Size(116, 20);
            this.lb_LoaiKH.TabIndex = 20;
            this.lb_LoaiKH.Text = "Loại khách hàng";
            // 
            // lb_TTKH
            // 
            this.lb_TTKH.AutoSize = true;
            this.lb_TTKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TTKH.Location = new System.Drawing.Point(136, 34);
            this.lb_TTKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_TTKH.Name = "lb_TTKH";
            this.lb_TTKH.Size = new System.Drawing.Size(246, 28);
            this.lb_TTKH.TabIndex = 21;
            this.lb_TTKH.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // pn_TTKH
            // 
            this.pn_TTKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_TTKH.Controls.Add(this.lb_TTKH);
            this.pn_TTKH.Controls.Add(this.btn_CapNhap);
            this.pn_TTKH.Controls.Add(this.btn_Xoa);
            this.pn_TTKH.Controls.Add(this.btn_Them);
            this.pn_TTKH.Location = new System.Drawing.Point(16, 15);
            this.pn_TTKH.Margin = new System.Windows.Forms.Padding(5);
            this.pn_TTKH.Name = "pn_TTKH";
            this.pn_TTKH.Size = new System.Drawing.Size(519, 499);
            this.pn_TTKH.TabIndex = 22;
            // 
            // pn_TimKiem
            // 
            this.pn_TimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_TimKiem.Controls.Add(this.btn_TimKiemNangCao);
            this.pn_TimKiem.Controls.Add(this.lb_TimKiem);
            this.pn_TimKiem.Controls.Add(this.pn_NhapTuKhoa);
            this.pn_TimKiem.Controls.Add(this.btn_TiemKiem);
            this.pn_TimKiem.Location = new System.Drawing.Point(557, 16);
            this.pn_TimKiem.Margin = new System.Windows.Forms.Padding(5);
            this.pn_TimKiem.Name = "pn_TimKiem";
            this.pn_TimKiem.Size = new System.Drawing.Size(730, 99);
            this.pn_TimKiem.TabIndex = 23;
            // 
            // btn_TimKiemNangCao
            // 
            this.btn_TimKiemNangCao.BackColor = System.Drawing.Color.Transparent;
            this.btn_TimKiemNangCao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_TimKiemNangCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiemNangCao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiemNangCao.ForeColor = System.Drawing.Color.Black;
            this.btn_TimKiemNangCao.Location = new System.Drawing.Point(532, 21);
            this.btn_TimKiemNangCao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiemNangCao.Name = "btn_TimKiemNangCao";
            this.btn_TimKiemNangCao.Size = new System.Drawing.Size(179, 49);
            this.btn_TimKiemNangCao.TabIndex = 7;
            this.btn_TimKiemNangCao.Text = "Tìm kiếm nâng cao";
            this.btn_TimKiemNangCao.UseVisualStyleBackColor = false;
            // 
            // lb_TimKiem
            // 
            this.lb_TimKiem.AutoSize = true;
            this.lb_TimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TimKiem.Location = new System.Drawing.Point(27, 33);
            this.lb_TimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_TimKiem.Name = "lb_TimKiem";
            this.lb_TimKiem.Size = new System.Drawing.Size(95, 28);
            this.lb_TimKiem.TabIndex = 0;
            this.lb_TimKiem.Text = "TÌM KIẾM";
            // 
            // dgv_TTKH
            // 
            this.dgv_TTKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TTKH.Location = new System.Drawing.Point(557, 137);
            this.dgv_TTKH.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_TTKH.Name = "dgv_TTKH";
            this.dgv_TTKH.RowHeadersWidth = 51;
            this.dgv_TTKH.Size = new System.Drawing.Size(731, 378);
            this.dgv_TTKH.TabIndex = 24;
            // 
            // fGuestMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1304, 530);
            this.Controls.Add(this.dgv_TTKH);
            this.Controls.Add(this.lb_LoaiKH);
            this.Controls.Add(this.pn_LoaiKH);
            this.Controls.Add(this.lb_DiaChi);
            this.Controls.Add(this.pn_DiaChi);
            this.Controls.Add(this.lb_ID);
            this.Controls.Add(this.pn_ID);
            this.Controls.Add(this.lb_SDT);
            this.Controls.Add(this.pn_SDT);
            this.Controls.Add(this.lb_MaKH);
            this.Controls.Add(this.pn_MaKH);
            this.Controls.Add(this.lb_HoTen);
            this.Controls.Add(this.pn_HoTen);
            this.Controls.Add(this.pn_TTKH);
            this.Controls.Add(this.pn_TimKiem);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fGuestMgmt";
            this.Text = "Quản lý khách hàng";
            this.pn_NhapTuKhoa.ResumeLayout(false);
            this.pn_NhapTuKhoa.PerformLayout();
            this.pn_HoTen.ResumeLayout(false);
            this.pn_HoTen.PerformLayout();
            this.pn_MaKH.ResumeLayout(false);
            this.pn_MaKH.PerformLayout();
            this.pn_ID.ResumeLayout(false);
            this.pn_ID.PerformLayout();
            this.pn_SDT.ResumeLayout(false);
            this.pn_SDT.PerformLayout();
            this.pn_DiaChi.ResumeLayout(false);
            this.pn_DiaChi.PerformLayout();
            this.pn_LoaiKH.ResumeLayout(false);
            this.pn_TTKH.ResumeLayout(false);
            this.pn_TTKH.PerformLayout();
            this.pn_TimKiem.ResumeLayout(false);
            this.pn_TimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TTKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pn_NhapTuKhoa;
        private System.Windows.Forms.TextBox tb_NhapTuKhoa;
        private System.Windows.Forms.Button btn_TiemKiem;
        private System.Windows.Forms.Button btn_CapNhap;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Panel pn_HoTen;
        private System.Windows.Forms.TextBox tb_HoTen;
        private System.Windows.Forms.Label lb_HoTen;
        private System.Windows.Forms.Label lb_MaKH;
        private System.Windows.Forms.Panel pn_MaKH;
        private System.Windows.Forms.TextBox tb_MaKH;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Panel pn_ID;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lb_SDT;
        private System.Windows.Forms.Panel pn_SDT;
        private System.Windows.Forms.TextBox tb_SDT;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Panel pn_DiaChi;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pn_LoaiKH;
        private System.Windows.Forms.ComboBox cb_LoaiKH;
        private System.Windows.Forms.Label lb_LoaiKH;
        private System.Windows.Forms.Label lb_TTKH;
        private System.Windows.Forms.Panel pn_TTKH;
        private System.Windows.Forms.Panel pn_TimKiem;
        private System.Windows.Forms.Label lb_TimKiem;
        private System.Windows.Forms.Button btn_TimKiemNangCao;
        private System.Windows.Forms.DataGridView dgv_TTKH;
    }
}