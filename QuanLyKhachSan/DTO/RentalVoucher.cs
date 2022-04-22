using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class RentalVoucher
    {
        public RentalVoucher(int id, int clientID, int roomID, DateTime? dateTimeCheckIn, DateTime? dateTimeCheckOut, int numberPeople)
        {
            this.ID = id;
            this.ClientID = clientID;
            this.RoomID = clientID;
            this.DateTimeCheckIn = dateTimeCheckIn;
            this.DateTimeCheckOut = dateTimeCheckOut;
            this.NumberPeople = numberPeople;
        }

        public RentalVoucher(DataRow row)
        {
            string _id = (string)row["id"].ToString();
            this.ID = Int32.Parse(_id);

            string _clientID = (string)row["clientID"].ToString();
            this.ClientID = Int32.Parse(_clientID);

            string _roomID = (string)row["roomID"].ToString();
            this.RoomID = Int32.Parse(_roomID);

            this.DateTimeCheckIn = (DateTime?)row["dateTimeCheckIn"];
            this.DateTimeCheckOut = (DateTime?)row["dateTimeCheckOut"];
            this.NumberPeople = (int)row["numberPeople"];
        }


        private int iD;
        private int roomID;
        private int clientID;
        private DateTime? dateTimeCheckIn;
        private DateTime? dateTimeCheckOut;
        private int numberPeople;


        public int ID { get => iD; set => iD = value; }
        public DateTime? DateTimeCheckIn { get => dateTimeCheckIn; set => dateTimeCheckIn = value; }
        public DateTime? DateTimeCheckOut { get => dateTimeCheckOut; set => dateTimeCheckOut = value; }
        public int NumberPeople { get => numberPeople; set => numberPeople = value; }
        public int RoomID { get => roomID; set => roomID = value; }
        public int ClientID { get => clientID; set => clientID = value; }
    }
}
