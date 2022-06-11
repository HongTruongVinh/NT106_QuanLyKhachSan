using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan_CLient.DAO
{
    public class RegulationsDAO
    {
        #region make singleton
        private static RegulationsDAO instance;
        public static RegulationsDAO Instance
        {
            get
            {
                if (instance == null) instance = new RegulationsDAO(); return instance;
            }
            private set { instance = value; }
        }

        private RegulationsDAO() { }
        #endregion

        private int soKhachToiDa;
        private int donGiaPhongCho;
        private float phuThuTuKhach;


        public int SoKhachToiDa { get => soKhachToiDa; set => soKhachToiDa = value; }
        public int DonGiaPhongCho { get => donGiaPhongCho; set => donGiaPhongCho = value; }
        public float PhuThuTuKhach { get => phuThuTuKhach; set => phuThuTuKhach = value; }
    }
}
