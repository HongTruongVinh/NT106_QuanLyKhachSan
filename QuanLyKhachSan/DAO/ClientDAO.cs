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
                                                                "FROM KHACHHANG " + " WHERE MaKH = '"+ id +"'");

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
        #endregion
    }
}
