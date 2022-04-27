using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class RegulationDAO
    {
        #region Make singleton
        private static RegulationDAO instance;
        public static RegulationDAO Instance
        {
            get
            {
                if (instance == null) instance = new RegulationDAO(); return instance;
            }
            private set { instance = value; }
        }

        private RegulationDAO() { }
        #endregion

        public int GetMaxCountPeople()
        {
            int max = 0;

            string query = "SELECT * FROM dbo.THAMSO WHERE ID = 1";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            DataRow row = data.Rows[0];

            max = (int)row["KhachToiDa"];

            return max;
        }
    }
}
