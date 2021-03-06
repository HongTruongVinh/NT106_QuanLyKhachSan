using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.DAO
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
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MaKH id, TenKhachHang name, CMND idPerson, DiaChi address, SDT numberPhone " +
                                                                "FROM KHACHHANG " + " WHERE MaKH = '" + id + "'");

            if (data.Rows.Count > 0)
            {
                Client client = new Client(data.Rows[0]);
                return client;
            }

            return null;
        }

        public DataTable GetClientByID_DataTable(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MaKH id, TenKhachHang name, CMND idPerson, DiaChi address, SDT numberPhone " +
                                                                "FROM KHACHHANG " + " WHERE MaKH = '" + id + "'");

            if(data==null) return null;

            if (data.Rows.Count > 0)
            {
                return data;
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
                Client customer = new Client(item,0);
                list.Add(customer);
            }

            return list;
        }

        public List<Client> GetListClient()
        {
            List<Client> list = new List<Client>();

            string query = "select * from KHACHHANG";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);



            foreach (DataRow item in data.Rows)
            {
                Client customer = new Client(item,0);
                list.Add(customer);
            }

            return list;
        }

        public DataTable GetTableClient()
        {
            string query = "SELECT MaKH as 'Mã khách hàng', TenKhachHang as 'Họ và tên', CMND as 'CMND', SDT as 'Số điện thoại', DiaChi as 'Địa chỉ' from KHACHHANG";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public bool InsertClient(string hoten, string sdt, string cmnd, string diachi)
        {
            try
            {
                string query = $@"
                USP_InsertClient
                @TenKhachHang=[{hoten}],
                @CMND='{cmnd}',
                @SDT='{sdt}',
                @DiaChi=[{diachi}]
            ";

                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
            catch
            {
                return false;
            }
            
        }

        public bool UpdateClient(int makhachhang, string hoten, string sdt, string cmnd, string diachi)
        {
            try
            {
                string query = string.Format("UPDATE KHACHHANG SET TenKhachHang = N'{0}', " +
                    "SDT = '{1}', " +
                    "CMND = '{2}', " +
                    "DiaChi = N'{3}' " +
                    "WHERE MaKH = {4}", hoten, sdt, cmnd, diachi, makhachhang);
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteClient(int id, string cmnd)
        {
            BillDAO.Instance.DeleteBillByMaKH(id);
            RentalVoucherDAO.Instance.DeleteRentalVoucherByMaKH(id);
            AccountDAO.Instance.DeleteAccClient(cmnd);
            string query = string.Format("Delete KHACHHANG where MaKH = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
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

        public Client ClientGetInfor(int idPerson)
        {
            Client client = ClientDAO.instance.GetClientByIDPerson(idPerson);
            return client;
        }

    }
}
