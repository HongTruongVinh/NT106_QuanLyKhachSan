using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.DAO
{
    public class BillDAO
    {
        #region Make singleton
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get
            {
                if (instance == null) instance = new BillDAO(); return instance;
            }
            private set { instance = value; }
        }

        private BillDAO() { }
        #endregion

        //public int GetUncheckBillIDByRoomID(int id)
        //{
        //    string query = "SELECT * FROM dbo.HOADON, dbo.PHONG WHERE HOADON.MaHD = PHONG.MaHD AND MaHD = " + id + " AND TinhTrang = 0";

        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);

        //    if (data.Rows.Count > 0)    
        //    {
        //        Bill bill = new Bill(data.Rows[0]);
        //        return bill.ID; // lấy đc bill id thì return 
        //    }

        //    return -1;// lấy bill id thất bại thì -1 
        //}

        //Chua tao USP_GetListBillByDate trong database

        public DataTable TurnoverByYear(int year)
        {
            string query = "EXEC USP_GetListBillByYear @year";
            return (DataTable)DataProvider.Instance.ExecuteQuery(query, new object[] { year });
        }

        public object GetAmountBillMoney(int year)
        {
            string query = string.Format("SELECT SUM(ThanhTien) FROM HOADON WHERE YEAR(NgayThanhToan) = {0}", year);
            return DataProvider.Instance.ExecuteScalar(query);
        }

        public DataTable GetChartByYear(int year)
        {
            string query = string.Format("EXEC USP_GetListBillByYear @year");
            return (DataTable)DataProvider.Instance.ExecuteQuery(query, new object[] { year });
        }

        public DataTable GetUnCheckedBillsByGuestInfo(string name, string personalID)
        {
            string query = $@"
                SELECT MaHD, MaPhong, SoNgayThue, ThanhTien, NgayThanhToan, DonGia, TrangThai
                FROM HOADON, KHACHHANG
                WHERE TrangThai = 0
                AND HOADON.MaKH = KHACHHANG.MaKH
                AND KHACHHANG.TenKhachHang = N'{name}'
                AND KHACHHANG.CMND = '{personalID}'
            ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool PayBillByID(int id)
        {
            string query = $@"
                UPDATE HOADON
                SET TrangThai = 1
                WHERE MaHD = {id}
            ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool CreateBill(int MaKH, int MaPhong, int SoNgayThue, int ThanhTien, string NgayThanhToan, int DonGia)
        {
            string query = $@"
                INSERT INTO HOADON (MaKH, MaPhong, SoNgayThue, ThanhTien, NgayThanhToan, DonGia)
                VALUES ({MaKH}, {MaPhong}, {SoNgayThue}, {ThanhTien}, '{NgayThanhToan}', {DonGia});
            ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            if(result > 0)
            {
                NoticeDAO.Instance.NoticeOrderRoomSuccess(MaKH);
            }

            return result > 0;
        }

        public DataTable GetBills()
        {
            string query = $@"
                SELECT MaHD AS 'Mã hóa đơn', MaPhong AS 'Mã phòng', SoNgayThue AS 'Số ngày thuê', ThanhTien AS 'Thành tiền', NgayThanhToan as 'Ngày thanh toán', DonGia as 'Đơn giá', TrangThai as 'Trạng thái'
                FROM HOADON
            ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool DeleteBill(int MaHD)
        {
            string query = $@"
                DELETE FROM HOADON
                WHERE MaHD = {MaHD}
            ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateBill(int MaHD, int MaKH, int MaPhong, int SoNgayThue, int ThanhTien, string NgayThanhToan, int DonGia)
        {
            string query = $@"
                UPDATE HOADON
                SET MaKH={MaKH}, MaPhong={MaPhong}, SoNgayThue={SoNgayThue}, ThanhTien={ThanhTien}, NgayThanhToan='{NgayThanhToan}', DonGia={DonGia}
                WHERE MaHD={MaHD}
            ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
