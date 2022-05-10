using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class Client
    {
        public Client(int id, int idPerson, string name, string address, string numberphone)
        {
            this.ID = id;
            this.IDPerson = idPerson;
            this.Name = name;
            this.Address = address;
            this.NumberPhone = numberphone;
        }

        public Client(DataRow row)
        {
            this.ID = (int)row["MaKH"];

            string _idPerson = (string)row["CMND"];

            this.IDPerson = Convert.ToInt32(_idPerson);


            this.Name = (string)row["TenKhachHang"];

            this.Address = (string)row["DiaChi"];

            this.NumberPhone = (string)row["SDT"];

            /*
            this.ID = (int)row["MaKH"];


            this.IDPerson = row["CMND"].ToString();

            this.Name = row["TenKhachHang"].ToString();

            this.Address = row["DiaChi"].ToString();

            this.NumberPhone = row["SDT"].ToString();*/
        }


        int iD;
        int idPerson;
        string address;
        string name;
        string numberPhone;

        public int ID { get => iD; set => iD = value; }
        public int IDPerson { get => idPerson; set => idPerson = value; }
        public string Address { get => address; set => address = value; }
        public string Name { get => name; set => name = value; }
        public string NumberPhone { get => numberPhone; set => numberPhone = value; }
    }
}
