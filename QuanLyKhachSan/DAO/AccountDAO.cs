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

        public bool Login(string username, string passwordBeMD5)
        {
            //string query = "SELECT * FROM dbo.Account WHERE UserName = N'"+ username + "' AND PassWord = N'" + password + "' ";
            string query = "USP_Login @UserName , @PassWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {username, passwordBeMD5 });

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
        public bool Insert(string userName, string displayName, string passwordBeMD5)
        {
            try
            {
                string queryCheck = String.Format("SELECT * FROM dbo.TAIKHOAN WHERE TenDangNhap = '{0}'", userName);
                DataTable tableResual = DataProvider.Instance.ExecuteQuery(queryCheck);
                if (tableResual.Rows.Count > 0)
                {
                    return false;// Kiểm tra nếu đã có người đặt username này thì không thể tạo thêm tài khoản 
                }

                string query = string.Format("INSERT INTO dbo.TAIKHOAN ( TenDangNhap , TenHienThi , MatKhau , LoaiTaiKhoan ) VALUES ( '{0}' , '{1}' , '{2}' , 0 )", userName, displayName, passwordBeMD5);

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

        public bool DeleteAccEmployee(string userName)
        {
            try
            {
                // Xóa thông báo chứa username này trước
                bool deleteNotice = NoticeDAO.Instance.DeleteByUsername(userName);
                bool deleteMess = MessageDAO.Instance.DeleteMessageStaff(userName);
                if (!deleteNotice && !deleteMess) return false;

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

        public int DeleteListAccEmployee(List<string> listAccEmployee)
        {
            int success = 0;

            foreach (var item in listAccEmployee)
            {
                try
                {
                    if (DeleteAccEmployee(item))
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

        public bool DeleteAccClient(string userName)
        {
            if (IsAccountExist(userName))
            {
                // Xóa thông báo chứa username này trước
                bool deleteNotice = NoticeDAO.Instance.DeleteByUsername(userName);
                bool deleteMess = MessageDAO.Instance.DeleteMessageGuest(userName);
                if (!deleteNotice && !deleteMess) return false;

                //xóa TK đăng nhập 
                string query = string.Format("DELETE FROM dbo.TAIKHOAN WHERE TenDangNhap = '{0}' ", userName);

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

            return false;
        }

        public int DeleteListAccClient(List<string> listAccClient)
        {
            int success = 0;

            foreach (var item in listAccClient)
            {
                try
                {
                    if (DeleteAccClient(item))
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

        public bool ResetPassword(string userName, string newPasswordBeMD5)
        {
            try
            {
                string query = string.Format("UPDATE dbo.TAIKHOAN SET MatKhau = '{0}' WHERE TenDangNhap = '{1}'", newPasswordBeMD5, userName);

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

        public bool IsExistNumberPhone(string numberphone)
        {
            string queryCheck = String.Format("SELECT * FROM dbo.KHACHHANG WHERE SDT = '{0}'", numberphone);
            DataTable tableResual = DataProvider.Instance.ExecuteQuery(queryCheck);
            if (tableResual.Rows.Count > 0)
            {
                return true;// Đã có người sử dụng SDT này 
            }


            queryCheck = String.Format("SELECT * FROM dbo.TAIKHOAN WHERE TenDangNhap = '{0}'", numberphone);
            tableResual = DataProvider.Instance.ExecuteQuery(queryCheck);
            if (tableResual.Rows.Count > 0)
            {
                return true;// Đã có người sử dụng SDT này để làm tài khoản đăng nhập
            }

            return false;
        }

        public bool IsExistIDPerson(string iDPerson)
        {
            string queryCheck = String.Format("SELECT * FROM dbo.KHACHHANG WHERE CMND = '{0}'", iDPerson);
            DataTable tableResual = DataProvider.Instance.ExecuteQuery(queryCheck);
            if (tableResual.Rows.Count > 0)
            {
                return true;// Đã có người sử dụng SDT này 
            }

            return false;
        }

        public bool InsertAccountCLient(string userName, string displayName, string password)
        {
            try
            {
                string query = string.Format("INSERT INTO dbo.TAIKHOAN ( TenDangNhap , TenHienThi , MatKhau , LoaiTaiKhoan ) VALUES ( '{0}' , '{1}' , '{2}' , 3 )", userName, displayName, password);

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

        #region Ngay06/10
        public DataTable GetListAccountEmployee()
        {
            string query = "SELECT TenHienThi, TenDangNhap FROM dbo.TAIKHOAN WHERE LoaiTaiKhoan = 0";
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("BooleanValue", typeof(bool)));
            table.Merge(DataProvider.Instance.ExecuteQuery(query));
            return table;
        }

        public DataTable GetListAccountClient()
        {
            string query = "SELECT TenHienThi, TenDangNhap FROM dbo.TAIKHOAN WHERE LoaiTaiKhoan = 3";
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("BooleanValue", typeof(bool)));
            table.Merge(DataProvider.Instance.ExecuteQuery(query));
            return table;
        }

        public DataTable LoadListEmployee()
        {
            string query = "SELECT TenHienThi 'Tên', TenDangNhap FROM dbo.TAIKHOAN WHERE LoaiTaiKhoan = 0";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            return table;
        }
        #endregion

        public bool changeInforAccountAdmin(string username, string displayName, string newPasswordBeMD5)
        {
            string query = string.Format("UPDATE dbo.TAIKHOAN SET MatKhau = '{0}', TenHienThi = '{1}'  WHERE TenDangNhap = '{2}'", newPasswordBeMD5,displayName, username);

            int success = DataProvider.Instance.ExecuteNonQuery(query);

            return success > 0;
        }

        #region fGuestMngmt(Client)
        public bool IsAccountExist(string cmnd)
        {
            string query = string.Format("SELECT * FROM TAIKHOAN WHERE TenDangNhap = N'{0}'", cmnd);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        #endregion
    }
}
