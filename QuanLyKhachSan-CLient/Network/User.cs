using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private string displayName;
        private string typeUser;


        public string TypeUser { get => typeUser; set => typeUser = value; }
        public string UserName { get { return userName; } set { userName = value; } }

        public string Password { get => password; set => password = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
    }
}
