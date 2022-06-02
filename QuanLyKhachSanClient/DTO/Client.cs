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
            this.ID = (int)row["id"];

            string _idPerson = (string)row["idPerson"];

            this.IDPerson = Convert.ToInt32(_idPerson);
                

            this.Name = (string)row["name"];

            this.Address = (string)row["address"];

            this.NumberPhone = (string)row["numberPhone"];

          
        }

        public Client(DataRow row,int code)
        {
            
          this.ID = (int)row["MaKH"];

          string _idPerson = row["CMND"].ToString();
          this.IDPerson = Convert.ToInt32(_idPerson);

          this.Name = row["TenKhachHang"].ToString();

          this.Address = row["DiaChi"].ToString();

          this.NumberPhone = row["SDT"].ToString();
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
