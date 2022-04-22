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

        public Client GetClientByID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MaKH id, TenKhachHang name, CMND idPerson, DiaChi address, TenLoaiKH typeClient, HeSoPhuThu dependencyFactor " +
                                                                "FROM dbo.KHACHHANG kh, dbo.LOAIKHACHHANG lkh" + " WHERE kh.MaLoaiKH = lkh.MaLoaiKH AND kh.MaKH = '"+ id +"'");

            if (data.Rows.Count > 0)
            {
                Client client = new Client(data.Rows[0]);
                return client;
            }

            return null;
        }


    }
}
