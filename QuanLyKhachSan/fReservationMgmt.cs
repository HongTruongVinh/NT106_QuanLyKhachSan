using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan
{
    public partial class fReservationMgmt : Form
    {
        public fReservationMgmt()
        {
            InitializeComponent();
        }

        private void fReservationMgmt_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable RV = RentalVoucherDAO.Instance.getReservations();
            dgv_PhieuThuePhong.DataSource = RV;
            DataTable Bills = BillDAO.Instance.GetBills();
            dgv_HoaDon.DataSource = Bills;
            AddBindings(RV, Bills);
        }

        private void AddBindings(DataTable RV, DataTable Bills)
        {
            tb_MaPhieu.DataBindings.Clear();
            tb_NgayBD.DataBindings.Clear();
            tb_SLKhach.DataBindings.Clear();
            tb_MaPhong.DataBindings.Clear();
            tb_MaKH.DataBindings.Clear();
            tb_SoNgayThue.DataBindings.Clear();
            tb_ThanhTien.DataBindings.Clear();
            dtp_NgayThanhToan.DataBindings.Clear();

            tb_MaPhieu.DataBindings.Add(new Binding("Text", RV, "Mã phiếu"));
            tb_NgayBD.DataBindings.Add(new Binding("Text", RV, "Ngày bắt đầu"));
            tb_SLKhach.DataBindings.Add(new Binding("Text", RV, "Số lượng khách"));
            tb_MaPhong.DataBindings.Add(new Binding("Text", RV, "Mã phòng"));
            tb_MaKH.DataBindings.Add(new Binding("Text", RV, "Mã khách hàng"));

            tb_SoNgayThue.DataBindings.Add(new Binding("Text", Bills, "Số ngày thuê"));
            tb_ThanhTien.DataBindings.Add(new Binding("Text", Bills, "Thành tiền"));
            dtp_NgayThanhToan.DataBindings.Add(new Binding("Value", Bills, "Ngày thanh toán"));
        }

        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {
            if (tb_SoNgayThue.TextLength == 0 || tb_ThanhTien.TextLength == 0)
            {
                MessageBox.Show("Bạn cần điền Số ngày thuê, Thành tiền, Ngày thanh toán để tạo hóa đơn");
                return;
            }
            int MaKH = int.Parse(tb_MaKH.Text);
            int MaPhong = int.Parse(tb_MaPhong.Text);
            int SoNgayThue = int.Parse(tb_SoNgayThue.Text);
            int ThanhTien = int.Parse(tb_ThanhTien.Text);
            string NgayThanhToan = dtp_NgayThanhToan.Value.ToString("yyyy/MM/dd");
            int DonGia = ThanhTien * SoNgayThue;

            if (BillDAO.Instance.CreateBill(MaKH, MaPhong, SoNgayThue, ThanhTien, NgayThanhToan, DonGia))
            {
                MessageBox.Show("Tạo hóa đơn thành công");

                LoadData();
            }
        }

        private void btn_SuaHoaDon_Click(object sender, EventArgs e)
        {
            int MaHD = (int)dgv_HoaDon.CurrentRow.Cells["Mã hóa đơn"].Value;
            int MaKH = int.Parse(tb_MaKH.Text);
            int MaPhong = int.Parse(tb_MaPhong.Text);
            int SoNgayThue = int.Parse(tb_SoNgayThue.Text);
            int ThanhTien = int.Parse(tb_ThanhTien.Text);
            string NgayThanhToan = dtp_NgayThanhToan.Value.ToString("yyyy/MM/dd");
            int DonGia = ThanhTien * SoNgayThue;

            if (BillDAO.Instance.UpdateBill(MaHD, MaKH, MaPhong, SoNgayThue, ThanhTien, NgayThanhToan, DonGia))
            {
                MessageBox.Show("Sửa hóa đơn thành công");
                LoadData();
            }
        }

        private void btn_XoaHoaDon_Click(object sender, EventArgs e)
        {
            int MaHD = (int)dgv_HoaDon.CurrentRow.Cells["Mã hóa đơn"].Value;
            if (BillDAO.Instance.DeleteBill(MaHD))
            {
                MessageBox.Show("Xóa hóa đơn thành công");
                LoadData();
            }
        }
    }
}
