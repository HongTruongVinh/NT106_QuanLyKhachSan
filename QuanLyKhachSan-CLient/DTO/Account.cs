using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan_CLient.DTO
{
    public class Account
    {
        public Account(string username, string displayname, string password)
        {
            this.Password = password;
            this.DisplayName = displayname;
            this.UserName = username;
        }

        public Account(DataRow row)
        {
            this.Password = (string)row["MatKhau"].ToString();
            this.DisplayName = (string)row["TenHienThi"].ToString();
            this.UserName = (string)row["TenDangNhap"].ToString();
        }

        string userName;
        string displayName;
        string password;

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string Password { get => password; set => password = value; }
    }
}
