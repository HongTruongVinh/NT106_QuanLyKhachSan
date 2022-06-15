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

            DataTable data = (DataTable)FormatData.Instance.DeserializeData(TCPClient.Instance.GetDataFromCommand("GetListRoom"));

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
            DataTable data = (DataTable)FormatData.Instance.DeserializeData(TCPClient.Instance.GetDataFromCommand("GetListRoom"));

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

        #region Ngay 11/06
        public bool IsAvailable(int idRoom)
        {
            try
            {
                byte[] bytes = TCPClient.Instance.GetDataFromCommand(string.Format("AvailableRoom {0}", idRoom));

                string message = Encoding.UTF8.GetString(bytes);

                string[] msg = message.Split('\0');

                if (msg[0] == "Available")
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

        public bool OrderRoom(int idRoom, int countPeople, int typeClient, string name, string idPerson, string numberphone, string address)
        {
            byte[] bytes = TCPClient.Instance.GetDataFromCommand(string.Format("OderRoom {0} {1} {2} {3} {4} {5}", countPeople, typeClient, name, idPerson, numberphone, address));

            string message = Encoding.UTF8.GetString(bytes);

            string[] msg = message.Split('\0');

            if (msg[0] == "SucessOderRoom")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region Ngay 12/06
        public DataTable ListRoomOrdered(string username)
        {
            string query = string.Format("GetListOrderedRoom {0}", username);

            DataTable data = (DataTable)FormatData.Instance.DeserializeData(TCPClient.Instance.GetDataFromCommand(query));

            return data;
        }

        public DataTable DeleteRoomOrdered(string username, int idRoom)
        {
            string query = string.Format("GetListOrderedRoom {0} {1}", username, idRoom);

            DataTable data = (DataTable)FormatData.Instance.DeserializeData(TCPClient.Instance.GetDataFromCommand(query));

            return data;
        }

        #endregion

    }
}
