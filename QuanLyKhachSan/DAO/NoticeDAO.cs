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
                string toDay = string.Format("{0}/{1}/{2}", DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Year);

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

        public bool NoticeOrderRoomSuccess(int idClient)
        {
            try
            {
                string subject = "Thong bao ket qua dat phong.";
                string content = "Khach san ABC thong bao ban da dat phong thanh cong!\n" +
                                 "Xin cam on ban da dat phong cua chung toi.\n";

                Client client = ClientDAO.Instance.GetClientByID(idClient);

                bool resual = false;

                if (client != null)
                {
                    resual = Insert(client.IDPerson.ToString(), subject, content);
                }

                return resual;
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


        public bool DeleteByUsername(string username)
        {
            string query1 = string.Format("SELECT * FROM THONGBAO WHERE TenDangNhap = N'{0}'", username);
            int success1 = DataProvider.Instance.ExecuteNonQuery(query1);
            if(success1 > 0)
            {
                string query = string.Format("DELETE dbo.THONGBAO WHERE TenDangNhap = '{0}'", username);

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
            return true;
        }

        #region fGuestMgmt + fAdmin(TaiKhoan)
        public bool DeleteNotificationGuest(string cmnd)
        {
            string query = string.Format("DELETE FROM THONGBAO WHERE TenDangNhap = N'{0}'", cmnd);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion
    }
}
