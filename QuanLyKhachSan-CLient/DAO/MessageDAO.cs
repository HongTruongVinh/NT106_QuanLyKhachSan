using QuanLyKhachSan_CLient.Network;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan_CLient.DAO
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

        public DataTable TableMessage(string clientUsername, string employeeUsername = "")
        {
            DataTable data;

            string query = string.Format("GetBoxChat {0} {1}", clientUsername, employeeUsername);

            data = (DataTable)FormatData.Instance.DeserializeData(TCPClient.Instance.GetDataFromCommand(query)); 

            return data;
        }

        public bool SendMessage(string employeeUsername, string clientUsername, string msg)
        {
            try
            {
                byte[] bytes = TCPClient.Instance.GetDataFromCommand(string.Format("Chating {0} {1} |{2}",employeeUsername, clientUsername, msg));

                string messageFromServer = Encoding.UTF8.GetString(bytes);

                string[] strings = messageFromServer.Split(' ', '\0');

                if (strings[0] == "success")
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
    }
}
