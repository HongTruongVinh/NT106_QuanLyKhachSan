using QuanLyKhachSan.DAO;
using QuanLyKhachSan.Network;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class MessageDAO
    {
        #region Make singleton
        private static MessageDAO instance;
        public static MessageDAO Instance
        {
            get
            {
                if (instance == null) instance = new MessageDAO(); return instance;
            }
            private set { instance = value; }
        }

        private MessageDAO() { }
        #endregion

        public DataTable TableMessage(string clientUsername, string employeeUsername = "_")
        {
            DataTable data;

            string query = "";

            if(employeeUsername == "_")
            {
                query = string.Format("SELECT * FROM TINNHAN WHERE UserNameKhachHang = '{1}'", employeeUsername, clientUsername);
            }
            else
            {
                query = string.Format("SELECT * FROM TINNHAN WHERE UserNameNhanVien = '{0}' AND UserNameKhachHang = '{1}'", employeeUsername, clientUsername);
            }

            data = DataProvider.Instance.ExecuteQuery(query); 

            return data;
        }

        public bool SendMessage(string employeeUsername, string clientUsername, string msg)
        {
            try
            {
                
                if(employeeUsername == "_")
                {
                    int index = 1;
                    string queryGetEmployee = string.Format("SELECT * FROM dbo.TAIKHOAN WHERE LoaiTaiKhoan = 0");
                    DataTable data = DataProvider.Instance.ExecuteQuery(queryGetEmployee);
                    
                    Random rand = new Random();
                    index = rand.Next(data.Rows.Count);
                    employeeUsername = data.Rows[index]["TenDangNhap"].ToString();
                }

                string query = string.Format("INSERT INTO dbo.TINNHAN (UserNameNhanVien, UserNameKhachHang, NoiDung) VALUES ('{0}' , '{1}' , '{2}')", employeeUsername, clientUsername, msg);

                if (DataProvider.Instance.ExecuteNonQuery(query) > 0)
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

        #region fGuestMgmt + fAdmin (TaiKhoan)
        public bool DeleteMessageGuest(string cmnd)
        {
            string query1 = string.Format("SELECT * FROM TINNHAN WHERE UserNameKhachHang = N'{0}'", cmnd);
            int result1 = DataProvider.Instance.ExecuteNonQuery(query1);
            if(result1 > 0)
            {
                string query = string.Format("DELETE FROM TINNHAN WHERE UserNameKhachHang = N'{0}'", cmnd);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            return true;
        }

        public bool DeleteMessageStaff(string TenDangNhap)
        {
            string query1 = string.Format("SELECT * FROM TINNHAN WHERE UserNameNhanVien = N'{0}'", TenDangNhap);
            int result1 = DataProvider.Instance.ExecuteNonQuery(query1);
            if (result1 > 0)
            {
                string query = string.Format("DELETE FROM TINNHAN WHERE UserNameNhanVien = N'{0}'", TenDangNhap);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            return true;
        }
        #endregion
    }
}
