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
    public partial class fListRentalVoucher : Form
    {
        BindingSource listRentalVoucher = new BindingSource();

        public fListRentalVoucher()
        {
            InitializeComponent();

            Load();
        }

        void Load()
        {

            SetDefaultControls();

            LoadInforRentalVoucher();


            AddBinding();
        }

        void SetDefaultControls()
        {
            dgv_ListRentalVoucher.DataSource =listRentalVoucher;

            this.Size = new Size(1280, 690);

            cbb_TypeClient.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        void AddBinding()
        {
            tb_NameRoom.DataBindings.Add(new Binding("Text", dgv_ListRentalVoucher.DataSource, "Phòng", true, DataSourceUpdateMode.Never));
            tb_IdRentalVoucher.DataBindings.Add(new Binding("Text", dgv_ListRentalVoucher.DataSource, "MaPhieu", true, DataSourceUpdateMode.Never));
            tb_IdPerson.DataBindings.Add(new Binding("Text", dgv_ListRentalVoucher.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            tb_NumberPhone.DataBindings.Add(new Binding("Text", dgv_ListRentalVoucher.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            tb_DateStart.DataBindings.Add(new Binding("Text", dgv_ListRentalVoucher.DataSource, "Ngày bắt đầu", true, DataSourceUpdateMode.Never));
            tb_CountClient.DataBindings.Add(new Binding("Text", dgv_ListRentalVoucher.DataSource, "Số khách", true, DataSourceUpdateMode.Never));
            tb_NameClient.DataBindings.Add(new Binding("Text", dgv_ListRentalVoucher.DataSource, "Khách hàng", true, DataSourceUpdateMode.Never));
            tb_Address.DataBindings.Add(new Binding("Text", dgv_ListRentalVoucher.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));
            tb_IdClient.DataBindings.Add(new Binding("Text", dgv_ListRentalVoucher.DataSource, "MaKH", true, DataSourceUpdateMode.Never));
            tb_IdRoom.DataBindings.Add(new Binding("Text", dgv_ListRentalVoucher.DataSource, "MaPhong", true, DataSourceUpdateMode.Never));
        }

        void LoadInforRentalVoucher()
        {
            dgv_ListRentalVoucher.Columns.Clear();
            dgv_ListRentalVoucher.DataSource = RentalVoucherDAO.Instance.ListRentalVoucherUnCheckOut("TiengViet");

        }

        private void btn_DeleteRV_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn XÓA?", "Thông báo", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            int idRV = Convert.ToInt32(tb_IdRentalVoucher.Text);
            int idClient = Convert.ToInt32(tb_IdClient.Text);
            int idRoom = Convert.ToInt32(tb_IdRoom.Text);

            if (RentalVoucherDAO.Instance.DeleteRentalVoucher(idRV, idClient))
            {
                RoomDAO.Instance.UpdateStatusRoom(idRoom, 0);
                MessageBox.Show("Xóa phiếu thuê phòng thành công! ");
                LoadInforRentalVoucher();
            }
            else
            {
                MessageBox.Show("!!!Xóa phiếu thuê phòng không thành công!!! ");
            }
        }

        private void tb_NameRoom_TextChanged(object sender, EventArgs e)
        {
            if (dgv_ListRentalVoucher.SelectedCells.Count > 0)
            {
                try
                {
                    if (dgv_ListRentalVoucher.SelectedCells[0].OwningRow.Cells["loại khách"].Value == null)
                    {
                        return;
                    }

                    int loaiKH = (int)dgv_ListRentalVoucher.SelectedCells[0].OwningRow.Cells["loại khách"].Value;

                    if(loaiKH == 1)
                    {
                        cbb_TypeClient.SelectedIndex = 0;
                    }
                    else
                    {
                        cbb_TypeClient.SelectedIndex = 1;
                    }
                }
                catch
                {

                }
            }
        }
    }
}
