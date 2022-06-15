using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_CLient.Network;

namespace QuanLyKhachSan_CLient.Network
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

        public string SignUp(string name, string numberphone, string idPerson, string address, string password)
        {
            string stringReturn = "";

            byte[] bytes = TCPClient.Instance.GetDataFromCommand(string.Format("SignUp {0} {1} {2} {3} {4}", name, numberphone, idPerson, address, password));

            string message = Encoding.UTF8.GetString(bytes);

            string[] strings = message.Split(' ', '\0');

            if (strings[0] == "Successfully")
            {
                stringReturn = "Đăng kí tài khoản khách hàng thành công";
                return stringReturn;
            }

            if (strings[0] == "Error")
            {
                stringReturn = "Lỗi!\n";

                if (strings[1] == "Exist")
                {
                    stringReturn += "SDT này đã có người đăng kí!\n";
                }

                if (strings[2] == "Exist")
                {
                    stringReturn += "CMND này đã có người đăng kí!\n";
                }
            }

            return stringReturn;
        }

        public void Create(string username, string password)
        {
            UserName = username;
            Password = password;

            PasswordMD5 = fLogin.MD5(password);
        }
    }
}
