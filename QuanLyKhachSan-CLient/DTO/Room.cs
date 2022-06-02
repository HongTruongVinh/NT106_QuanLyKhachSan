using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan_CLient.DTO
{
    public class Room
    {
        private int iD;

        private string name;

        private int floor;

        private string status;

        private string type;

        private uint price;

        private string note;

        public Room(int _id, string _name, string _status, string _type, uint _price, string _note = "")
        {
            this.ID = _id;
            this.Name = _name;
            this.Status = _status;
            this.Type = _type;
            this.Price = _price;
            this.Note = note;
        }

        public Room(DataRow row)
        {
            string _id = (string)row["id"].ToString();
            this.ID = int.Parse(_id);

            this.Name = row["name"].ToString();

            this.status= row["status"].ToString();

            this.Type= row["type"].ToString();

            this.Note = row["note"].ToString();

            string _price = row["price"].ToString();
            this.Price = uint.Parse(_price);
        }

        #region Propaty
        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public string Type { get => type; set => type = value; }
        public uint Price { get => price; set => price = value; }
        public int Floor { get => floor; set => floor = value; }
        public string Note { get => note; set => note = value; }
        #endregion
    }
}
