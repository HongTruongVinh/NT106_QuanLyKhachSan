using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSan_CLient.DTO;
using QuanLyKhachSan_CLient.Network;

namespace QuanLyKhachSan_CLient.DAO
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
            //string query = $@"
            //    SELECT CHITIETHOADON.MaHD, MaPhong, SoNgayThue, ThanhTien, NgayThanhToan, DonGia, TrangThai
            //    FROM CHITIETHOADON, HOADON, KHACHHANG
            //    WHERE TrangThai = 0
            //    AND CHITIETHOADON.MaHD = HOADON.MaHD
            //    AND HOADON.MaKH = KHACHHANG.MaKH
            //    AND KHACHHANG.TenKhachHang = N'{name}'
            //    AND KHACHHANG.CMND = '{personalID}'
            //";
            //DataTable data = DataProvider.Instance.ExecuteQuery(query);

            string query = string.Format("GetUnCheckedBillsByGuestInfo _{0}_{1}", name, personalID);

            DataTable data = (DataTable)FormatData.Instance.DeserializeData(TCPClient.Instance.GetDataFromCommand(query));

            return data;
        }

        public bool PayBillDetailsByID(int id)
        {
            string query = string.Format("PayBillDetailsByID {0}", id);

            byte[] bytes = TCPClient.Instance.GetDataFromCommand(query);

            string msg = Encoding.UTF8.GetString(bytes);

            string[] message = msg.Split(' ', '\0');

            if (message[0] == "success")
            {
                return true;
            }

            return false;
        }
    }
}
