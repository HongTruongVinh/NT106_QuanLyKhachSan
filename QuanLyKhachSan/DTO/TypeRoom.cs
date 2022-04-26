using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class TypeRoom
    {
        public TypeRoom(int _id ,string _name, int _price)
        {
            this.ID = _id;
            this.Name = Name;
            this.Price = _price;
        }

        public TypeRoom(DataRow row)
        {
            string _id = (string)row["id"].ToString();
            this.ID = int.Parse(_id);

            this.Name = row["name"].ToString();

            string _price = row["price"].ToString();
            this.Price = int.Parse(_price);
        }


        private int id;
        private string name;
        private int price;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
    }
}
