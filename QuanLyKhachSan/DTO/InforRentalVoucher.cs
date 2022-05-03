using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class InforRentalVoucher
    {
        public InforRentalVoucher(int id, int clientID, int roomID, string idPerson, DateTime? dateTimeCheckIn,  int numberPeople, int typeClient, string numberphone, string address)
        {
            this.ID = id;
            this.ClientID = clientID;
            this.RoomID = roomID;
            this.DateTimeCheckIn = dateTimeCheckIn;
            this.NumberPeople = numberPeople;
            this.NumberPhone = numberphone;
            this.TypeClient = typeClient;
            this.Address = address;
            this.IdPerson = idPerson;
        }

        public InforRentalVoucher(DataRow row)
        {
            string _id = (string)row["id"].ToString();
            this.ID = Int32.Parse(_id);

            string _clientID = (string)row["clientID"].ToString();
            this.ClientID = Int32.Parse(_clientID);

            string _roomID = (string)row["roomID"].ToString();
            this.RoomID = Int32.Parse(_roomID);

            this.DateTimeCheckIn = (DateTime?)row["dateTimeCheckIn"];

            this.NumberPhone = (string)row["numberPhone"].ToString();

            this.NumberPeople = (int)row["countPeople"];

            string typeClient = (string)row["typeClient"].ToString();
            this.TypeClient = Int32.Parse(typeClient);

            this.IdPerson = (string)row["idPerson"].ToString();

            this.Address = (string)row["address"].ToString();

            this.NameClient = (string)row["nameClient"].ToString();
        }


        private int iD;
        private int roomID;
        private int clientID;
        string numberPhone;
        private string address;
        private DateTime? dateTimeCheckIn;
        private int typeClient;
        private int numberPeople;
        private string nameClient;
        private string idPerson;

        public int ID { get => iD; set => iD = value; }
        public DateTime? DateTimeCheckIn { get => dateTimeCheckIn; set => dateTimeCheckIn = value; }
        public int NumberPeople { get => numberPeople; set => numberPeople = value; }
        public int RoomID { get => roomID; set => roomID = value; }
        public int ClientID { get => clientID; set => clientID = value; }
        public int TypeClient { get => typeClient; set => typeClient = value; }
        public string NumberPhone { get => numberPhone; set => numberPhone = value; }
        public string Address { get => address; set => address = value; }
        public string IdPerson { get => idPerson; set => idPerson = value; }
        public string NameClient { get => nameClient; set => nameClient = value; }
    }
}
