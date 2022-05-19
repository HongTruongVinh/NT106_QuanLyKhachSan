
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
            this.lb_MaKH = new System.Windows.Forms.Label();
            this.lb_TenKH = new System.Windows.Forms.Label();
            this.dgv_ChiTietHD = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SoNgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlp_ThongTinKH = new System.Windows.Forms.TableLayoutPanel();
            this.lb_DLLoaiKH = new System.Windows.Forms.Label();
            this.lb_DLDiaChi = new System.Windows.Forms.Label();
            this.lb_CMND = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_LoaiKH = new System.Windows.Forms.Label();
            this.cb_MaKH = new System.Windows.Forms.ComboBox();
            this.cb_TenKH = new System.Windows.Forms.ComboBox();
            this.cb_CMND = new System.Windows.Forms.ComboBox();
            this.lb_ThongTinKH = new System.Windows.Forms.Label();
            this.lb_ChiTietHD = new System.Windows.Forms.Label();
            this.tlp_Chinh = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Duoi = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Tao = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.tlp_TongKet = new System.Windows.Forms.TableLayoutPanel();
            this.cb_TinhTrangThanhToan = new System.Windows.Forms.ComboBox();
            this.lb_TinhTrangThanhToan = new System.Windows.Forms.Label();
            this.lb_TriGia = new System.Windows.Forms.Label();
            this.lb_DLTriGia = new System.Windows.Forms.Label();
            this.tlp_Tren = new System.Windows.Forms.TableLayoutPanel();
            this.lb_TieuDe = new System.Windows.Forms.Label();
            this.tlp_MaHD = new System.Windows.Forms.TableLayoutPanel();
            this.pn_NhapMaHD = new System.Windows.Forms.Panel();
            this.tb_NhapMaHD = new System.Windows.Forms.TextBox();
            this.lb_MaHD = new System.Windows.Forms.Label();
            this.dgv_DSHD = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TriGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_DSHD = new System.Windows.Forms.Label();
            this.tlp_DSHD = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietHD)).BeginInit();
            this.tlp_ThongTinKH.SuspendLayout();
            this.tlp_Chinh.SuspendLayout();
            this.tlp_Duoi.SuspendLayout();
            this.tlp_TongKet.SuspendLayout();
            this.tlp_Tren.SuspendLayout();
            this.tlp_MaHD.SuspendLayout();
            this.pn_NhapMaHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSHD)).BeginInit();
            this.tlp_DSHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_MaKH
            // 
            this.lb_MaKH.AutoSize = true;
            this.lb_MaKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_MaKH.Location = new System.Drawing.Point(3, 3);
            this.lb_MaKH.Margin = new System.Windows.Forms.Padding(3);
            this.lb_MaKH.Name = "lb_MaKH";
            this.lb_MaKH.Size = new System.Drawing.Size(92, 23);
            this.lb_MaKH.TabIndex = 4;
            this.lb_MaKH.Text = "Mã khách hàng:";
            // 
            // lb_TenKH
            // 
            this.lb_TenKH.AutoSize = true;
            this.lb_TenKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_TenKH.Location = new System.Drawing.Point(3, 32);
            this.lb_TenKH.Margin = new System.Windows.Forms.Padding(3);
            this.lb_TenKH.Name = "lb_TenKH";
            this.lb_TenKH.Size = new System.Drawing.Size(92, 23);
            this.lb_TenKH.TabIndex = 10;
            this.lb_TenKH.Text = "Tên khách hàng:";
            // 
            // dgv_ChiTietHD
            // 
            this.dgv_ChiTietHD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.Chon,
            this.SoNgayThue,
            this.ThanhTien,
            this.NgayThanhToan,
            this.DonGia});
            this.dgv_ChiTietHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ChiTietHD.Location = new System.Drawing.Point(28, 230);
            this.dgv_ChiTietHD.Margin = new System.Windows.Forms.Padding(27, 3, 27, 3);
            this.dgv_ChiTietHD.Name = "dgv_ChiTietHD";
            this.dgv_ChiTietHD.RowHeadersWidth = 51;
            this.dgv_ChiTietHD.Size = new System.Drawing.Size(608, 222);
            this.dgv_ChiTietHD.TabIndex = 12;
            // 
            // MaPhong
            // 
            this.MaPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            // 
            // Chon
            // 
            this.Chon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Chon.HeaderText = "Chọn";
            this.Chon.MinimumWidth = 6;
            this.Chon.Name = "Chon";
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
            this.tlp_ThongTinKH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.62948F));
            this.tlp_ThongTinKH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.37052F));
            this.tlp_ThongTinKH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlp_ThongTinKH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tlp_ThongTinKH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tlp_ThongTinKH.Controls.Add(this.lb_DLLoaiKH, 4, 1);
            this.tlp_ThongTinKH.Controls.Add(this.lb_DLDiaChi, 4, 0);
            this.tlp_ThongTinKH.Controls.Add(this.lb_CMND, 0, 2);
            this.tlp_ThongTinKH.Controls.Add(this.lb_MaKH, 0, 0);
            this.tlp_ThongTinKH.Controls.Add(this.lb_TenKH, 0, 1);
            this.tlp_ThongTinKH.Controls.Add(this.lb_DiaChi, 3, 0);
            this.tlp_ThongTinKH.Controls.Add(this.lb_LoaiKH, 3, 1);
            this.tlp_ThongTinKH.Controls.Add(this.cb_MaKH, 1, 0);
            this.tlp_ThongTinKH.Controls.Add(this.cb_TenKH, 1, 1);
            this.tlp_ThongTinKH.Controls.Add(this.cb_CMND, 1, 2);
            this.tlp_ThongTinKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_ThongTinKH.Location = new System.Drawing.Point(28, 99);
            this.tlp_ThongTinKH.Margin = new System.Windows.Forms.Padding(27, 9, 27, 3);
            this.tlp_ThongTinKH.Name = "tlp_ThongTinKH";
            this.tlp_ThongTinKH.RowCount = 3;
            this.tlp_ThongTinKH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ThongTinKH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ThongTinKH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_ThongTinKH.Size = new System.Drawing.Size(608, 88);
            this.tlp_ThongTinKH.TabIndex = 13;
            // 
            // lb_DLLoaiKH
            // 
            this.lb_DLLoaiKH.AutoSize = true;
            this.lb_DLLoaiKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DLLoaiKH.Location = new System.Drawing.Point(443, 32);
            this.lb_DLLoaiKH.Margin = new System.Windows.Forms.Padding(3);
            this.lb_DLLoaiKH.Name = "lb_DLLoaiKH";
            this.lb_DLLoaiKH.Size = new System.Drawing.Size(162, 23);
            this.lb_DLLoaiKH.TabIndex = 17;
            this.lb_DLLoaiKH.Text = "(Loại khách hàng)";
            this.lb_DLLoaiKH.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_DLDiaChi
            // 
            this.lb_DLDiaChi.AutoSize = true;
            this.lb_DLDiaChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DLDiaChi.Location = new System.Drawing.Point(443, 3);
            this.lb_DLDiaChi.Margin = new System.Windows.Forms.Padding(3);
            this.lb_DLDiaChi.Name = "lb_DLDiaChi";
            this.lb_DLDiaChi.Size = new System.Drawing.Size(162, 23);
            this.lb_DLDiaChi.TabIndex = 15;
            this.lb_DLDiaChi.Text = "(Địa chỉ)";
            this.lb_DLDiaChi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_CMND
            // 
            this.lb_CMND.AutoSize = true;
            this.lb_CMND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CMND.Location = new System.Drawing.Point(3, 61);
            this.lb_CMND.Margin = new System.Windows.Forms.Padding(3);
            this.lb_CMND.Name = "lb_CMND";
            this.lb_CMND.Size = new System.Drawing.Size(92, 24);
            this.lb_CMND.TabIndex = 15;
            this.lb_CMND.Text = "CMND:";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DiaChi.Location = new System.Drawing.Point(330, 3);
            this.lb_DiaChi.Margin = new System.Windows.Forms.Padding(3);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(107, 23);
            this.lb_DiaChi.TabIndex = 12;
            this.lb_DiaChi.Text = "Địa chỉ:";
            // 
            // lb_LoaiKH
            // 
            this.lb_LoaiKH.AutoSize = true;
            this.lb_LoaiKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_LoaiKH.Location = new System.Drawing.Point(330, 32);
            this.lb_LoaiKH.Margin = new System.Windows.Forms.Padding(3);
            this.lb_LoaiKH.Name = "lb_LoaiKH";
            this.lb_LoaiKH.Size = new System.Drawing.Size(107, 23);
            this.lb_LoaiKH.TabIndex = 16;
            this.lb_LoaiKH.Text = "Loại khách hàng:";
            // 
            // cb_MaKH
            // 
            this.cb_MaKH.FormattingEnabled = true;
            this.cb_MaKH.Location = new System.Drawing.Point(101, 3);
            this.cb_MaKH.Name = "cb_MaKH";
            this.cb_MaKH.Size = new System.Drawing.Size(127, 28);
            this.cb_MaKH.TabIndex = 18;
            // 
            // cb_TenKH
            // 
            this.cb_TenKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_TenKH.FormattingEnabled = true;
            this.cb_TenKH.Location = new System.Drawing.Point(101, 32);
            this.cb_TenKH.Name = "cb_TenKH";
            this.cb_TenKH.Size = new System.Drawing.Size(127, 28);
            this.cb_TenKH.TabIndex = 19;
            // 
            // cb_CMND
            // 
            this.cb_CMND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_CMND.FormattingEnabled = true;
            this.cb_CMND.Location = new System.Drawing.Point(101, 61);
            this.cb_CMND.Name = "cb_CMND";
            this.cb_CMND.Size = new System.Drawing.Size(127, 28);
            this.cb_CMND.TabIndex = 20;
            // 
            // lb_ThongTinKH
            // 
            this.lb_ThongTinKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ThongTinKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThongTinKH.Location = new System.Drawing.Point(28, 64);
            this.lb_ThongTinKH.Margin = new System.Windows.Forms.Padding(27, 9, 9, 9);
            this.lb_ThongTinKH.Name = "lb_ThongTinKH";
            this.lb_ThongTinKH.Size = new System.Drawing.Size(626, 16);
            this.lb_ThongTinKH.TabIndex = 15;
            this.lb_ThongTinKH.Text = "Thông tin khách hàng";
            // 
            // lb_ChiTietHD
            // 
            this.lb_ChiTietHD.AutoSize = true;
            this.lb_ChiTietHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ChiTietHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChiTietHD.Location = new System.Drawing.Point(28, 200);
            this.lb_ChiTietHD.Margin = new System.Windows.Forms.Padding(27, 9, 9, 9);
            this.lb_ChiTietHD.Name = "lb_ChiTietHD";
            this.lb_ChiTietHD.Size = new System.Drawing.Size(626, 17);
            this.lb_ChiTietHD.TabIndex = 16;
            this.lb_ChiTietHD.Text = "Chi tiết hóa đơn";
            // 
            // tlp_Chinh
            // 
            this.tlp_Chinh.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlp_Chinh.ColumnCount = 1;
            this.tlp_Chinh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Chinh.Controls.Add(this.lb_ThongTinKH, 0, 1);
            this.tlp_Chinh.Controls.Add(this.lb_ChiTietHD, 0, 3);
            this.tlp_Chinh.Controls.Add(this.tlp_ThongTinKH, 0, 2);
            this.tlp_Chinh.Controls.Add(this.dgv_ChiTietHD, 0, 4);
            this.tlp_Chinh.Controls.Add(this.tlp_Duoi, 0, 6);
            this.tlp_Chinh.Controls.Add(this.tlp_TongKet, 0, 5);
            this.tlp_Chinh.Controls.Add(this.tlp_Tren, 0, 0);
            this.tlp_Chinh.Dock = System.Windows.Forms.DockStyle.Right;
            this.tlp_Chinh.Location = new System.Drawing.Point(504, 27);
            this.tlp_Chinh.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Chinh.Name = "tlp_Chinh";
            this.tlp_Chinh.RowCount = 7;
            this.tlp_Chinh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlp_Chinh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlp_Chinh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_Chinh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlp_Chinh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Chinh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tlp_Chinh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlp_Chinh.Size = new System.Drawing.Size(664, 578);
            this.tlp_Chinh.TabIndex = 18;
            // 
            // tlp_Duoi
            // 
            this.tlp_Duoi.ColumnCount = 3;
            this.tlp_Duoi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.46444F));
            this.tlp_Duoi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.53556F));
            this.tlp_Duoi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tlp_Duoi.Controls.Add(this.btn_Tao, 0, 0);
            this.tlp_Duoi.Controls.Add(this.btn_Sua, 0, 0);
            this.tlp_Duoi.Controls.Add(this.btn_Xoa, 0, 0);
            this.tlp_Duoi.Dock = System.Windows.Forms.DockStyle.Right;
            this.tlp_Duoi.Location = new System.Drawing.Point(283, 527);
            this.tlp_Duoi.Margin = new System.Windows.Forms.Padding(3, 3, 27, 3);
            this.tlp_Duoi.Name = "tlp_Duoi";
            this.tlp_Duoi.RowCount = 1;
            this.tlp_Duoi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Duoi.Size = new System.Drawing.Size(353, 47);
            this.tlp_Duoi.TabIndex = 19;
            // 
            // btn_Tao
            // 
            this.btn_Tao.BackColor = System.Drawing.Color.Black;
            this.btn_Tao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Tao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Tao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tao.ForeColor = System.Drawing.Color.White;
            this.btn_Tao.Location = new System.Drawing.Point(226, 3);
            this.btn_Tao.Name = "btn_Tao";
            this.btn_Tao.Size = new System.Drawing.Size(124, 41);
            this.btn_Tao.TabIndex = 20;
            this.btn_Tao.Text = "Tạo";
            this.btn_Tao.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Black;
            this.btn_Sua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(118, 3);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(102, 41);
            this.btn_Sua.TabIndex = 19;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Black;
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(3, 3);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(109, 41);
            this.btn_Xoa.TabIndex = 18;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // tlp_TongKet
            // 
            this.tlp_TongKet.ColumnCount = 2;
            this.tlp_TongKet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.27273F));
            this.tlp_TongKet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.72727F));
            this.tlp_TongKet.Controls.Add(this.cb_TinhTrangThanhToan, 1, 1);
            this.tlp_TongKet.Controls.Add(this.lb_TinhTrangThanhToan, 0, 1);
            this.tlp_TongKet.Controls.Add(this.lb_TriGia, 0, 0);
            this.tlp_TongKet.Controls.Add(this.lb_DLTriGia, 1, 0);
            this.tlp_TongKet.Dock = System.Windows.Forms.DockStyle.Right;
            this.tlp_TongKet.Location = new System.Drawing.Point(361, 465);
            this.tlp_TongKet.Margin = new System.Windows.Forms.Padding(27, 9, 27, 3);
            this.tlp_TongKet.Name = "tlp_TongKet";
            this.tlp_TongKet.RowCount = 2;
            this.tlp_TongKet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TongKet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_TongKet.Size = new System.Drawing.Size(275, 55);
            this.tlp_TongKet.TabIndex = 20;
            // 
            // cb_TinhTrangThanhToan
            // 
            this.cb_TinhTrangThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_TinhTrangThanhToan.FormattingEnabled = true;
            this.cb_TinhTrangThanhToan.Items.AddRange(new object[] {
            "Chưa Thanh Toán",
            "Đã Thanh Toán"});
            this.cb_TinhTrangThanhToan.Location = new System.Drawing.Point(144, 28);
            this.cb_TinhTrangThanhToan.Name = "cb_TinhTrangThanhToan";
            this.cb_TinhTrangThanhToan.Size = new System.Drawing.Size(128, 28);
            this.cb_TinhTrangThanhToan.TabIndex = 21;
            this.cb_TinhTrangThanhToan.Text = "Chưa Thanh Toán";
            // 
            // lb_TinhTrangThanhToan
            // 
            this.lb_TinhTrangThanhToan.AutoSize = true;
            this.lb_TinhTrangThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_TinhTrangThanhToan.Location = new System.Drawing.Point(3, 28);
            this.lb_TinhTrangThanhToan.Margin = new System.Windows.Forms.Padding(3);
            this.lb_TinhTrangThanhToan.Name = "lb_TinhTrangThanhToan";
            this.lb_TinhTrangThanhToan.Size = new System.Drawing.Size(135, 24);
            this.lb_TinhTrangThanhToan.TabIndex = 6;
            this.lb_TinhTrangThanhToan.Text = "Tình trạng thanh toán:";
            // 
            // lb_TriGia
            // 
            this.lb_TriGia.AutoSize = true;
            this.lb_TriGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_TriGia.Location = new System.Drawing.Point(3, 3);
            this.lb_TriGia.Margin = new System.Windows.Forms.Padding(3);
            this.lb_TriGia.Name = "lb_TriGia";
            this.lb_TriGia.Size = new System.Drawing.Size(135, 19);
            this.lb_TriGia.TabIndex = 5;
            this.lb_TriGia.Text = "Trị Giá";
            // 
            // lb_DLTriGia
            // 
            this.lb_DLTriGia.AutoSize = true;
            this.lb_DLTriGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DLTriGia.Location = new System.Drawing.Point(144, 3);
            this.lb_DLTriGia.Margin = new System.Windows.Forms.Padding(3);
            this.lb_DLTriGia.Name = "lb_DLTriGia";
            this.lb_DLTriGia.Size = new System.Drawing.Size(128, 19);
            this.lb_DLTriGia.TabIndex = 7;
            this.lb_DLTriGia.Text = "(Trị Giá)";
            this.lb_DLTriGia.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tlp_Tren
            // 
            this.tlp_Tren.ColumnCount = 2;
            this.tlp_Tren.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Tren.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Tren.Controls.Add(this.lb_TieuDe, 0, 0);
            this.tlp_Tren.Controls.Add(this.tlp_MaHD, 1, 0);
            this.tlp_Tren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Tren.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlp_Tren.Location = new System.Drawing.Point(4, 4);
            this.tlp_Tren.Name = "tlp_Tren";
            this.tlp_Tren.RowCount = 1;
            this.tlp_Tren.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Tren.Size = new System.Drawing.Size(656, 47);
            this.tlp_Tren.TabIndex = 21;
            // 
            // lb_TieuDe
            // 
            this.lb_TieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_TieuDe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TieuDe.Location = new System.Drawing.Point(27, 9);
            this.lb_TieuDe.Margin = new System.Windows.Forms.Padding(27, 9, 27, 9);
            this.lb_TieuDe.Name = "lb_TieuDe";
            this.lb_TieuDe.Size = new System.Drawing.Size(274, 29);
            this.lb_TieuDe.TabIndex = 19;
            this.lb_TieuDe.Text = "HÓA ĐƠN THANH TOÁN";
            this.lb_TieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlp_MaHD
            // 
            this.tlp_MaHD.ColumnCount = 2;
            this.tlp_MaHD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.30542F));
            this.tlp_MaHD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.69458F));
            this.tlp_MaHD.Controls.Add(this.pn_NhapMaHD, 0, 0);
            this.tlp_MaHD.Controls.Add(this.lb_MaHD, 0, 0);
            this.tlp_MaHD.Dock = System.Windows.Forms.DockStyle.Right;
            this.tlp_MaHD.Location = new System.Drawing.Point(465, 3);
            this.tlp_MaHD.Name = "tlp_MaHD";
            this.tlp_MaHD.RowCount = 1;
            this.tlp_MaHD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_MaHD.Size = new System.Drawing.Size(188, 41);
            this.tlp_MaHD.TabIndex = 20;
            // 
            // pn_NhapMaHD
            // 
            this.pn_NhapMaHD.AutoSize = true;
            this.pn_NhapMaHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_NhapMaHD.Controls.Add(this.tb_NhapMaHD);
            this.pn_NhapMaHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pn_NhapMaHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_NhapMaHD.Location = new System.Drawing.Point(90, 3);
            this.pn_NhapMaHD.Name = "pn_NhapMaHD";
            this.pn_NhapMaHD.Padding = new System.Windows.Forms.Padding(9);
            this.pn_NhapMaHD.Size = new System.Drawing.Size(95, 35);
            this.pn_NhapMaHD.TabIndex = 6;
            // 
            // tb_NhapMaHD
            // 
            this.tb_NhapMaHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_NhapMaHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_NhapMaHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NhapMaHD.ForeColor = System.Drawing.Color.DimGray;
            this.tb_NhapMaHD.Location = new System.Drawing.Point(9, 9);
            this.tb_NhapMaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_NhapMaHD.Name = "tb_NhapMaHD";
            this.tb_NhapMaHD.Size = new System.Drawing.Size(75, 20);
            this.tb_NhapMaHD.TabIndex = 0;
            this.tb_NhapMaHD.Text = "(Mã Hóa Đơn)";
            // 
            // lb_MaHD
            // 
            this.lb_MaHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_MaHD.Location = new System.Drawing.Point(3, 3);
            this.lb_MaHD.Margin = new System.Windows.Forms.Padding(3);
            this.lb_MaHD.Name = "lb_MaHD";
            this.lb_MaHD.Size = new System.Drawing.Size(81, 35);
            this.lb_MaHD.TabIndex = 5;
            this.lb_MaHD.Text = "Mã Hóa Đơn:";
            this.lb_MaHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_DSHD
            // 
            this.dgv_DSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.TriGia,
            this.TinhTrangThanhToan});
            this.dgv_DSHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DSHD.Location = new System.Drawing.Point(28, 58);
            this.dgv_DSHD.Margin = new System.Windows.Forms.Padding(27, 3, 27, 27);
            this.dgv_DSHD.Name = "dgv_DSHD";
            this.dgv_DSHD.RowHeadersWidth = 51;
            this.dgv_DSHD.RowTemplate.Height = 24;
            this.dgv_DSHD.Size = new System.Drawing.Size(395, 492);
            this.dgv_DSHD.TabIndex = 0;
            // 
            // MaHD
            // 
            this.MaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHD.HeaderText = "Mã Hóa Đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            // 
            // TriGia
            // 
            this.TriGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TriGia.HeaderText = "Trị Giá";
            this.TriGia.MinimumWidth = 6;
            this.TriGia.Name = "TriGia";
            // 
            // TinhTrangThanhToan
            // 
            this.TinhTrangThanhToan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TinhTrangThanhToan.HeaderText = "Tình Trạng Thanh Toán";
            this.TinhTrangThanhToan.MinimumWidth = 6;
            this.TinhTrangThanhToan.Name = "TinhTrangThanhToan";
            // 
            // lb_DSHD
            // 
            this.lb_DSHD.AutoSize = true;
            this.lb_DSHD.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_DSHD.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DSHD.Location = new System.Drawing.Point(28, 10);
            this.lb_DSHD.Margin = new System.Windows.Forms.Padding(27, 9, 9, 9);
            this.lb_DSHD.Name = "lb_DSHD";
            this.lb_DSHD.Size = new System.Drawing.Size(145, 35);
            this.lb_DSHD.TabIndex = 16;
            this.lb_DSHD.Text = "Danh sách hóa đơn";
            this.lb_DSHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlp_DSHD
            // 
            this.tlp_DSHD.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlp_DSHD.ColumnCount = 1;
            this.tlp_DSHD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_DSHD.Controls.Add(this.lb_DSHD, 0, 0);
            this.tlp_DSHD.Controls.Add(this.dgv_DSHD, 0, 1);
            this.tlp_DSHD.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlp_DSHD.Location = new System.Drawing.Point(27, 27);
            this.tlp_DSHD.Name = "tlp_DSHD";
            this.tlp_DSHD.RowCount = 2;
            this.tlp_DSHD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.358752F));
            this.tlp_DSHD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.64125F));
            this.tlp_DSHD.Size = new System.Drawing.Size(451, 578);
            this.tlp_DSHD.TabIndex = 19;
            // 
            // fBillMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1195, 632);
            this.Controls.Add(this.tlp_DSHD);
            this.Controls.Add(this.tlp_Chinh);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fBillMgmt";
            this.Padding = new System.Windows.Forms.Padding(27);
            this.Text = "Quản lý hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietHD)).EndInit();
            this.tlp_ThongTinKH.ResumeLayout(false);
            this.tlp_ThongTinKH.PerformLayout();
            this.tlp_Chinh.ResumeLayout(false);
            this.tlp_Chinh.PerformLayout();
            this.tlp_Duoi.ResumeLayout(false);
            this.tlp_TongKet.ResumeLayout(false);
            this.tlp_TongKet.PerformLayout();
            this.tlp_Tren.ResumeLayout(false);
            this.tlp_MaHD.ResumeLayout(false);
            this.tlp_MaHD.PerformLayout();
            this.pn_NhapMaHD.ResumeLayout(false);
            this.pn_NhapMaHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSHD)).EndInit();
            this.tlp_DSHD.ResumeLayout(false);
            this.tlp_DSHD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_MaKH;
        private System.Windows.Forms.Label lb_TenKH;
        private System.Windows.Forms.DataGridView dgv_ChiTietHD;
        private System.Windows.Forms.TableLayoutPanel tlp_ThongTinKH;
        private System.Windows.Forms.Label lb_CMND;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_DLLoaiKH;
        private System.Windows.Forms.Label lb_DLDiaChi;
        private System.Windows.Forms.Label lb_LoaiKH;
        private System.Windows.Forms.Label lb_ThongTinKH;
        private System.Windows.Forms.Label lb_ChiTietHD;
        private System.Windows.Forms.TableLayoutPanel tlp_Chinh;
        private System.Windows.Forms.DataGridView dgv_DSHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TriGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangThanhToan;
        private System.Windows.Forms.Label lb_DSHD;
        private System.Windows.Forms.TableLayoutPanel tlp_DSHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.ComboBox cb_MaKH;
        private System.Windows.Forms.ComboBox cb_TenKH;
        private System.Windows.Forms.ComboBox cb_CMND;
        private System.Windows.Forms.TableLayoutPanel tlp_Duoi;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Tao;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.TableLayoutPanel tlp_TongKet;
        private System.Windows.Forms.Label lb_TinhTrangThanhToan;
        private System.Windows.Forms.Label lb_TriGia;
        private System.Windows.Forms.Label lb_DLTriGia;
        private System.Windows.Forms.ComboBox cb_TinhTrangThanhToan;
        private System.Windows.Forms.TableLayoutPanel tlp_Tren;
        private System.Windows.Forms.Label lb_TieuDe;
        private System.Windows.Forms.TableLayoutPanel tlp_MaHD;
        private System.Windows.Forms.Label lb_MaHD;
        private System.Windows.Forms.Panel pn_NhapMaHD;
        private System.Windows.Forms.TextBox tb_NhapMaHD;
    }
}