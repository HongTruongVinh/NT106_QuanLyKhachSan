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
    public partial class fListRentalVoucher : Form
    {
        BindingSource listRentalVoucher = new BindingSource();

        RentalVoucher rentalVoucher;

        public fListRentalVoucher()
        {
            InitializeComponent();

            Load();
        }

        

        void SetDefaultControls()
        {
            dgv_ListRentalVoucher.DataSource =listRentalVoucher;

            this.Size = new Size(1280, 690);

            cbb_TypeClient.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        #region FUNCTION
        void Load()
        {

            SetDefaultControls();

            LoadInforRentalVoucher();


            AddBinding();
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
        
        // SỬA PHIẾU ĐẶT CHỖ
        void LoadRentalVoucher(int MaPhieu)
        {
            rentalVoucher = RentalVoucherDAO.Instance.GetUnCheckRentalVoucherByID(MaPhieu);
        }
        #endregion

        #region EVENTS
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

        private void btn_EditRV_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn sửa?", "Thông báo", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                int maPhieu = Int32.Parse(tb_IdRentalVoucher.Text);
                LoadRentalVoucher(maPhieu);
                Client cLient = ClientDAO.Instance.GetClientByID(rentalVoucher.ClientID);


                cLient.Name = tb_NameClient.Text;
                cLient.IDPerson = Convert.ToInt32(tb_IdPerson.Text);
                cLient.NumberPhone = tb_NumberPhone.Text;
                cLient.Address = tb_Address.Text;

                int idTypeClient = -1;

                switch (cbb_TypeClient.SelectedIndex)
                {
                    case 1:
                        idTypeClient = 2;
                        break;
                    default:
                        idTypeClient = 1;
                        break;
                }

                int countPeople = Convert.ToInt32(tb_CountClient.Text);

                RentalVoucherDAO.Instance.UpdateRentalVoucher(rentalVoucher.ID, idTypeClient, countPeople, cLient);

                MessageBox.Show("Sửa thông tin phiếu thuê phòng thành công!");
                LoadInforRentalVoucher();

            }
            catch
            {
                MessageBox.Show("!!!Lỗi sửa thông tin phiếu thuê phòng không thành công!!!");
            }
        }
        #endregion
    }
}
