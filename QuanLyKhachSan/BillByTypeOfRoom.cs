using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class BillByTypeOfRoom : Form
    {
        public BillByTypeOfRoom()
        {
            InitializeComponent();
            LoadFunction();
        }

        #region Events
        private void btnViewBillByTypeOfRoom_Click(object sender, EventArgs e)
        {
            dtgvBill.DataSource = DAO.BillDAO.Instance.GetCheckedBillIDByRoomID(Int32.Parse(txbIDTypeOfRoom.Text));
            txbAmount.Text = DAO.BillDAO.Instance.GetTotalAmountOfMoneyByIDTypeRoom(Int32.Parse(txbIDTypeOfRoom.Text)).ToString();
        }
        #endregion

        #region Function
        void LoadFunction()
        {
            LoadListRoomName();
            AddBinding();
        }
        void LoadListRoomName()
        {
            string query = "SELECT MaLoaiPhong, TenLoaiPhong FROM dbo.LOAIPHONG";
            cmbTypeOfRoom.DataSource = DAO.DataProvider.Instance.ExecuteQuery(query);
            cmbTypeOfRoom.DisplayMember = "TenLoaiPhong";
        }
        void AddBinding()
        {
            txbIDTypeOfRoom.DataBindings.Add(new Binding("Text", cmbTypeOfRoom.DataSource, "MaLoaiPhong"));
        }
        #endregion
    }
}
