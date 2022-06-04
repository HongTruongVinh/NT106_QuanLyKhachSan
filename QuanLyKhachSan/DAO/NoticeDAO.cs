using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class NoticeDAO
    {
        #region Make singleton
        private static NoticeDAO instance;
        public static NoticeDAO Instance
        {
            get
            {
                if (instance == null) instance = new NoticeDAO(); return instance;
            }
            private set { instance = value; }
        }

        private NoticeDAO() { }
        #endregion

        public DataTable GetDataTableNotice()
        {
            string query = "SELECT * FROM dbo.THONGBAO";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public List<Notice> GetListNotice()
        {
            List<Notice> list = new List<Notice>();

            DataTable data = GetDataTableNotice();

            foreach (DataRow row in data.Rows)
            {
                Notice account = new Notice(row);

                list.Add(account);
            }

            return list;
        }

        public DataTable GetListNoticeFromUsername(string username)
        {
            string query = string.Format("SELECT * FROM dbo.THONGBAO WHERE TenDangNhap = '{0}'", username);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool Insert(string username, string subject = "", string content = "")
        {
            try
            {
                string query = string.Format("INSERT INTO dbo.THONGBAO ( TenDangNhap , TieuDe , NoiDung) VALUES ( '{0}' , '{1}' , '{2}')", username, subject, content);

                int success = DataProvider.Instance.ExecuteNonQuery(query);

                if (success > 0)
                {
                    return true;// Them thanh cong
                }
                else
                {
                    return false;// Them khong thanh cong
                }

            }
            catch
            {
                return false;
            }
        }

        public int InsertForAllAccount(string subject = "", string content = "")
        {
            int success = 0;

            List<Account> listAccount = AccountDAO.Instance.GetListAccount();

            for (int i = 0; i < listAccount.Count; i++)
            {
                string query = string.Format("INSERT INTO dbo.THONGBAO ( TenDangNhap , TieuDe , NoiDung) VALUES ( '{0}' , '{1}' , '{2}')", listAccount[i].UserName, subject, content);

                int done = DataProvider.Instance.ExecuteNonQuery(query);

                if (done > 0)
                {
                    success++;// Them thanh cong
                }
            }

            return success;
        }

        public bool Delete(int id)
        {
            try
            {
                string query = string.Format("DELETE dbo.THONGBAO WHERE MaThongBao = '{0}' ", id);

                int success = DataProvider.Instance.ExecuteNonQuery(query);

                if (success > 0)
                {
                    return true;//Xoa thanh cong
                }
                else
                {
                    return false;//Xoa khong thanh cong
                }

            }
            catch
            {
                return false;
            }
        }

    }
}
