using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_CLient.DTO;
using QuanLyKhachSan_CLient.Network;

namespace QuanLyKhachSan_CLient.DAO
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
        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @checkIn, @checkOut", new object[] { checkIn, checkOut });
        }

        #region fListRentalVoucher
        public DataTable GetBills()
        {
            string query = string.Format("GetBills");

            DataTable data = (DataTable)FormatData.Instance.DeserializeData(TCPClient.Instance.GetDataFromCommand(query));

            return data;
        }

        public bool CreateBill(int MaKH, int MaPhong, int SoNgayThue, int ThanhTien, string NgayThanhToan, int DonGia)
        {
            string query = string.Format("CreateBill {0} {1} {2} {3} {4} {5}", MaKH, MaPhong, SoNgayThue, ThanhTien, NgayThanhToan, DonGia);

            byte[] bytes = TCPClient.Instance.GetDataFromCommand(query);

            string msg = Encoding.UTF8.GetString(bytes);

            string[] message = msg.Split(' ', '\0');

            if (message[0] == "success")
            {
                return true;
            }

            return false;
        }

        public bool UpdateBill(int MaHD, int MaKH, int MaPhong, int SoNgayThue, int ThanhTien, string NgayThanhToan, int DonGia)
        {
            string query = string.Format("UpdateBill {0} {1} {2} {3} {4} {5} {6}", MaHD, MaKH, MaPhong, SoNgayThue, ThanhTien, NgayThanhToan, DonGia);

            byte[] bytes = TCPClient.Instance.GetDataFromCommand(query);

            string msg = Encoding.UTF8.GetString(bytes);

            string[] message = msg.Split(' ', '\0');

            if (message[0] == "success")
            {
                return true;
            }

            return false;
        }

        public bool DeleteBill(int MaHD)
        {
            string query = string.Format("DeleteBill {0}", MaHD);

            byte[] bytes = TCPClient.Instance.GetDataFromCommand(query);

            string msg = Encoding.UTF8.GetString(bytes);

            string[] message = msg.Split(' ', '\0');

            if (message[0] == "success")
            {
                return true;
            }

            return false;
        }

        public bool PayBillByID(int id)
        {
            //string query = $@"
            //    UPDATE HOADON
            //    SET TrangThai = 1
            //    WHERE MaHD = {id}
            //";
            //int result = DataProvider.Instance.ExecuteNonQuery(query);
            //return result > 0;

            string query = string.Format("PayBillByID {0}", id);

            byte[] bytes = TCPClient.Instance.GetDataFromCommand(query);

            string msg = Encoding.UTF8.GetString(bytes);

            string[] message = msg.Split(' ', '\0');

            if (message[0] == "success")
            {
                return true;
            }

            return false;
        }

        // XỬ LÝ FORM fGuestMgnt
        public bool DeleteBillByMaKH(int id)
        {
            string query = string.Format("DeleteBillByMaKH {0}", id);

            byte[] bytes = TCPClient.Instance.GetDataFromCommand(query);

            string msg = Encoding.UTF8.GetString(bytes);

            string[] message = msg.Split(' ', '\0');

            if (message[0] == "success")
            {
                return true;
            }

            return false;
        }
        #endregion
    }
}
