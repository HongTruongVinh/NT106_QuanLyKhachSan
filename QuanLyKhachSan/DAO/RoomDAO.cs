using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.DAO
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

        public List<DTO.Room> LoadRoomList()
        {
            List<DTO.Room> roomList = new List<DTO.Room>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.ROOM");

            foreach (DataRow row in data.Rows)
            {
                Room room = new Room(row);
                roomList.Add(room);
            }

            return roomList;
        }
    }
}
