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

        public Account GetUser(string username, string password)
        {
            string query = String.Format("SELECT * FROM dbo.TaiKhoan WHERE TenDangNhap = N'{0}' AND MatKhau = N'{1}'", username, password);

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });

            Account account = new Account(result.Rows[0]);

            return account;
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


        #region Phần thêm xóa sửa Account
        public bool Insert(string userName, string displayName, string password)
        {
            try
            {
                string queryCheck = String.Format("SELECT * FROM dbo.TAIKHOAN WHERE TenDangNhap = '{0}'", userName);
                DataTable tableResual = DataProvider.Instance.ExecuteQuery(queryCheck);
                if (tableResual.Rows.Count > 0)
                {
                    return false;// Kiểm tra nếu đã có người đặt username này thì không thể tạo thêm tài khoản 
                }

                string query = string.Format("INSERT INTO dbo.TAIKHOAN ( TenDangNhap , TenHienThi , MatKhau , LoaiTaiKhoan ) VALUES ( '{0}' , '{1}' , '{2}' , 0 )", userName, displayName, password);

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

        public bool Delete(string userName)
        {
            try
            {
                string query = string.Format("DELETE dbo.TAIKHOAN WHERE TenDangNhap = '{0}' ", userName);

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

        public bool ResetPassword(string userName, string newPassword)
        {
            try
            {
                string query = string.Format("UPDATE dbo.TAIKHOAN SET MatKhau = {0} WHERE MaPhong = {1}", newPassword, userName);

                if(DataProvider.Instance.ExecuteNonQuery(query) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion

    }
}
