using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Network
{
    public class TCPServer
    {
        #region make singleton
        private static TCPServer instance;
        public static TCPServer Instance
        {
            get
            {
                if (instance == null) instance = new TCPServer(); return instance;
            }
            private set { instance = value; }
        }

        private TCPServer() { }
        #endregion

        Thread serverThread;
        TcpListener tcpListener;
        bool isServerOpen = false;
        const int SERVERPORT = 8080;
        Dictionary<string, TcpClient> tcpClientDictionary = new Dictionary<string, TcpClient>();// lưu những tcp đc tạo ra mỗi khi có 1 client đăng nhập

        Dictionary<string, Thread> threadDictionary = new Dictionary<string, Thread>();// lưu những thread đc tạo ra mỗi khi có 1 client đăng nhập

        public void TCPServerStart()
        {
            isServerOpen = true;
            serverThread = new Thread(new ThreadStart(Listen));
            serverThread.Start();
        }

        private void Listen()
        {
            try
            {

                tcpListener = new TcpListener(new System.Net.IPEndPoint(IPAddress.Any, SERVERPORT));
                tcpListener.Start();

                while (isServerOpen)
                {
                    TcpClient _tcpClient = tcpListener.AcceptTcpClient();

                    Socket _socketClient = _tcpClient.Client;

                    byte[] data = new byte[1024 * 500];

                    _socketClient.Receive(data);

                    string messageFromTCPClient = Encoding.ASCII.GetString(data);

                    if (messageFromTCPClient.Contains("SignUp"))
                    {
                        string[] strings = messageFromTCPClient.Split(' ', '\0');//SignUp {0} {1} {2} {3}", name, numberphone, idPerson, address

                        string responseMessage = "Successfully";

                        if (AccountDAO.Instance.IsExistIDPerson(strings[3]) || AccountDAO.Instance.IsExistNumberPhone(strings[2]) || AccountDAO.Instance.InsertAccountCLient(strings[2], strings[1], strings[5]) == false)
                        {
                            responseMessage = "Error";

                            if (AccountDAO.Instance.IsExistNumberPhone(strings[2]))
                            {
                                responseMessage += " Exist";
                            }
                            else
                            {
                                responseMessage += " Ok";
                            }

                            if (AccountDAO.Instance.IsExistIDPerson(strings[3]))
                            {
                                responseMessage += " Exist";
                            }
                            else
                            {
                                responseMessage += " Ok";
                            }
                        }
                        else
                        {
                            responseMessage += " OK OK";

                            //AccountDAO.Instance.Insert(strings[2], strings[1], strings[5]);
                            ClientDAO.Instance.InsertLient(strings[1], Convert.ToInt32(strings[3]), strings[2], strings[4]);
                        }


                        byte[] signUpSuccessfully = Encoding.UTF8.GetBytes(responseMessage);
                        _socketClient.Send(signUpSuccessfully);
                        continue;
                    }

                    string[] usernameAndpassword = messageFromTCPClient.Split(' ', '\0');

                    if (AccountDAO.Instance.Login(usernameAndpassword[0], usernameAndpassword[1]))// đăng nhập thành công 
                    {
                        string LoggedInSuccessfully = "Successfully";//Gửi về message đăng nhập thành công

                        Account account = AccountDAO.Instance.GetUser(usernameAndpassword[0], usernameAndpassword[1]);

                        LoggedInSuccessfully += " " + account.TypeUser + " " + account.DisplayName;// Gửi về loại tài khoản và DisplayName, vd: "Successfully Employee vinh"

                        byte[] Loged = Encoding.UTF8.GetBytes(LoggedInSuccessfully);
                        _socketClient.Send(Loged); // thong bao toi client dang nhap thanh cong


                        //Tao 1 thread moi để phục vụ user này 
                        Thread clientThread = new Thread(() => CommandFromClient(usernameAndpassword[0], _tcpClient, _socketClient));
                        tcpClientDictionary.Add(usernameAndpassword[0], _tcpClient);
                        clientThread.Name = usernameAndpassword[0];
                        threadDictionary.Add(usernameAndpassword[0], clientThread);
                        clientThread.Start();
                    }
                    else
                    {
                        string LoginFailed = "LoginFailed";
                        byte[] LogFail = Encoding.UTF8.GetBytes(LoginFailed);

                        _socketClient.Send(LogFail);// thong bao toi client dang nhap khong thanh cong
                    }

                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void CommandFromClient(string username, TcpClient tcpClient, Socket socketClient)
        {

            bool clientConnecting = true;

            TcpListener tcpListener1 = new TcpListener(new System.Net.IPEndPoint(IPAddress.Any, SERVERPORT + 1));
            tcpListener1.Start();

            while (isServerOpen && clientConnecting)
            {

                try
                {
                    TcpClient tcpClient1 = tcpListener1.AcceptTcpClient();
                    Socket newSocket = tcpClient1.Client;

                    byte[] data = new byte[1024 * 5000];
                    newSocket.Receive(data);

                    string message = Encoding.UTF8.GetString(data);
                    string xxx = Encoding.UTF8.GetString(data);
                    string[] msg = message.Split('\0', ' ');


                    switch (msg[0])
                    {
                        #region fListRoom
                        case "GetListRoom":
                            byte[] listRoom = new byte[1024 * 5000];

                            DataTable roomList = RoomDAO.Instance.ClientGetRoomList();
                            listRoom = FormatData.Instance.SerializeData(roomList);

                            newSocket.Send(listRoom);

                            newSocket.Close();
                            tcpClient1.Close();

                            break;

                        case "AvailableRoom":
                            byte[] bytesAvailableRoom = new byte[1024 * 5000];

                            if (RoomDAO.Instance.IsAvailable(Int32.Parse(msg[1])))
                            {
                                bytesAvailableRoom = Encoding.UTF8.GetBytes("Available");
                            }
                            else
                            {
                                bytesAvailableRoom = Encoding.UTF8.GetBytes("IsNotAvailable");
                            }

                            newSocket.Send(bytesAvailableRoom);

                            newSocket.Close();
                            tcpClient1.Close();

                            break;

                        case "OrderRoom":
                            byte[] bytesSucessOderRoom = new byte[1024 * 5000];

                            if (RoomDAO.Instance.IsAvailable(Int32.Parse(msg[1])) && RentalVoucherDAO.Instance.InserRentalVoucherFromClient(Int32.Parse(msg[1]), Int32.Parse(msg[2]), Int32.Parse(msg[3]), msg[4], msg[5], msg[6], msg[7]))
                            {
                                bytesSucessOderRoom = Encoding.UTF8.GetBytes("OderRoomSuccessfully");
                            }
                            else
                            {
                                bytesSucessOderRoom = Encoding.UTF8.GetBytes("OderRoomFail");
                            }

                            newSocket.Send(bytesSucessOderRoom);

                            newSocket.Close();
                            tcpClient1.Close();

                            break;
                        #endregion

                        case "ClientGetInfor":
                            Client client = ClientDAO.Instance.ClientGetInfor(Int32.Parse(msg[1]));
                            string inforClient = string.Format("{0} {1} {2} {3}", client.ID, client.Name, client.NumberPhone, client.Address);

                            byte[] bytesInforClient = new byte[1024 * 5000];
                            bytesInforClient = Encoding.UTF8.GetBytes(inforClient);


                            newSocket.Send(bytesInforClient);

                            newSocket.Close();
                            tcpClient1.Close();

                            break;

                        #region fNotice
                        case "GetListNoticeFromUsername":
                            byte[] dataGetListNoticeFromUsername = new byte[1024 * 5000];

                            DataTable GetListNoticeFromUsername = NoticeDAO.Instance.GetListNoticeFromUsername(username);
                            dataGetListNoticeFromUsername = FormatData.Instance.SerializeData(GetListNoticeFromUsername);

                            newSocket.Send(dataGetListNoticeFromUsername);

                            newSocket.Close();
                            tcpClient1.Close();

                            break;
                        #endregion

                        case "GetRegulations":

                            byte[] byteDataGetRegulations = new byte[1024 * 5000];

                            string DataGetRegulations = string.Format("{0} {1} {2}", RegulationDAO.Instance.SoKhachToiDa, RegulationDAO.Instance.DonGiaPhongCho, RegulationDAO.Instance.PhuThuTuKhach);

                            byteDataGetRegulations = Encoding.UTF8.GetBytes(DataGetRegulations);

                            newSocket.Send(byteDataGetRegulations);

                            newSocket.Close();
                            tcpClient1.Close();
                            break;

                        case "GetListOrderedRoom":
                            byte[] bytesGetListOrderedRoom = new byte[1024 * 5000];

                            DataTable listOrderedRoom = RoomDAO.Instance.GetListOrderedRoomOfClient(msg[1]);
                            bytesGetListOrderedRoom = FormatData.Instance.SerializeData(listOrderedRoom);

                            newSocket.Send(bytesGetListOrderedRoom);

                            newSocket.Close();
                            tcpClient1.Close();

                            break;

                        case "DeleteRoomOrdered":
                            byte[] resualtDeleteRoomOrder = new byte[1024 * 5000];

                            string bytesResualtDeleteRoomOrder = "fail";

                            if(RentalVoucherDAO.Instance.ClientDeleteRoomOrdered(msg[1], msg[2]))
                            {
                                bytesResualtDeleteRoomOrder = "success";
                            }

                            resualtDeleteRoomOrder = Encoding.UTF8.GetBytes(bytesResualtDeleteRoomOrder);

                            newSocket.Send(resualtDeleteRoomOrder);

                            newSocket.Close();
                            tcpClient1.Close();

                            break;

                        case "GetUnCheckRentalVoucherByRoomID":
                            byte[] bytesGetUnCheckRentalVoucherByRoomID = new byte[1024 * 5000];

                            int idRentalVoucher = Int32.Parse(msg[1]);

                            DataTable dataGetUnCheckRentalVoucherByRoomID = RentalVoucherDAO.Instance.GetUnCheckRentalVoucherByRoomID_DataTable(idRentalVoucher);

                            if(dataGetUnCheckRentalVoucherByRoomID != null)
                            {
                                bytesGetUnCheckRentalVoucherByRoomID = FormatData.Instance.SerializeData(dataGetUnCheckRentalVoucherByRoomID);
                            }

                            newSocket.Send(bytesGetUnCheckRentalVoucherByRoomID);

                            newSocket.Close();
                            tcpClient1.Close();

                            break;

                        case "GetClientByID":
                            byte[] bytesGetClientByID = new byte[1024 * 5000];

                            int idClient = Int32.Parse(msg[1]);

                            DataTable dataGetClientByID = ClientDAO.Instance.GetClientByID_DataTable(idClient);

                            if (dataGetClientByID != null)
                            {
                                bytesGetClientByID = FormatData.Instance.SerializeData(dataGetClientByID);
                            }

                            newSocket.Send(bytesGetClientByID);

                            newSocket.Close();
                            tcpClient1.Close();

                            break;

                        case "EXIT":
                            newSocket.Close();
                            tcpClient1.Close();

                            tcpClientDictionary.Remove(username);
                            Thread threadBeKill = threadDictionary[username];
                            threadDictionary.Remove(username);
                            threadBeKill.Abort();
                            clientConnecting = false;
                            break;

                        case "GetListRentalVoucherUnCheckOut":
                            byte[] bytesGetListRentalVoucherUnCheckOut = new byte[1024 * 5000];

                            //int idClient = Int32.Parse(msg[1]);

                            DataTable dataGetListRentalVoucherUnCheckOut = RentalVoucherDAO.Instance.ListRentalVoucherUnCheckOut("TV");

                            if (dataGetListRentalVoucherUnCheckOut != null)
                            {
                                bytesGetListRentalVoucherUnCheckOut = FormatData.Instance.SerializeData(dataGetListRentalVoucherUnCheckOut);
                            }

                            newSocket.Send(bytesGetListRentalVoucherUnCheckOut);

                            newSocket.Close();
                            tcpClient1.Close();

                            break;
                    }
                }
                catch
                {

                }
            }
        }

        public void TCPServerStop()
        {
            foreach (var item in tcpClientDictionary)
            {
                tcpClientDictionary.Remove(item.Key);
                Thread threadBeKill = threadDictionary[item.Key];
                threadDictionary.Remove(item.Key);
                threadBeKill.Abort();
            }
            isServerOpen = false;
            tcpListener.Stop();
            
            serverThread.Abort();

        }
    }
}
