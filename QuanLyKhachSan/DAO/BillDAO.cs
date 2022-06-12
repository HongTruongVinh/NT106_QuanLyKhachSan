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
    }
}
