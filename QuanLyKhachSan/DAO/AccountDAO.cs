using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.DAO
{
    public class AccountDAO
    {
        #region Make singleton
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO(); return instance;
            }
            private set { instance = value; }
        }

        private AccountDAO() { }
        #endregion

        public bool Login(string username, string password)
        {
            //string query = "SELECT * FROM dbo.Account WHERE UserName = N'"+ username + "' AND PassWord = N'" + password + "' ";
            string query = "USP_Login @UserName , @PassWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {username, password });

            return result.Rows.Count > 0;
        }

        public List<Account> GetListAccount()
        {
            List<Account> lst = new List<Account>();

            string query = "SELECT * FROM dbo.TAIKHOAN";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Account account = new Account(row);

                lst.Add(account);
            }

            return lst;
        }

        public bool Insert(string userName, string displayName, string password)
        {
            try
            {
                string query = string.Format("INSERT INTO dbo.TAIKHOAN ( TenDangNhap , TenHienThi , MatKhau , LoaiTaiKhoan ) VALUES ( '{0}' , '{1}' , '{2}' , 0 )", userName, displayName, password);

                DataProvider.Instance.ExecuteScalar(query);

                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
