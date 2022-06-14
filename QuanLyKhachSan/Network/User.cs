using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DAO;
using QuanLyKhachSan.Network;

namespace QuanLyKhachSan.Network
{
    public class User
    {
        #region make singleton
        private static User instance;
        public static User Instance
        {
            get
            {
                if (instance == null) instance = new User(); return instance;
            }
            private set { instance = value; }
        }


        private User() { }
        #endregion

        private string userName;
        private string password;
        private string passwordMD5;
        private string displayName;
        private string typeUser;

        private string iD;
        private string address;
        private string phoneNumber;

        public string TypeUser { get => typeUser; set => typeUser = value; }
        public string UserName { get { return userName; } set { userName = value; } }

        public string Password { get => password; set => password = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string ID { get => iD; set => iD = value; }
        public string PasswordMD5 { get => passwordMD5; set => passwordMD5 = value; }

        public void Create(string username, string password)
        {
            UserName = username;
            Password = password;

            PasswordMD5 = fLogin.MD5(password);

            DataTable dataAdmin = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.TaiKhoan WHERE LoaiTaiKhoan = 1");

            if (dataAdmin == null) return;

            DisplayName = dataAdmin.Rows[0]["TenHienThi"].ToString();
            typeUser = "Admin";
        }
    }
}
