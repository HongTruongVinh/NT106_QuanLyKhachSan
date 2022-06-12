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
using QuanLyKhachSan.DTO;
using System.Data;

namespace QuanLyKhachSan
{
    public partial class fChart : Form
    {
        #region KHONG SU DUNG HAM NAY
        public fChart()
        {
            InitializeComponent();
        }
        #endregion

        #region TẠO LINK VỚI fAdmin ĐỂ CÓ THỂ LẤY CÁC THUỘC TÍNH TỪ fAdmin
        private fAdmin mainform = null;

        public fChart(Form CallingForm)
        {
            mainform = CallingForm as fAdmin;
            InitializeComponent();
            LoadFunction();
        }
        #endregion

        #region FUNCTION
        void LoadFunction()
        {
            LoadData(this.mainform.CmbYear);
        }

        void LoadData(int year)
        {
            chartColumn.DataSource = BillDAO.Instance.GetChartByYear(year);
            chartColumn.Series.Add("VND");
            chartColumn.Series["VND"].XValueMember = "THANG";
            chartColumn.Series["VND"].YValueMembers = "DOANH THU";
            chartColumn.Titles.Add("Biểu đồ cột thống kê doanh số");
        }
        #endregion

        #region EVENTS
        private void fChart_FormClosing(object sender, FormClosingEventArgs e)
        {
            chartColumn.Series.Clear();
        }
        #endregion


    }
}
