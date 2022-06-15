using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_CLient.DTO;
using QuanLyKhachSan_CLient.Network;

namespace QuanLyKhachSan_CLient.DAO
{
    public class ClientDAO
    {
        private static ClientDAO instance;
        public static ClientDAO Instance
        {
            get
            {
                if (instance == null) instance = new ClientDAO(); return instance;
            }
            private set { instance = value; }
        }

        private ClientDAO() { }


        #region Các hàm Load dữ liệu
        /// <summary>
        /// Lấy ra thông tin Khách Hàng bằng ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Client GetClientByID(int id)
        {
            string query = string.Format("GetClientByID {0}", id);

            DataTable data = (DataTable)FormatData.Instance.DeserializeData(TCPClient.Instance.GetDataFromCommand(query));

            if (data == null) return null;

            if (data.Rows.Count > 0)
            {
                Client client = new Client(data.Rows[0]);
                return client;
            }

            return null;
        }


        /// <summary>
        /// Lấy ra khách hàng bằng CMND
        /// </summary>
        /// <param name="idPerson"></param>
        /// <returns></returns>
        public Client GetClientByIDPerson(int idPerson)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MaKH id, TenKhachHang name, CMND idPerson, DiaChi address, SDT numberPhone " +
                                                                "FROM KHACHHANG " + " WHERE CMND = '" + idPerson + "'");

            if (data.Rows.Count > 0)
            {
                Client client = new Client(data.Rows[0]);
                return client;
            }

            return null;
        }
        #endregion

        #region Các hàm Insert dữ liệu
        public bool InsertLient(string name, int idPerson, string numberPhone, string address)
        {
            try
            {
                DataProvider.Instance.ExecuteNonQuery("USP_InsertClient @TenKhachHang , @CMND , @SDT , @DiaChi", new object[] { name, idPerson, numberPhone, address });
                return true;
            }
            catch
            {

            }
            return false;
        }

        public bool UpdateLient(int id, string name, int idPerson, string numberPhone, string address)
        {
            try
            {
                string query = string.Format("UPDATE dbo.KHACHHANG SET TenKhachHang = '{0}' , CMND = '{1}' , DiaChi = '{2}' , SDT = '{3}' WHERE MaKH = {4}", name, idPerson, address, numberPhone, id);

                DataProvider.Instance.ExecuteNonQuery(query);

                return true;
            }
            catch
            {

            }
            return false;
        }
        #endregion

        public List<Client> GetCustomerByCategoryID(int id)
        {
            List<Client> list = new List<Client>();

            string query = "select * from KHACHHANG where MaKH = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Client customer = new Client(item, 0);
                list.Add(customer);
            }

            return list;
        }

        public List<Client> GetListClient()
        {
            List<Client> list = new List<Client>();

            //string query = "select * from KHACHHANG";

            //DataTable data = DataProvider.Instance.ExecuteQuery(query);

            string query = string.Format("GetListClient");

            DataTable data = (DataTable)FormatData.Instance.DeserializeData(TCPClient.Instance.GetDataFromCommand(query));

            foreach (DataRow item in data.Rows)
            {
                Client customer = new Client(item, 0);
                list.Add(customer);
            }

            return list;
        }

        public bool InsertClient(string hoten, string sdt, string cmnd, string diachi)
        {
            string query = string.Format("InsertClient {0} {1} {2} {3}", hoten, sdt, cmnd, diachi);

            byte[] bytes = TCPClient.Instance.GetDataFromCommand(query);

            string msg = Encoding.UTF8.GetString(bytes);

            string[] message = msg.Split(' ', '\0');

            if (message[0] == "success")
            {
                return true;
            }

            return false;
        } 

        public bool UpdateClient(int makhachhang, string hoten, string sdt, string cmnd, string diachi)
        {
            string query = string.Format("UpdateClient {0} {1} {2} {3} {4}", makhachhang, hoten, sdt, cmnd, diachi);

            byte[] bytes = TCPClient.Instance.GetDataFromCommand(query);

            string msg = Encoding.UTF8.GetString(bytes);

            string[] message = msg.Split(' ', '\0');

            if (message[0] == "success")
            {
                return true;
            }

            return false;
        }

        public bool DeleteClient(int id, string cmnd)
        {
            string query = string.Format("DeleteClient {0} {1}", id, cmnd);

            byte[] bytes = TCPClient.Instance.GetDataFromCommand(query);

            string msg = Encoding.UTF8.GetString(bytes);

            string[] message = msg.Split(' ', '\0');

            if (message[0] == "success")
            {
                return true;
            }

            return false;
        }

        public DataTable GetGuestByBillID(int billId)
        {
            string query = $@"
                SELECT *
                FROM KHACHHANG, HOADON
                WHERE HOADON.MaKH = KHACHHANG.MaKH
                AND HOADON.MaHD = {billId}
            ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
