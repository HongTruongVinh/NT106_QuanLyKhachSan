using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class Account
    {
        public Account(string username, string displayname, string password, int typeUser)
        {
            this.Password = password;
            this.DisplayName = displayname;
            this.UserName = username;

            if(typeUser == 0)
            {
                this.TypeUser = "Admin";
            }
            else
            {
                this.TypeUser = "Employee";
            }
            
        }

        public Account(DataRow row)
        {
            this.Password = (string)row["MatKhau"].ToString();
            this.DisplayName = (string)row["TenHienThi"].ToString();
            this.UserName = (string)row["TenDangNhap"].ToString();
            string typeUser = (string)row["LoaiTaiKhoan"].ToString();

            if (typeUser == "1")
            {
                this.TypeUser = "Admin";
            }
            else if(typeUser == "0")
            {
                this.TypeUser = "Employee";
            }
            else
            {
                this.TypeUser = "Client";
            }
        }

        int iD;
        string userName;
        string displayName;
        string password;
        string typeUser;

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string Password { get => password; set => password = value; }
        public int ID { get => iD; set => iD = value; }
        public string TypeUser { get => typeUser; set => typeUser = value; }
    }
}
