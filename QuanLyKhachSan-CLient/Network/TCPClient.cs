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
                    }
                    #endregion

                    #region lấy displayName được gửi về từ server
                    User.Instance.DisplayName = strings[2];
                    #endregion

                    stopTcpCient = false;

                    clientThread = new Thread(ClientReceive);
                    clientThread.Start();

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

        void ClientReceive()
        {
            DataFromServer = new byte[1024 * 5000];
            socketClient = tcpCLient.Client;

            while (/*tcpCLient.Connected &&*/ !stopTcpCient && clientThread.IsAlive == true)
            {
                Application.DoEvents();
                try
                {

                    byte[] data = new byte[1024 * 5000];
                    socketClient.Receive(data);
                    DataFromServer = data;

                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            }

            socketClient.Close();
            tcpCLient.Close();
            clientThread.Abort();
        }

        TcpClient newtcpCLient;
        IPAddress newserverIP = IPAddress.Parse("127.0.0.1");
        public byte[] GetDataFromCommand(string command)
        {
            byte[] dataGet = new byte[1024 * 5000];
            
            IPEndPoint newiPEndPoint = new IPEndPoint(newserverIP, SERVERPORT + 1);
            newtcpCLient = new TcpClient();
            newtcpCLient.Connect(newiPEndPoint);// Mở kết nối tới server 
            Socket newclientSocket = newtcpCLient.Client;

            byte[] dataSend = Encoding.ASCII.GetBytes(command);
            newclientSocket.Send(dataSend);//Gui

            newclientSocket.Receive(dataGet);//Nhan

            newclientSocket.Close();
            newtcpCLient.Close();


            return dataGet;
        }

        public void TCPCLientStop()
        {
            byte[] dataGet = new byte[1024 * 5000];

            IPEndPoint newiPEndPoint = new IPEndPoint(newserverIP, SERVERPORT + 1);
            newtcpCLient = new TcpClient();
            newtcpCLient.Connect(newiPEndPoint);// Mở kết nối tới server 
            Socket newclientSocket = newtcpCLient.Client;

            byte[] dataSend = Encoding.ASCII.GetBytes("EXIT");
            newclientSocket.Send(dataSend);//Gui

            newclientSocket.Receive(dataGet);//Nhan

            newclientSocket.Close();
            newtcpCLient.Close();

            stopTcpCient = true;
            tcpCLient.Close();
            clientThread.Abort();
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
