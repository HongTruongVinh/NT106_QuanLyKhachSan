using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan_CLient.DAO;
using QuanLyKhachSan_CLient.DTO;

namespace QuanLyKhachSan_CLient
{
    public partial class fBillMgmt : Form
    {
        public fBillMgmt()
        {
            InitializeComponent();
            LoadData();
        }

        private string name;
        private string personalID;

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(lb_DLMaHD.Text);
            if (BillDAO.Instance.PayBillByID(id))
            {
                MessageBox.Show("Thanh toán thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
            LoadData();
        }

        private void LoadData()
        {
            DataTable bills = BillDetailsDAO.Instance.GetUnCheckedBillsByGuestInfo(name, personalID);
            dgv_DSHD.DataSource = bills;
            AddBindings(bills);
        }

        private void AddBindings(DataTable bills)
        {
            lb_DLMaHD.DataBindings.Clear();
            lb_DLMaPhong.DataBindings.Clear();
            lb_DLSoNgayThue.DataBindings.Clear();
            lb_DLThanhTien.DataBindings.Clear();
            lb_DLNgayThanhToan.DataBindings.Clear();
            lb_DLDonGia.DataBindings.Clear();
            lb_DLMaHD.DataBindings.Add(new Binding("Text", bills, "MaHD"));
            lb_DLMaPhong.DataBindings.Add(new Binding("Text", bills, "MaPhong"));
            lb_DLSoNgayThue.DataBindings.Add(new Binding("Text", bills, "SoNgayThue"));
            lb_DLThanhTien.DataBindings.Add(new Binding("Text", bills, "ThanhTien"));
            lb_DLNgayThanhToan.DataBindings.Add(new Binding("Text", bills, "NgayThanhToan"));
            lb_DLDonGia.DataBindings.Add(new Binding("Text", bills, "DonGia"));
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            name = tb_DLTenKH.Text;
            personalID = tb_DLCMND.Text;
            DataTable bills = BillDetailsDAO.Instance.GetUnCheckedBillsByGuestInfo(name, personalID);
            if (bills.Rows.Count > 0)
            {
                LoadData();
            }
            else
            {
                MessageBox.Show("Khách hàng không tồn tại");
            }    
        }
    }
}
