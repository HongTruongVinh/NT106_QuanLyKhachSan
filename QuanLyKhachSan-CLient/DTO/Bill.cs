using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan_CLient.DTO
{
    public class Bill
    {
        public Bill(int _iD, DateTime? _dateCheckIn, DateTime? _dateCheckOut, int _status)
        {
            this.ID = _iD;
            this.DateCheckIn = _dateCheckIn;
            this.DateCheckOut = _dateCheckOut;
            this.Status = _status;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["iD"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];
            this.DateCheckOut = (DateTime?)row["dateCheckOut"];
            this.Status = (int)row["status"];
        }

        #region Propaty
        int iD;
        DateTime? dateCheckIn;
        DateTime? dateCheckOut;
        int status;

        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status { get => status; set => status = value; }
        #endregion
    }
}
