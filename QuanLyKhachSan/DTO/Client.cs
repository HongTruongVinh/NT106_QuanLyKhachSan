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
        public Client(int id, int idPerson, string name, string address, string typeClient, float dependencyFactor = 1)
        {
            this.ID = id;
            this.IDPerson = idPerson;
            this.Name = name;
            this.Address = address;
            this.TypeClient = typeClient;
            this.DependencyFactor = dependencyFactor;
        }

        public Client(DataRow row)
        {
            this.ID = (int)row["id"];

            string _idPerson = (string)row["idPerson"];
            this.IDPerson = Int32.Parse(_idPerson);

            this.Name = (string)row["name"];
            this.Address = (string)row["address"];
            this.TypeClient = (string)row["typeClient"];

            string _dependencyFactor = (string)row["dependencyFactor"].ToString();
            this.DependencyFactor = float.Parse(_dependencyFactor);
        }


        int iD;
        int idPerson;
        string address;
        string name;
        string typeClient;
        float dependencyFactor;

        public int ID { get => iD; set => iD = value; }
        public int IDPerson { get => idPerson; set => idPerson = value; }
        public string Address { get => address; set => address = value; }
        public string Name { get => name; set => name = value; }

        /// <summary>
        /// Loại KH : nội địa hoặc nước ngoài
        /// </summary>
        public string TypeClient { get => typeClient; set => typeClient = value; }

        /// <summary>
        /// Hệ số phụ thu
        /// </summary>
        public float DependencyFactor { get => dependencyFactor; set => dependencyFactor = value; }
    }
}
