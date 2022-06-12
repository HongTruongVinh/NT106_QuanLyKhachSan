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
    public class RentalVoucherDAO
    {
        #region Tạo singleton
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
        #endregion


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
            string query = string.Format("GetUnCheckRentalVoucherByRoomID {0}", id);

            DataTable data = (DataTable)FormatData.Instance.DeserializeData(TCPClient.Instance.GetDataFromCommand(query));

            if (data == null) return null;

            if (data.Rows.Count > 0)
            {
                RentalVoucher rentalVoucher = new RentalVoucher(data.Rows[0]);
                return rentalVoucher;
            }

            return null;
        }

        public DataTable ListRentalVoucherUnCheckOut()
        {
            string query = "SELECT ptp.MaKH clientID, p.MaPhong roomID, TenPhong roomName, TenKhachHang nameClient, SDT numberPhone, DiaChi adsress, CMND, lkh.MaLoaiKH typeClient, SoLuongKhach  FROM dbo.PHIEUTHUEPHONG ptp, dbo.PHONG p, dbo.KHACHHANG kh, dbo.LOAIKHACHHANG lkh WHERE p.TinhTrang = 1 AND ptp.MaPhong = p.MaPhong AND ptp.MaKH = kh.MaKH AND ptp.MaLoaiKH = lkh.MaLoaiKH";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable ListRentalVoucherUnCheckOut(string TiengViet)
        {
            string query = string.Format("GetListRentalVoucherUnCheckOut");

            DataTable data = (DataTable)FormatData.Instance.DeserializeData(TCPClient.Instance.GetDataFromCommand(query));

            return data;
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

        public bool UpdateRentalVoucher(int idRentalVoucher, int idTypeClient,int countPeople, Client client)
        {
            try
            {
                ClientDAO.Instance.UpdateLient(client.ID, client.Name, client.IDPerson, client.NumberPhone, client.Address);

                string query = string.Format("UPDATE dbo.PHIEUTHUEPHONG SET SoLuongKhach = {0}, MaLoaiKH = {1} WHERE MaPhieu = {2}",countPeople, idTypeClient, idRentalVoucher);

                DataProvider.Instance.ExecuteNonQuery(query);

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

        #region Ngay 11/06
        public bool InserRentalVoucherFromClient(int idRoom, int countPeople, int typeClient, string name, string idPerson, string numberphone, string address)
        {
            try
            {
                byte[] bytes = TCPClient.Instance.GetDataFromCommand(string.Format("OrderRoom {0} {1} {2} {3} {4} {5} {6}", idRoom, countPeople, typeClient, name, numberphone, idPerson, address));

                string message = Encoding.UTF8.GetString(bytes);

                string[] strings = message.Split(' ', '\0');

                if (strings[0] == "OderRoomSuccessfully")
                {
                    return true;
                }

                if (strings[0] == "OderRoomFail")
                {
                    return false;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Ngay 12/06
        public bool ClientDeleteRoomOrdered(string username, string idRoom)
        {
            try
            {
                string query = string.Format("DeleteRoomOrdered {0} {1}", username, idRoom);

                byte[] bytes = TCPClient.Instance.GetDataFromCommand(query);

                string message = Encoding.UTF8.GetString(bytes);

                string[] strings = message.Split(' ', '\0');

                if (strings[0] == "success")
                {
                    return true;
                }

                if (strings[0] == "fail")
                {
                    return false;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
