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
            string query = "SELECT MaPhieu id, MaPhong roomID, MaKH ClientID, NgayBatDau dateTimeCheckIn, NgayKetThuc dateTimeCheckOut, SoLuongKhach numberPeople "
                            + "FROM dbo.PHIEUTHUEPHONG WHERE MaPhong = '" + id +"'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                RentalVoucher rentalVoucher = new RentalVoucher(data.Rows[0]);
                return rentalVoucher;
            }

            return null;
        }
    }
}
