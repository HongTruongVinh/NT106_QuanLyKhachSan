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

namespace QuanLyKhachSan_CLient
{
    public partial class fGuestMgmt : Form
    {
        public fGuestMgmt()
        {
            InitializeComponent();
            Load_client();
        }

        void Load_client()
        {
            dgv_TTKH.DataSource = ClientDAO.Instance.GetTableClient();

            Add_client_Binding();
        }


        void Add_client_Binding()
        {
            tb_MaKH.DataBindings.Add(new Binding("Text", dgv_TTKH.DataSource, "Mã khách hàng", true, DataSourceUpdateMode.Never));
            tb_HoTen.DataBindings.Add(new Binding("Text", dgv_TTKH.DataSource, "Họ và tên", true, DataSourceUpdateMode.Never));
            tb_SDT.DataBindings.Add(new Binding("Text", dgv_TTKH.DataSource, "Số điện thoại", true, DataSourceUpdateMode.Never));
            tb_ID.DataBindings.Add(new Binding("Text", dgv_TTKH.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            tb_DiaChi.DataBindings.Add(new Binding("Text", dgv_TTKH.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string hoten = tb_HoTen.Text;
            string sdt = tb_SDT.Text;
            string cmnd = tb_ID.Text;
            string diachi = tb_DiaChi.Text;
            if (ClientDAO.Instance.InsertClient(hoten, sdt, cmnd, diachi))
            {
                MessageBox.Show("Thêm khách hàng thành công");
                dgv_TTKH.DataSource = ClientDAO.Instance.GetTableClient();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm khách hàng");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tb_MaKH.Text);

            if (ClientDAO.Instance.DeleteClient(id, tb_ID.Text))
            {
                MessageBox.Show("Xóa khách hàng thành công");
                dgv_TTKH.DataSource = ClientDAO.Instance.GetTableClient();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa khách hàng");
            }
        }

        private void btn_CapNhap_Click(object sender, EventArgs e)
        {
            int makhachhang = Convert.ToInt32(tb_MaKH.Text);
            string hoten = tb_HoTen.Text;
            string sdt = tb_SDT.Text;
            string cmnd = tb_ID.Text;
            string diachi = tb_DiaChi.Text;

            if (ClientDAO.Instance.UpdateClient(makhachhang, hoten, sdt, cmnd, diachi))
            {
                MessageBox.Show("Sửa khách hàng thành công");
                dgv_TTKH.DataSource = ClientDAO.Instance.GetTableClient();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa khách hàng");
            }
        }
    }
}
