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

        public BillDetails GetBillDetailsByBillID(int billID)
        {
            string query = $@"
                SELECT *
                FROM CHITIETHOADON
                WHERE MaHD = {billID}
            ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            BillDetails billDetails = new BillDetails(data.Rows[0]);
            return billDetails;
        }

        public bool PayBillByBillID(int billID)
        {
            string query = $@"
                UPDATE CHITIETHOADON
                SET TrangThai = 1
                WHERE MaHD = {billID}
            ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
