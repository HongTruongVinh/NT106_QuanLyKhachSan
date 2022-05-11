
namespace QuanLyKhachSan
{
    partial class fBillMgmt
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
            this.lb_TieuDe = new System.Windows.Forms.Label();
            this.lb_MaHD = new System.Windows.Forms.Label();
            this.lb_DLMaKH = new System.Windows.Forms.Label();
            this.lb_MaKH = new System.Windows.Forms.Label();
            this.lb_DLTenKH = new System.Windows.Forms.Label();
            this.lb_TenKH = new System.Windows.Forms.Label();
            this.dgv_ChiTietHD = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlp_ThongTinKH = new System.Windows.Forms.TableLayoutPanel();
            this.lb_DLLoaiKH = new System.Windows.Forms.Label();
            this.lb_DLDiaChi = new System.Windows.Forms.Label();
            this.lb_DLCMND = new System.Windows.Forms.Label();
            this.lb_CMND = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_LoaiKH = new System.Windows.Forms.Label();
            this.tlp_MaHD = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Xuat = new System.Windows.Forms.Button();
            this.pn_NhapMaHD = new System.Windows.Forms.Panel();
            this.tb_NhapMaHD = new System.Windows.Forms.TextBox();
            this.lb_ThongTinKH = new System.Windows.Forms.Label();
            this.lb_ChiTietHD = new System.Windows.Forms.Label();
            this.tlp_TriGia = new System.Windows.Forms.TableLayoutPanel();
            this.lb_TriGia = new System.Windows.Forms.Label();
            this.lb_DLTriGia = new System.Windows.Forms.Label();
            this.tlp_Chinh = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Tren = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietHD)).BeginInit();
            this.tlp_ThongTinKH.SuspendLayout();
            this.tlp_MaHD.SuspendLayout();
            this.pn_NhapMaHD.SuspendLayout();
            this.tlp_TriGia.SuspendLayout();
            this.tlp_Chinh.SuspendLayout();
            this.tlp_Tren.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_TieuDe
            // 
            this.lb_TieuDe.AutoSize = true;
            this.lb_TieuDe.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_TieuDe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TieuDe.Location = new System.Drawing.Point(27, 9);
            this.lb_TieuDe.Margin = new System.Windows.Forms.Padding(27, 9, 9, 9);
            this.lb_TieuDe.Name = "lb_TieuDe";
            this.lb_TieuDe.Size = new System.Drawing.Size(185, 38);
            this.lb_TieuDe.TabIndex = 0;
            this.lb_TieuDe.Text = "HÓA ĐƠN THANH TOÁN";
            this.lb_TieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_MaHD
            // 
            this.lb_MaHD.AutoSize = true;
            this.lb_MaHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_MaHD.Location = new System.Drawing.Point(9, 9);
            this.lb_MaHD.Margin = new System.Windows.Forms.Padding(9);
            this.lb_MaHD.Name = "lb_MaHD";
            this.lb_MaHD.Size = new System.Drawing.Size(75, 32);
            this.lb_MaHD.TabIndex = 1;
            this.lb_MaHD.Text = "Mã hóa đơn:";
            this.lb_MaHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_DLMaKH
            // 
            this.lb_DLMaKH.AutoSize = true;
            this.lb_DLMaKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DLMaKH.Location = new System.Drawing.Point(125, 9);
            this.lb_DLMaKH.Margin = new System.Windows.Forms.Padding(9);
            this.lb_DLMaKH.Name = "lb_DLMaKH";
            this.lb_DLMaKH.Size = new System.Drawing.Size(154, 19);
            this.lb_DLMaKH.TabIndex = 5;
            this.lb_DLMaKH.Text = "(Mã khách hàng)";
            this.lb_DLMaKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_MaKH
            // 
            this.lb_MaKH.AutoSize = true;
            this.lb_MaKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_MaKH.Location = new System.Drawing.Point(9, 9);
            this.lb_MaKH.Margin = new System.Windows.Forms.Padding(9);
            this.lb_MaKH.Name = "lb_MaKH";
            this.lb_MaKH.Size = new System.Drawing.Size(98, 19);
            this.lb_MaKH.TabIndex = 4;
            this.lb_MaKH.Text = "Mã khách hàng:";
            this.lb_MaKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_DLTenKH
            // 
            this.lb_DLTenKH.AutoSize = true;
            this.lb_DLTenKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DLTenKH.Location = new System.Drawing.Point(125, 46);
            this.lb_DLTenKH.Margin = new System.Windows.Forms.Padding(9);
            this.lb_DLTenKH.Name = "lb_DLTenKH";
            this.lb_DLTenKH.Size = new System.Drawing.Size(154, 19);
            this.lb_DLTenKH.TabIndex = 11;
            this.lb_DLTenKH.Text = "(Tên khách hàng)";
            this.lb_DLTenKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_TenKH
            // 
            this.lb_TenKH.AutoSize = true;
            this.lb_TenKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_TenKH.Location = new System.Drawing.Point(9, 46);
            this.lb_TenKH.Margin = new System.Windows.Forms.Padding(9);
            this.lb_TenKH.Name = "lb_TenKH";
            this.lb_TenKH.Size = new System.Drawing.Size(98, 19);
            this.lb_TenKH.TabIndex = 10;
            this.lb_TenKH.Text = "Tên khách hàng:";
            this.lb_TenKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_ChiTietHD
            // 
            this.dgv_ChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.SoNgayThue,
            this.ThanhTien,
            this.NgayThanhToan,
            this.DonGia});
            this.dgv_ChiTietHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ChiTietHD.Location = new System.Drawing.Point(27, 256);
            this.dgv_ChiTietHD.Margin = new System.Windows.Forms.Padding(27, 3, 27, 3);
            this.dgv_ChiTietHD.Name = "dgv_ChiTietHD";
            this.dgv_ChiTietHD.RowHeadersWidth = 51;
            this.dgv_ChiTietHD.Size = new System.Drawing.Size(779, 217);
            this.dgv_ChiTietHD.TabIndex = 12;
            // 
            // MaPhong
            // 
            this.MaPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            // 
            // SoNgayThue
            // 
            this.SoNgayThue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoNgayThue.HeaderText = "Số Ngày Thuê";
            this.SoNgayThue.MinimumWidth = 6;
            this.SoNgayThue.Name = "SoNgayThue";
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // NgayThanhToan
            // 
            this.NgayThanhToan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayThanhToan.HeaderText = "Ngày Thanh Toán";
            this.NgayThanhToan.MinimumWidth = 6;
            this.NgayThanhToan.Name = "NgayThanhToan";
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // tlp_ThongTinKH
            // 
            this.tlp_ThongTinKH.ColumnCount = 5;
            this.tlp_ThongTinKH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.44944F));
            this.tlp_ThongTinKH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.55056F));
            this.tlp_ThongTinKH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlp_ThongTinKH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tlp_ThongTinKH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tlp_ThongTinKH.Controls.Add(this.lb_DLLoaiKH, 4, 1);
            this.tlp_ThongTinKH.Controls.Add(this.lb_DLDiaChi, 4, 0);
            this.tlp_ThongTinKH.Controls.Add(this.lb_DLCMND, 1, 2);
            this.tlp_ThongTinKH.Controls.Add(this.lb_CMND, 0, 2);
            this.tlp_ThongTinKH.Controls.Add(this.lb_MaKH, 0, 0);
            this.tlp_ThongTinKH.Controls.Add(this.lb_DLMaKH, 1, 0);
            this.tlp_ThongTinKH.Controls.Add(this.lb_DLTenKH, 1, 1);
            this.tlp_ThongTinKH.Controls.Add(this.lb_TenKH, 0, 1);
            this.tlp_ThongTinKH.Controls.Add(this.lb_DiaChi, 3, 0);
            this.tlp_ThongTinKH.Controls.Add(this.lb_LoaiKH, 3, 1);
            this.tlp_ThongTinKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_ThongTinKH.Location = new System.Drawing.Point(27, 104);
            this.tlp_ThongTinKH.Margin = new System.Windows.Forms.Padding(27, 3, 27, 3);
            this.tlp_ThongTinKH.Name = "tlp_ThongTinKH";
            this.tlp_ThongTinKH.RowCount = 3;
            this.tlp_ThongTinKH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ThongTinKH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ThongTinKH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlp_ThongTinKH.Size = new System.Drawing.Size(779, 107);
            this.tlp_ThongTinKH.TabIndex = 13;
            // 
            // lb_DLLoaiKH
            // 
            this.lb_DLLoaiKH.AutoSize = true;
            this.lb_DLLoaiKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DLLoaiKH.Location = new System.Drawing.Point(605, 46);
            this.lb_DLLoaiKH.Margin = new System.Windows.Forms.Padding(9);
            this.lb_DLLoaiKH.Name = "lb_DLLoaiKH";
            this.lb_DLLoaiKH.Size = new System.Drawing.Size(165, 19);
            this.lb_DLLoaiKH.TabIndex = 17;
            this.lb_DLLoaiKH.Text = "(Loại khách hàng)";
            this.lb_DLLoaiKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_DLDiaChi
            // 
            this.lb_DLDiaChi.AutoSize = true;
            this.lb_DLDiaChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DLDiaChi.Location = new System.Drawing.Point(605, 9);
            this.lb_DLDiaChi.Margin = new System.Windows.Forms.Padding(9);
            this.lb_DLDiaChi.Name = "lb_DLDiaChi";
            this.lb_DLDiaChi.Size = new System.Drawing.Size(165, 19);
            this.lb_DLDiaChi.TabIndex = 15;
            this.lb_DLDiaChi.Text = "(Địa chỉ)";
            this.lb_DLDiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_DLCMND
            // 
            this.lb_DLCMND.AutoSize = true;
            this.lb_DLCMND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DLCMND.Location = new System.Drawing.Point(125, 83);
            this.lb_DLCMND.Margin = new System.Windows.Forms.Padding(9);
            this.lb_DLCMND.Name = "lb_DLCMND";
            this.lb_DLCMND.Size = new System.Drawing.Size(154, 15);
            this.lb_DLCMND.TabIndex = 15;
            this.lb_DLCMND.Text = "(CMND)";
            this.lb_DLCMND.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_CMND
            // 
            this.lb_CMND.AutoSize = true;
            this.lb_CMND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CMND.Location = new System.Drawing.Point(9, 83);
            this.lb_CMND.Margin = new System.Windows.Forms.Padding(9);
            this.lb_CMND.Name = "lb_CMND";
            this.lb_CMND.Size = new System.Drawing.Size(98, 15);
            this.lb_CMND.TabIndex = 15;
            this.lb_CMND.Text = "CMND:";
            this.lb_CMND.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DiaChi.Location = new System.Drawing.Point(437, 9);
            this.lb_DiaChi.Margin = new System.Windows.Forms.Padding(9);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(150, 19);
            this.lb_DiaChi.TabIndex = 12;
            this.lb_DiaChi.Text = "Địa chỉ:";
            this.lb_DiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_LoaiKH
            // 
            this.lb_LoaiKH.AutoSize = true;
            this.lb_LoaiKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_LoaiKH.Location = new System.Drawing.Point(437, 46);
            this.lb_LoaiKH.Margin = new System.Windows.Forms.Padding(9);
            this.lb_LoaiKH.Name = "lb_LoaiKH";
            this.lb_LoaiKH.Size = new System.Drawing.Size(150, 19);
            this.lb_LoaiKH.TabIndex = 16;
            this.lb_LoaiKH.Text = "Loại khách hàng:";
            this.lb_LoaiKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlp_MaHD
            // 
            this.tlp_MaHD.ColumnCount = 3;
            this.tlp_MaHD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.25974F));
            this.tlp_MaHD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.74026F));
            this.tlp_MaHD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tlp_MaHD.Controls.Add(this.btn_Xuat, 0, 0);
            this.tlp_MaHD.Controls.Add(this.pn_NhapMaHD, 0, 0);
            this.tlp_MaHD.Controls.Add(this.lb_MaHD, 0, 0);
            this.tlp_MaHD.Dock = System.Windows.Forms.DockStyle.Right;
            this.tlp_MaHD.Location = new System.Drawing.Point(472, 3);
            this.tlp_MaHD.Margin = new System.Windows.Forms.Padding(3, 3, 27, 3);
            this.tlp_MaHD.Name = "tlp_MaHD";
            this.tlp_MaHD.RowCount = 1;
            this.tlp_MaHD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_MaHD.Size = new System.Drawing.Size(328, 50);
            this.tlp_MaHD.TabIndex = 14;
            // 
            // btn_Xuat
            // 
            this.btn_Xuat.BackColor = System.Drawing.Color.Black;
            this.btn_Xuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Xuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Xuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xuat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xuat.ForeColor = System.Drawing.Color.White;
            this.btn_Xuat.Location = new System.Drawing.Point(233, 2);
            this.btn_Xuat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xuat.Name = "btn_Xuat";
            this.btn_Xuat.Size = new System.Drawing.Size(93, 46);
            this.btn_Xuat.TabIndex = 7;
            this.btn_Xuat.Text = "Xuất";
            this.btn_Xuat.UseVisualStyleBackColor = false;
            this.btn_Xuat.Click += new System.EventHandler(this.btn_Xuat_Click);
            // 
            // pn_NhapMaHD
            // 
            this.pn_NhapMaHD.AutoSize = true;
            this.pn_NhapMaHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_NhapMaHD.Controls.Add(this.tb_NhapMaHD);
            this.pn_NhapMaHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pn_NhapMaHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_NhapMaHD.Location = new System.Drawing.Point(96, 3);
            this.pn_NhapMaHD.Name = "pn_NhapMaHD";
            this.pn_NhapMaHD.Padding = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.pn_NhapMaHD.Size = new System.Drawing.Size(132, 44);
            this.pn_NhapMaHD.TabIndex = 4;
            // 
            // tb_NhapMaHD
            // 
            this.tb_NhapMaHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_NhapMaHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_NhapMaHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NhapMaHD.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tb_NhapMaHD.Location = new System.Drawing.Point(8, 12);
            this.tb_NhapMaHD.Name = "tb_NhapMaHD";
            this.tb_NhapMaHD.Size = new System.Drawing.Size(114, 20);
            this.tb_NhapMaHD.TabIndex = 0;
            // 
            // lb_ThongTinKH
            // 
            this.lb_ThongTinKH.AutoSize = true;
            this.lb_ThongTinKH.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_ThongTinKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThongTinKH.Location = new System.Drawing.Point(27, 71);
            this.lb_ThongTinKH.Margin = new System.Windows.Forms.Padding(27, 9, 9, 9);
            this.lb_ThongTinKH.Name = "lb_ThongTinKH";
            this.lb_ThongTinKH.Size = new System.Drawing.Size(148, 21);
            this.lb_ThongTinKH.TabIndex = 15;
            this.lb_ThongTinKH.Text = "Thông tin khách hàng";
            this.lb_ThongTinKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_ChiTietHD
            // 
            this.lb_ChiTietHD.AutoSize = true;
            this.lb_ChiTietHD.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_ChiTietHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChiTietHD.Location = new System.Drawing.Point(27, 223);
            this.lb_ChiTietHD.Margin = new System.Windows.Forms.Padding(27, 9, 9, 9);
            this.lb_ChiTietHD.Name = "lb_ChiTietHD";
            this.lb_ChiTietHD.Size = new System.Drawing.Size(112, 21);
            this.lb_ChiTietHD.TabIndex = 16;
            this.lb_ChiTietHD.Text = "Chi tiết hóa đơn";
            this.lb_ChiTietHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlp_TriGia
            // 
            this.tlp_TriGia.ColumnCount = 2;
            this.tlp_TriGia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TriGia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TriGia.Controls.Add(this.lb_TriGia, 0, 0);
            this.tlp_TriGia.Controls.Add(this.lb_DLTriGia, 1, 0);
            this.tlp_TriGia.Dock = System.Windows.Forms.DockStyle.Right;
            this.tlp_TriGia.Location = new System.Drawing.Point(606, 479);
            this.tlp_TriGia.Margin = new System.Windows.Forms.Padding(3, 3, 27, 3);
            this.tlp_TriGia.Name = "tlp_TriGia";
            this.tlp_TriGia.RowCount = 1;
            this.tlp_TriGia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TriGia.Size = new System.Drawing.Size(200, 36);
            this.tlp_TriGia.TabIndex = 17;
            // 
            // lb_TriGia
            // 
            this.lb_TriGia.AutoSize = true;
            this.lb_TriGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_TriGia.Location = new System.Drawing.Point(9, 9);
            this.lb_TriGia.Margin = new System.Windows.Forms.Padding(9);
            this.lb_TriGia.Name = "lb_TriGia";
            this.lb_TriGia.Size = new System.Drawing.Size(82, 18);
            this.lb_TriGia.TabIndex = 1;
            this.lb_TriGia.Text = "Trị giá:";
            this.lb_TriGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_DLTriGia
            // 
            this.lb_DLTriGia.AutoSize = true;
            this.lb_DLTriGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DLTriGia.Location = new System.Drawing.Point(109, 9);
            this.lb_DLTriGia.Margin = new System.Windows.Forms.Padding(9);
            this.lb_DLTriGia.Name = "lb_DLTriGia";
            this.lb_DLTriGia.Size = new System.Drawing.Size(82, 18);
            this.lb_DLTriGia.TabIndex = 2;
            this.lb_DLTriGia.Text = "(Trị giá)";
            this.lb_DLTriGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlp_Chinh
            // 
            this.tlp_Chinh.ColumnCount = 1;
            this.tlp_Chinh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Chinh.Controls.Add(this.tlp_Tren, 0, 0);
            this.tlp_Chinh.Controls.Add(this.lb_ThongTinKH, 0, 1);
            this.tlp_Chinh.Controls.Add(this.lb_ChiTietHD, 0, 3);
            this.tlp_Chinh.Controls.Add(this.tlp_TriGia, 0, 5);
            this.tlp_Chinh.Controls.Add(this.tlp_ThongTinKH, 0, 2);
            this.tlp_Chinh.Controls.Add(this.dgv_ChiTietHD, 0, 4);
            this.tlp_Chinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Chinh.Location = new System.Drawing.Point(0, 0);
            this.tlp_Chinh.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Chinh.Name = "tlp_Chinh";
            this.tlp_Chinh.RowCount = 6;
            this.tlp_Chinh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.38614F));
            this.tlp_Chinh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.61386F));
            this.tlp_Chinh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tlp_Chinh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlp_Chinh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.tlp_Chinh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlp_Chinh.Size = new System.Drawing.Size(833, 518);
            this.tlp_Chinh.TabIndex = 18;
            // 
            // tlp_Tren
            // 
            this.tlp_Tren.ColumnCount = 2;
            this.tlp_Tren.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Tren.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Tren.Controls.Add(this.lb_TieuDe, 0, 0);
            this.tlp_Tren.Controls.Add(this.tlp_MaHD, 1, 0);
            this.tlp_Tren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Tren.Location = new System.Drawing.Point(3, 3);
            this.tlp_Tren.Name = "tlp_Tren";
            this.tlp_Tren.RowCount = 1;
            this.tlp_Tren.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Tren.Size = new System.Drawing.Size(827, 56);
            this.tlp_Tren.TabIndex = 19;
            // 
            // fBillMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(833, 518);
            this.Controls.Add(this.tlp_Chinh);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fBillMgmt";
            this.Text = "Quản lý hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietHD)).EndInit();
            this.tlp_ThongTinKH.ResumeLayout(false);
            this.tlp_ThongTinKH.PerformLayout();
            this.tlp_MaHD.ResumeLayout(false);
            this.tlp_MaHD.PerformLayout();
            this.pn_NhapMaHD.ResumeLayout(false);
            this.pn_NhapMaHD.PerformLayout();
            this.tlp_TriGia.ResumeLayout(false);
            this.tlp_TriGia.PerformLayout();
            this.tlp_Chinh.ResumeLayout(false);
            this.tlp_Chinh.PerformLayout();
            this.tlp_Tren.ResumeLayout(false);
            this.tlp_Tren.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_TieuDe;
        private System.Windows.Forms.Label lb_MaHD;
        private System.Windows.Forms.Label lb_DLMaKH;
        private System.Windows.Forms.Label lb_MaKH;
        private System.Windows.Forms.Label lb_DLTenKH;
        private System.Windows.Forms.Label lb_TenKH;
        private System.Windows.Forms.DataGridView dgv_ChiTietHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.TableLayoutPanel tlp_ThongTinKH;
        private System.Windows.Forms.TableLayoutPanel tlp_MaHD;
        private System.Windows.Forms.Label lb_DLCMND;
        private System.Windows.Forms.Label lb_CMND;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_DLLoaiKH;
        private System.Windows.Forms.Label lb_DLDiaChi;
        private System.Windows.Forms.Label lb_LoaiKH;
        private System.Windows.Forms.Label lb_ThongTinKH;
        private System.Windows.Forms.Label lb_ChiTietHD;
        private System.Windows.Forms.TableLayoutPanel tlp_TriGia;
        private System.Windows.Forms.Label lb_TriGia;
        private System.Windows.Forms.Label lb_DLTriGia;
        private System.Windows.Forms.TableLayoutPanel tlp_Chinh;
        private System.Windows.Forms.TableLayoutPanel tlp_Tren;
        private System.Windows.Forms.Panel pn_NhapMaHD;
        private System.Windows.Forms.TextBox tb_NhapMaHD;
        private System.Windows.Forms.Button btn_Xuat;
    }
}