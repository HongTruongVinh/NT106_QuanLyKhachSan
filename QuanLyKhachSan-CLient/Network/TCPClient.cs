using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan_CLient.Network
{
    public class TCPClient
    {
        #region make singleton
        private static TCPClient instance;
        public static TCPClient Instance
        {
            get
            {
                if (instance == null) instance = new TCPClient(); return instance;
            }
            private set { instance = value; }
        }


        private TCPClient() { }
        #endregion

        TcpClient tcpCLient;
        Socket socketClient;
        const int SERVERPORT = 8080;
        Thread clientThread;
        bool stopTcpCient = true;

        
        private byte[] dataFromServer;

        public byte[] DataFromServer { get => dataFromServer; set => dataFromServer = value; }


        public bool Login(string _username, string _password)
        {
            User.Instance.UserName = _username;
            User.Instance.Password = _password;

            try
            {
                stopTcpCient = false;

                tcpCLient = new TcpClient();
                IPAddress serverIP = IPAddress.Parse("127.0.0.1");
                IPEndPoint iPEndPoint = new IPEndPoint(serverIP, SERVERPORT);

                tcpCLient.Connect(iPEndPoint);// Mở kết nối tới server 
                socketClient = tcpCLient.Client;// Lấy cổng kết nối để dùng 

                //Gửi username và password tới server
                string stringUsernameAndPassword = _username + " " + _password + " ";
                byte[] byteUsernameAndPassword = Encoding.ASCII.GetBytes(stringUsernameAndPassword);

                socketClient.Send(byteUsernameAndPassword);


                //kiểm tra xem phản hồi từ server là đăng nhập thành công hay không 
                byte[] _data = new byte[1024 * 500];
                socketClient.Receive(_data);
                string messageFromServer = Encoding.UTF8.GetString(_data);

                string[] strings = messageFromServer.Split(' ', '\0');
                
                //Nếu dăng nhập thành công thì mở MainWindow
                if (strings[0] == "Successfully")
                {
                    #region Lấy loại User được gửi về từ server
                    if (strings[1] == "Admin")
                    {
                        User.Instance.TypeUser = "Admin";
                    }
                    else if (strings[1] == "Employee")
                    {
                        User.Instance.TypeUser = "Employee";
                    }
                    else
                    {
                        User.Instance.TypeUser = "Client";

                        User.Instance.ID = strings[3];
                        User.Instance.PhoneNumber = strings[4];
                        User.Instance.Address = strings[5];
                        ///User.Instance.UserName = strings[6];
                    }
                    #endregion

                    #region lấy displayName, id, phonenumber, address được gửi về từ server
                    User.Instance.DisplayName = strings[2];
                    
                    #endregion

                    stopTcpCient = false;

                    return true;
                }
                else
                {
                    tcpCLient.Close();
                    socketClient.Close();

                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public byte[] GetDataFromCommand(string command)
        {
            byte[] bytecommand = Encoding.ASCII.GetBytes(command);

            byte[] dataReveiveFromServer = new byte[1024 * 5000];

            socketClient.Send(bytecommand);

            socketClient.Receive(dataReveiveFromServer);

            return dataReveiveFromServer;
        }

        public void TCPCLientStop()
        {
            byte[] dataSend = Encoding.ASCII.GetBytes("EXIT");
            socketClient.Send(dataSend);//Gui

            stopTcpCient = true;
            socketClient.Close();
            tcpCLient.Close();
        }

        public byte[] GetDataFromCommand_SignUp(string command)
        {
            byte[] dataGet = new byte[1024 * 5000];

            tcpCLient = new TcpClient();
            IPAddress serverIP = IPAddress.Parse("127.0.0.1");
            IPEndPoint iPEndPoint = new IPEndPoint(serverIP, SERVERPORT);

            tcpCLient.Connect(iPEndPoint);// Mở kết nối tới server 
            socketClient = tcpCLient.Client;// Lấy cổng kết nối để dùng 

            byte[] dataSend = Encoding.ASCII.GetBytes(command);
            socketClient.Send(dataSend);//Gui

            socketClient.Receive(dataGet);//Nhan

            socketClient.Close();
            tcpCLient.Close();

            return dataGet;
        }
    }
}
