using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.DAO
{
    internal class BillDetailsDAO
    {
        #region Singleton
        private static BillDetailsDAO _instance;
        public static BillDetailsDAO Instance
        {
            get { if (_instance == null) _instance = new BillDetailsDAO(); return _instance; }
            set { _instance = value; }
        }
        private BillDetailsDAO() { }
        #endregion

        public DataTable GetUnCheckedBillsByGuestInfo(string name, string personalID)
        {
            string query = $@"
                SELECT CHITIETHOADON.MaHD, MaPhong, SoNgayThue, ThanhTien, NgayThanhToan, DonGia, TrangThai
                FROM CHITIETHOADON, HOADON, KHACHHANG
                WHERE TrangThai = 0
                AND CHITIETHOADON.MaHD = HOADON.MaHD
                AND HOADON.MaKH = KHACHHANG.MaKH
                AND KHACHHANG.TenKhachHang = N'{name}'
                AND KHACHHANG.CMND = '{personalID}'
            ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool PayBillDetailsByID(int id)
        {
            string query = $@"
                UPDATE CHITIETHOADON
                SET TrangThai = 1
                WHERE MaCTHD = {id}
            ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
