using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyKhachSan.DTO
{
    internal class BillDetails
    {
        #region Singleton
        private static BillDetails _instance;
        public static BillDetails Instance 
        {
            get { if (_instance == null) _instance = new BillDetails(); return _instance; }
            set { _instance = value; }
        }
        private BillDetails() { }
        #endregion

        #region Constructor
        public BillDetails(int _id, int _billId, int _roomId, int _days, int _price, DateTime _date, int _amount, int _state )
        {
            Id = _id;
            BillId = _billId;
            RoomId = _roomId;
            Days = _days;
            Price = _price;
            Date = _date;
            Amount = _amount;
            State = _state;
        }

        public BillDetails(DataRow row)
        {
            Id = (int)row["MaCTHD"];
            BillId = (int)row["MaHD"];
            RoomId = (int)row["MaPhong"];
            Days = (int)row["SoNgayThue"];
            Price = (int)row["ThanhTien"];
            Date = (DateTime)row["NgayThanhToan"];
            Amount = (int)row["DonGia"];
            State = (int)row["TrangThai"];
        }
        #endregion

        #region Properties
        private int _id;
        public int Id { get { return _id; } set { _id = value; } }
        private int _billId;
        public int BillId { get { return _billId; } set { _billId = value; } }
        private int _roomId;
        public int RoomId { get { return _roomId; } set { _roomId = value; } }
        private int _days;
        public int Days { get { return _days; } set { _days = value; } }
        private int _price;
        public int Price { get { return _price; } set { _price = value; } }
        private DateTime _date;
        public DateTime Date { get { return _date; } set { _date = value; } }
        private int _amount;
        public int Amount { get { return _amount; } set { _amount = value; } }
        private int _state;
        public int State { get { return _state; } set { _state = value; } }
        #endregion
    }
}
