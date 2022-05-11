using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.DAO;

namespace QuanLyKhachSan
{
    public partial class fBillMgmt : Form
    {
        public fBillMgmt()
        {
            InitializeComponent();
        }

        private void btn_Xuat_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tb_NhapMaHD.Text);
            //DataTable data = BillDAO.Instance.GetBillByID(id);
            //dgv_ChiTietHD.DataSource = data;
        }
    }
}
