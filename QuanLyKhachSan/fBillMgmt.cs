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

namespace QuanLyKhachSan
{
    public partial class fBillMgmt : Form
    {
        public fBillMgmt()
        {
            InitializeComponent();

            dgv_DSHD.DataSource = BillDAO.Instance.GetUnpaidBills();

            tb_MaHD.DataBindings.Add(new Binding("Text", dgv_DSHD.DataSource, "Mã HD"));
            lb_DLTriGia.DataBindings.Add(new Binding("Text", dgv_DSHD.DataSource, "Trị Giá"));
        }


        private void tb_MaHD_TextChanged(object sender, EventArgs e)
        {
            int billId = int.Parse(tb_MaHD.Text);
            BillDetails billDetails = BillDetailsDAO.Instance.GetBillDetailsByBillID(billId);
            lb_DLMaPhong.Text = billDetails.RoomId.ToString();
            lb_DLSoNgayThue.Text = billDetails.Days.ToString();
            lb_DLThanhTien.Text = billDetails.Price.ToString();
            lb_DLNgayThanhToan.Text = billDetails.Date.ToString("dd/MM/yyyy");
            lb_DLDonGia.Text = billDetails.Amount.ToString();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            int billId = int.Parse(tb_MaHD.Text);
            if (BillDetailsDAO.Instance.PayBillByBillID(billId))
            {
                MessageBox.Show("Thanh Toán Thành Công!");
                dgv_DSHD.DataSource = BillDAO.Instance.GetUnpaidBills();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra! Thanh Toán Không Thành Công!");
            }    
        }
    }
}
