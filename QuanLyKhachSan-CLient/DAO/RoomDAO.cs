using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan_CLient.DTO;

namespace QuanLyKhachSan_CLient.DAO
{
    public class RoomDAO
    {
        #region Make singleton
        private static RoomDAO instance;
        public static RoomDAO Instance
        {
            get
            {
                if (instance == null) instance = new RoomDAO(); return instance;
            }
            private set { instance = value; }
        }

        private RoomDAO() { }
        #endregion

        public static int RoomWidth = 80;
        public static int RoomHeight = 80;

        public List<DTO.Room> GetRoomList()
        {
            List<DTO.Room> roomList = new List<DTO.Room>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MaPhong as id, TenPhong as name, TinhTrang as status, TenLoaiPhong as type, DonGia as price, GhiChu note FROM dbo.PHONG p, dbo.LOAIPHONG lp WHERE p.MaLoaiPhong = lp.MaLoaiPhong");

            foreach (DataRow row in data.Rows)
            {
                Room room = new Room(row);
                roomList.Add(room);
            }

            return roomList;
        }

        /// <summary>
        /// Tên của các trường thuộc tính là Tiếng Việt
        /// </summary>
        /// <returns></returns>
        public DataTable GetRoomList(string TiengViet)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MaPhong as [Mã phòng], TenPhong as [Tên phòng], TinhTrang as [Tình trạng], TenLoaiPhong as [Loại phòng], p.MaLoaiPhong [Mã loại phòng], GhiChu as [Ghi chú] FROM dbo.PHONG p, dbo.LOAIPHONG lp WHERE p.MaLoaiPhong = lp.MaLoaiPhong");

            return data;
        }

        /// <summary>
        /// Cập nhật trạng thái phòng (có người hoặc không)
        /// </summary>
        /// <param name="roomID"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public bool UpdateStatusRoom(int roomID, int status)
        {
            try
            {
                string query = "UPDATE dbo.PHONG SET TinhTrang = " + status + " WHERE MaPhong = " + roomID;

                DataProvider.Instance.ExecuteNonQuery(query);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InsertRoom(int idTypeRoom, string name, string note)
        {
            try
            {
                string query = string.Format("INSERT INTO dbo.PHONG ( MaLoaiPhong, TenPhong, GhiChu, TinhTrang) VALUES ( '{0}', N'{1}', '{2}', 0 ) ", idTypeRoom, name, note);

                DataProvider.Instance.ExecuteScalar(query);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateRoom(int idRoom, int idTypeRoom, string name, string note)
        {
            try
            {
                string query = string.Format("UPDATE dbo.PHONG SET MaLoaiPhong = {0}, TenPhong = '{1}', GhiChu = '{2}' WHERE MaPhong = {3}", idTypeRoom, name, note, idRoom);

                DataProvider.Instance.ExecuteScalar(query);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteRoom(int idRoom)
        {
            try
            {

                string queryCheck = "SELECT Count(MaPhieu) FROM dbo.PHIEUTHUEPHONG WHERE NgayKetThuc = NULL AND MaPhong = " + idRoom;

                if (DataProvider.Instance.ExecuteNonQuery(queryCheck) > 0)
                {
                    //Nếu có khách đang thuê phòng này thì không thể xóa phòng này
                    return false;
                }

                string query = "DELETE dbo.PHONG WHERE MaPhong = " + idRoom;

                DataProvider.Instance.ExecuteScalar(query);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool IsAvailable(int idRoom)
        {
            try
            {
                string queryCheck = "SELECT * FROM dbo.PHONG WHERE TinhTrang = 0 AND MaPhong = " + idRoom;
                int count = (DataProvider.Instance.ExecuteQuery(queryCheck) as DataTable).Rows.Count;

                if (count > 0)
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
