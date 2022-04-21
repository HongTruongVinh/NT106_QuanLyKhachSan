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

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MaPhong as id, TenPhong as name, TinhTrang as status, TenLoaiPhong as type, DonGia as price FROM dbo.PHONG p, dbo.LOAIPHONG lp WHERE p.MaLoaiPhong = lp.MaLoaiPhong");

            foreach (DataRow row in data.Rows)
            {
                Room room = new Room(row);
                roomList.Add(room);
            }

            return roomList;
        }
    }
}
