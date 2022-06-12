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

        public void Create()
        {
            string query = "SELECT * FROM dbo.THAMSO WHERE ID = 1";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            DataRow row = data.Rows[0];

            SoKhachToiDa = (int)row["KhachToiDa"];

            DonGiaPhongCho = (int)row["DonGiaPhongCho"];

            double phuThuTuKhach = (double)row["PhuThuTuKhach"];
            PhuThuTuKhach = float.Parse(phuThuTuKhach.ToString());
        }

        private int soKhachToiDa;
        private int donGiaPhongCho;
        private float phuThuTuKhach;

        public int SoKhachToiDa { get => soKhachToiDa; set => soKhachToiDa = value; }
        public int DonGiaPhongCho { get => donGiaPhongCho; set => donGiaPhongCho = value; }
        public float PhuThuTuKhach { get => phuThuTuKhach; set => phuThuTuKhach = value; }


        public DataTable GetListParameter()
        {
            string query = "SELECT * FROM THAMSO";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool Update_KhachToiDa(int KhachToiDa)
        {
            string query = string.Format("UPDATE dbo.THAMSO SET KhachToiDa = {0}", KhachToiDa);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool Update_DonGiaPhongCho(int DonGiaPhongCho)
        {
            string query = string.Format("UPDATE dbo.THAMSO SET DonGiaPhongCho = {0}", DonGiaPhongCho);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool Update_PhuThuTuKhach(float PhuThuTuKhach)
        {
            string query = string.Format("UPDATE dbo.THAMSO SET PhuThuTuKhach = {0}", PhuThuTuKhach);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool Update_PhuThuTuKhachNuocNgoai(float PhuThuTuKhachNuocNgoai)
        {
            string query = string.Format("UPDATE dbo.THAMSO SET PhuThuTuKhachNuocNgoai = {0}", PhuThuTuKhachNuocNgoai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
