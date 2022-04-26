using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.DAO
{
    public class TypeRoomDAO
    {
        #region Make singleton
        private static TypeRoomDAO instance;
        public static TypeRoomDAO Instance
        {
            get
            {
                if (instance == null) instance = new TypeRoomDAO(); return instance;
            }
            private set { instance = value; }
        }

        private TypeRoomDAO() { }
        #endregion

        public List<TypeRoom> GetCategoryRoom()
        {
            List<TypeRoom> lst = new List<TypeRoom>();

            string query = "SELECT MaLoaiPhong as id, TenLoaiPhong as name, DonGia as price FROM dbo.LOAIPHONG";

            DataTable data =  DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                TypeRoom type = new TypeRoom(row);

                lst.Add(type);
            }

            return lst;
        }

        public DataTable GetCategoryRoom(string TiengViet)
        {
            string query = "SELECT MaLoaiPhong as [Mã loại phòng], TenLoaiPhong as [Tên Loại phòng], DonGia as [Đơn giá] FROM dbo.LOAIPHONG";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public TypeRoom GetCategoryByID(int id)
        {
            TypeRoom typeRoom = null;

            string query = "SELECT MaLoaiPhong as id, TenLoaiPhong as name, DonGia as price FROM dbo.LOAIPHONG WHERE MaLoaiPhong = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                typeRoom = new TypeRoom(row);

                return typeRoom;
            }

            return typeRoom;
        }

        public TypeRoom GetCategoryByName(string name)
        {
            TypeRoom typeRoom = null;

            string query = "SELECT * FROM dbo.LOAIPHONG WHERE TenLoaiPhong = " + name;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                typeRoom = new TypeRoom(row);

                return typeRoom;
            }

            return typeRoom;
        }

        public bool Insert(string name, int price)
        {
            try
            {
                string query = string.Format("INSERT INTO dbo.LOAIPHONG ( TenLoaiPhong, DonGia) VALUES ( N'{0}', {1}) ",name, price);

                DataProvider.Instance.ExecuteScalar(query);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(int idTypeRoom, string name, int price)
        {
            try
            {
                string query = string.Format("UPDATE dbo.LOAIPHONG SET TenPhong = '{0}', DonGia = '{1}' WHERE MaPhong = {2}",name, price, idTypeRoom);

                DataProvider.Instance.ExecuteScalar(query);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int idTypeRoom)
        {
            try
            {
                string queryCheck = "SELECT Count(MaPhong) FROM dbo.PHONG WHERE MaLoaiPhong = " + idTypeRoom;

                if (DataProvider.Instance.ExecuteNonQuery(queryCheck) > 0)
                {
                    //Nếu có phòng đang sử dụng loại phòng này thì không thể xóa loại phòng này
                    return false;
                }

                string query = "DELETE dbo.LOAIPHONG WHERE MaPhong = " + idTypeRoom;

                DataProvider.Instance.ExecuteScalar(query);

                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
