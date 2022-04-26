using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.DAO
{
    public class RentalVoucherDAO
    {
        private static RentalVoucherDAO instance;
        public static RentalVoucherDAO Instance
        {
            get
            {
                if (instance == null) instance = new RentalVoucherDAO(); return instance;
            }
            private set { instance = value; }
        }

        private RentalVoucherDAO() { }

        #region các hàm Load dữ liệu
        /// <summary>
        /// trả về ID của phiếu thuê phòng dựa vào ID của phòng nếu phòng có người NẾU thất bại trả về -1
        /// </summary>
        /// <returns></returns>
        public int GetUnCheckRentalVoucherIDByRoomID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.PHIEUTHUEPHONG WHERE MaPhong = '"+ id +"'");

            if (data.Rows.Count > 0)
            {
                RentalVoucher rentalVoucher = new RentalVoucher(data.Rows[0]);
                return rentalVoucher.ID;
            }

            return -1;
        }

        public RentalVoucher GetUnCheckRentalVoucherByRoomID(int id)
        {
            string query = "SELECT MaPhieu id, MaPhong roomID, ptp.MaKH clientID, NgayBatDau dateTimeCheckIn, NgayKetThuc dateTimeCheckOut, SoLuongKhach countPeople , TenLoaiKH typeCLient, HeSoPhuThu dependencyFactor"
                            + " FROM dbo.PHIEUTHUEPHONG ptp, dbo.LOAIKHACHHANG lkh WHERE ptp.MaLoaiKH = lkh.MaLoaiKH AND  MaPhong = '" + id +"'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                RentalVoucher rentalVoucher = new RentalVoucher(data.Rows[0]);
                return rentalVoucher;
            }

            return null;
        }

        #endregion

        #region các hàm Insert dữ liệu
        public bool InsertRentalVoucher(int idRoom, int idClient, int idTypeClient, int countPeople)
        {
            
            try
            {
                DataProvider.Instance.ExecuteNonQuery("USP_InsertRentalVoucher @idRoom , @idClient , @MaLoaiKH , @countPeople", new object[] { idRoom, idClient, idTypeClient, countPeople });

                return true;
            }
            catch
            {
                return false;
            }
        }

        //hàm Delete
        public bool DeleteRentalVoucher(int idRentalVoucher, int idClient)
        {
            try
            {
                string query = "DELETE dbo.PHIEUTHUEPHONG WHERE MaPhieu = " + idRentalVoucher +" AND MaKH =" + idClient;

                DataProvider.Instance.ExecuteNonQuery(query);

                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
