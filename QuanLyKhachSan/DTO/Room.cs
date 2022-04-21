using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class Room
    {
        private int iD;

        private string name;

        private int floor;

        private string status;

        private string type;

        private uint price;

        public Room(int _id, string _name, string _status, string _type, uint _price)
        {
            this.ID = _id;
            this.Name = _name;
            this.Status = _status;
            this.Type = _type;
            this.Price = _price;
        }

        public Room(DataRow row)
        {
            string _id = (string)row["id"];
            this.ID = int.Parse(_id);

            this.Name = row["name"].ToString();

            this.status= row["status"].ToString();

            this.Type= row["type"].ToString();

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
        #endregion
    }
}
