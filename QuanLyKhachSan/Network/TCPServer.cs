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
                            ClientDAO.Instance.InsertLient(strings[1], Convert.ToInt32(strings[2]), strings[3], strings[4]);
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

                        if(account.TypeUser == "Client")
                        {
                            Client client = ClientDAO.Instance.GetClientByIDPerson(Int32.Parse(account.UserName));

                            LoggedInSuccessfully += String.Format(" {0} {1} {2} {3} {4} {5}", account.TypeUser, account.DisplayName, client.ID, client.NumberPhone, client.Address, client.IDPerson);
                        }
                        else
                        {
                            LoggedInSuccessfully += " " + account.TypeUser + " " + account.DisplayName;// Gửi về loại tài khoản và DisplayName, vd: "Successfully Employee vinh"
                        }

                        byte[] Loged = Encoding.UTF8.GetBytes(LoggedInSuccessfully);
                        _socketClient.Send(Loged); // thong bao toi client dang nhap thanh cong


                        //Tao 1 thread moi để phục vụ user này 
                        Thread clientThread = new Thread(() => CommandFromClient(usernameAndpassword[0], _tcpClient));
                        //tcpClientDictionary.Add(usernameAndpassword[0], _tcpClient);
                        //clientThread.Name = usernameAndpassword[0];
                        //threadDictionary.Add(usernameAndpassword[0], clientThread);
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

        private void CommandFromClient(string username, TcpClient tcpClient)
        {

            bool clientConnecting = true;

            while (isServerOpen && clientConnecting)
            {

                try
                {
                    Socket socketClient = tcpClient.Client;

                    byte[] data = new byte[1024 * 5000];
                    socketClient.Receive(data);

                    string message = Encoding.UTF8.GetString(data);
                    string[] msg = message.Split('\0', ' ');


                    switch (msg[0])
                    {
                        #region fListRoom
                        case "GetListRoom":
                            byte[] listRoom = new byte[1024 * 5000];

                            DataTable roomList = RoomDAO.Instance.ClientGetRoomList();
                            listRoom = FormatData.Instance.SerializeData(roomList);

                            socketClient.Send(listRoom);

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

                            socketClient.Send(bytesAvailableRoom);

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

                            socketClient.Send(bytesSucessOderRoom);

                            break;
                        #endregion

                        case "ClientGetInfor":
                            Client client = ClientDAO.Instance.ClientGetInfor(Int32.Parse(msg[1]));
                            string inforClient = string.Format("{0} {1} {2} {3}", client.ID, client.Name, client.NumberPhone, client.Address);

                            byte[] bytesInforClient = new byte[1024 * 5000];
                            bytesInforClient = Encoding.UTF8.GetBytes(inforClient);

                            socketClient.Send(bytesInforClient);

                            break;

                        #region fNotice
                        case "GetListNoticeFromUsername":
                            byte[] dataGetListNoticeFromUsername = new byte[1024 * 5000];

                            DataTable GetListNoticeFromUsername = NoticeDAO.Instance.GetListNoticeFromUsername(username);
                            dataGetListNoticeFromUsername = FormatData.Instance.SerializeData(GetListNoticeFromUsername);

                            socketClient.Send(dataGetListNoticeFromUsername);

                            break;
                        #endregion

                        case "GetRegulations":

                            byte[] byteDataGetRegulations = new byte[1024 * 5000];

                            string DataGetRegulations = string.Format("{0} {1} {2}", RegulationDAO.Instance.SoKhachToiDa, RegulationDAO.Instance.DonGiaPhongCho, RegulationDAO.Instance.PhuThuTuKhach);

                            byteDataGetRegulations = Encoding.UTF8.GetBytes(DataGetRegulations);

                            socketClient.Send(byteDataGetRegulations);

                            break;

                        case "GetListOrderedRoom":
                            byte[] bytesGetListOrderedRoom = new byte[1024 * 5000];

                            DataTable listOrderedRoom = RoomDAO.Instance.GetListOrderedRoomOfClient(msg[1]);
                            bytesGetListOrderedRoom = FormatData.Instance.SerializeData(listOrderedRoom);

                            socketClient.Send(bytesGetListOrderedRoom);

                            break;

                        case "DeleteRoomOrdered":
                            byte[] resualtDeleteRoomOrder = new byte[1024 * 5000];

                            string bytesResualtDeleteRoomOrder = "fail";

                            if(RentalVoucherDAO.Instance.ClientDeleteRoomOrdered(msg[1], msg[2]))
                            {
                                bytesResualtDeleteRoomOrder = "success";
                            }

                            resualtDeleteRoomOrder = Encoding.UTF8.GetBytes(bytesResualtDeleteRoomOrder);

                            socketClient.Send(resualtDeleteRoomOrder);

                            break;

                        case "GetUnCheckRentalVoucherByRoomID":
                            byte[] bytesGetUnCheckRentalVoucherByRoomID = new byte[1024 * 5000];

                            int idRentalVoucher = Int32.Parse(msg[1]);

                            DataTable dataGetUnCheckRentalVoucherByRoomID = RentalVoucherDAO.Instance.GetUnCheckRentalVoucherByRoomID_DataTable(idRentalVoucher);

                            if(dataGetUnCheckRentalVoucherByRoomID != null)
                            {
                                bytesGetUnCheckRentalVoucherByRoomID = FormatData.Instance.SerializeData(dataGetUnCheckRentalVoucherByRoomID);
                            }

                            socketClient.Send(bytesGetUnCheckRentalVoucherByRoomID);

                            break;

                        case "GetClientByID":
                            byte[] bytesGetClientByID = new byte[1024 * 5000];

                            int idClient = Int32.Parse(msg[1]);

                            DataTable dataGetClientByID = ClientDAO.Instance.GetClientByID_DataTable(idClient);

                            if (dataGetClientByID != null)
                            {
                                bytesGetClientByID = FormatData.Instance.SerializeData(dataGetClientByID);
                            }

                            socketClient.Send(bytesGetClientByID);

                            break;

                        case "EXIT":
                            socketClient.Close();
                            tcpClient.Close();

                            //tcpClientDictionary.Remove(username);
                            //Thread threadBeKill = threadDictionary[username];
                            //threadDictionary.Remove(username);
                            //threadBeKill.Abort();
                            clientConnecting = false;
                            break;

                        #region Ngay 14/06

                        case "ResetPassword":
                            byte[] bytesResetPassword = new byte[1024 * 5000];

                            string resualResetPassword = "fail";

                            if (AccountDAO.Instance.ResetPassword(msg[1], msg[2]))
                            {
                                resualResetPassword = "success";
                            }

                            bytesResetPassword = Encoding.UTF8.GetBytes(resualResetPassword);

                            socketClient.Send(bytesResetPassword);

                            break;

                        case "GetBoxChat":

                            byte[] bytesBoxChat = new byte[1024 * 5000];

                            DataTable dataBoxChat = MessageDAO.Instance.TableMessage(msg[1], msg[2]);

                            if (dataBoxChat != null)
                            {
                                bytesBoxChat = FormatData.Instance.SerializeData(dataBoxChat);
                            }

                            socketClient.Send(bytesBoxChat);

                            break;

                        case "Chating":
                            string[] getMessage = message.Split('|', '\0');

                            byte[] bytesResualChating = new byte[1024 * 5000];

                            string resualChating = "fail";

                            if (MessageDAO.Instance.SendMessage(msg[1], msg[2], getMessage[1]))
                            {
                                resualChating = "success";

                                //byte[] bytesBoxChat1 = new byte[1024 * 5000];

                                //DataTable dataBoxChat1 = MessageDAO.Instance.TableMessage(msg[1], msg[2]);

                                //if (dataBoxChat1 != null)
                                //{
                                //    bytesBoxChat1 = FormatData.Instance.SerializeData(dataBoxChat1);
                                //}

                                //socketClient.Send(bytesBoxChat1);
                            }

                            bytesResualChating = Encoding.UTF8.GetBytes(resualChating);

                            socketClient.Send(bytesResualChating);

                            break;

                        #endregion

                        #region Ngay 15/06

                        // ĐIỀU CHỈNH FORM fListRentalVoucher
                        case "GetReservations":
                            byte[] bytesGetReservations = new byte[1024 * 5000];

                            //int idClient = Int32.Parse(msg[1]);

                            DataTable dataGetReservations = RentalVoucherDAO.Instance.getReservations();

                            if (dataGetReservations != null)
                            {
                                bytesGetReservations = FormatData.Instance.SerializeData(dataGetReservations);
                            }

                            socketClient.Send(bytesGetReservations);

                            break;

                        case "GetBills":
                            byte[] bytesGetBills = new byte[1024 * 5000];

                            //int idClient = Int32.Parse(msg[1]);

                            DataTable dataGetBills = BillDAO.Instance.GetBills();

                            if (dataGetBills != null)
                            {
                                bytesGetBills = FormatData.Instance.SerializeData(dataGetBills);
                            }

                            socketClient.Send(bytesGetBills);

                            break;

                        case "CreateBill":
                            byte[] resultCreateBill = new byte[1024 * 5000];

                            string bytesResultCreateBill = "fail";

                            if (BillDAO.Instance.CreateBill(Int32.Parse(msg[1]), Int32.Parse(msg[2]), Int32.Parse(msg[3]), Int32.Parse(msg[4]), msg[5], Int32.Parse(msg[6])))
                            {
                                bytesResultCreateBill = "success";
                            }

                            resultCreateBill = Encoding.UTF8.GetBytes(bytesResultCreateBill);

                            socketClient.Send(resultCreateBill);

                            break;

                        case "UpdateBill":
                            byte[] resultUpdateBill = new byte[1024 * 5000];

                            string bytesResultUpdateBill = "fail";

                            if (BillDAO.Instance.UpdateBill(Int32.Parse(msg[1]), Int32.Parse(msg[2]), Int32.Parse(msg[3]), Int32.Parse(msg[4]), Int32.Parse(msg[5]), msg[6], Int32.Parse(msg[7])))
                            {
                                bytesResultUpdateBill = "success";
                            }

                            resultUpdateBill = Encoding.UTF8.GetBytes(bytesResultUpdateBill);

                            socketClient.Send(resultUpdateBill);

                            break;

                        case "DeleteBill":
                            byte[] resultDeleteBill = new byte[1024 * 5000];

                            string bytesResultDeleteBill = "fail";

                            if (BillDAO.Instance.UpdateBill(Int32.Parse(msg[1]), Int32.Parse(msg[2]), Int32.Parse(msg[3]), Int32.Parse(msg[4]), Int32.Parse(msg[5]), msg[6], Int32.Parse(msg[7])))
                            {
                                bytesResultDeleteBill = "success";
                            }

                            resultDeleteBill = Encoding.UTF8.GetBytes(bytesResultDeleteBill);

                            socketClient.Send(resultDeleteBill);

                            break;

                        //ĐIỀU CHỈNH FORM fGuestMgnt
                        case "GetTableClient":
                            byte[] bytesGetListClient = new byte[1024 * 5000];

                            //int idClient = Int32.Parse(msg[1]);

                            DataTable dataGetListClient = ClientDAO.Instance.GetTableClient();

                            if (dataGetListClient != null)
                            {
                                bytesGetListClient = FormatData.Instance.SerializeData(dataGetListClient);
                            }

                            socketClient.Send(bytesGetListClient);

                            break;

                        //ĐIỀU CHỈNH FORM fBillDetailsDAO
                        case "PayBillByID":
                            byte[] resultPayBillByID = new byte[1024 * 5000];

                            string bytesResultPayBillByID = "fail";

                            if (BillDAO.Instance.PayBillByID(Int32.Parse(msg[1])))
                            {
                                bytesResultPayBillByID = "success";
                            }

                            resultPayBillByID = Encoding.UTF8.GetBytes(bytesResultPayBillByID);

                            socketClient.Send(resultPayBillByID);

                            break;

                        case "GetUnCheckedBillsByGuestInfo":
                            byte[] bytesGetUnCheckedBillsByGuestInfo = new byte[1024 * 5000];

                            //int idClient = Int32.Parse(msg[1]);
                            string[] stringss = message.Split('_','\0');

                            DataTable dataGetUnCheckedBillsByGuestInfo = BillDetailsDAO.Instance.GetUnCheckedBillsByGuestInfo(stringss[1], stringss[2]);

                            if (dataGetUnCheckedBillsByGuestInfo != null)
                            {
                                bytesGetUnCheckedBillsByGuestInfo = FormatData.Instance.SerializeData(dataGetUnCheckedBillsByGuestInfo);
                            }

                            socketClient.Send(bytesGetUnCheckedBillsByGuestInfo);

                            break;

                        case "InsertClient":
                            byte[] resultInsertClient = new byte[1024 * 5000];

                            string bytesResultInsertClient = "fail";

                            string[] ClientInfoForInsert = message.Split('_', '\0'); 

                            if (ClientDAO.Instance.InsertClient(ClientInfoForInsert[1], ClientInfoForInsert[2], ClientInfoForInsert[3], ClientInfoForInsert[4]))
                            {
                                bytesResultInsertClient = "success";
                            }

                            resultInsertClient = Encoding.UTF8.GetBytes(bytesResultInsertClient);

                            socketClient.Send(resultInsertClient);

                            break;

                        case "UpdateClient":
                            byte[] resultUpdateClient = new byte[1024 * 5000];

                            string bytesResultUpdateClient = "fail";

                            if (ClientDAO.Instance.UpdateClient(Int32.Parse(msg[1]), msg[2], msg[3], msg[4], msg[5]))
                            {
                                bytesResultUpdateClient = "success";
                            }

                            resultUpdateClient = Encoding.UTF8.GetBytes(bytesResultUpdateClient);

                            socketClient.Send(resultUpdateClient);

                            break;

                        case "DeleteBillByMaKH":
                            byte[] resultDeleteBillByMaKH = new byte[1024 * 5000];

                            string bytesResultDeleteBillByMaKH = "fail";

                            if (BillDAO.Instance.DeleteBillByMaKH(Int32.Parse(msg[1])))
                            {
                                bytesResultDeleteBillByMaKH = "success";
                            }

                            resultDeleteBillByMaKH = Encoding.UTF8.GetBytes(bytesResultDeleteBillByMaKH);

                            socketClient.Send(resultDeleteBillByMaKH);

                            break;

                        case "DeleteRentalVoucherByMaKH":
                            byte[] resultDeleteRentalVoucherByMaKH = new byte[1024 * 5000];

                            string bytesResultDeleteRentalVoucherByMaKH = "fail";

                            if (RentalVoucherDAO.Instance.DeleteRentalVoucherByMaKH(Int32.Parse(msg[1])))
                            {
                                bytesResultDeleteRentalVoucherByMaKH = "success";
                            }

                            resultDeleteRentalVoucherByMaKH = Encoding.UTF8.GetBytes(bytesResultDeleteRentalVoucherByMaKH);

                            socketClient.Send(resultDeleteRentalVoucherByMaKH);

                            break;

                        case "DeleteClient":
                            byte[] resultDeleteClient = new byte[1024 * 5000];

                            string bytesResultDeleteClient = "fail";

                            if (ClientDAO.Instance.DeleteClient(Int32.Parse(msg[1]), msg[2]))
                            {
                                bytesResultDeleteClient = "success";
                            }

                            resultDeleteClient = Encoding.UTF8.GetBytes(bytesResultDeleteClient);

                            socketClient.Send(resultDeleteClient);

                            break;
                            #endregion
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
