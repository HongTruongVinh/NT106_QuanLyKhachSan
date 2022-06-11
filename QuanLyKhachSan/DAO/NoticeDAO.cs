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
            string query = "SELECT NgayThongBao, TenDangNhap, TieuDe, NoiDung, MaThongBao FROM dbo.THONGBAO";
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
            string query = string.Format("SELECT NgayThongBao, TieuDe, NoiDung, MaThongBao FROM dbo.THONGBAO WHERE TenDangNhap = '{0}'", username);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool Insert(string username, string subject = "", string content = "")
        {
            try
            {
                string toDay = string.Format("{0}/{1}/{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);

                string query = string.Format("INSERT INTO dbo.THONGBAO ( TenDangNhap , TieuDe , NoiDung, NgayThongBao) VALUES ( '{0}' , '{1}' , '{2}', '{3}')", username, subject, content, toDay);

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
                string query = string.Format("INSERT INTO dbo.THONGBAO ( TenDangNhap , TieuDe , NoiDung , NgayThongBao ) VALUES ( '{0}' , '{1}' , '{2}')", listAccount[i].UserName, subject, content, DateTime.Now);

                int done = DataProvider.Instance.ExecuteNonQuery(query);

                if (done > 0)
                {
                    success++;// Them thanh cong
                }
            }

            return success;
        }

        public bool DeleteByID(int id)
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

        public bool DeleteBySubjectAndContent(string subject, string content)
        {
            try
            {
                string query = string.Format("DELETE dbo.THONGBAO WHERE TieuDe = '{0}' AND NoiDung = '{1}'", subject, content);

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

        #region Ngay10/06
        public int InsertForListAcount(List<string> listAccountReciever, string subject = "", string content = "")
        {
            int success = 0;

            foreach (var item in listAccountReciever)
            {
                try
                {
                    if (Insert(item, subject, content))
                    {
                        success++;
                    }
                }
                catch
                {

                }
            }

            return success;
        }
        #endregion

    }
}
