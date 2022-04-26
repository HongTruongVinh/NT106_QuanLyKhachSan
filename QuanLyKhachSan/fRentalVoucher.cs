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
    public partial class fRentalVoucher : Form
    {
        public fRentalVoucher()
        {
            InitializeComponent();
        }

        fLoadRoom fLoadRoom;

        RentalVoucher rentalVoucher;

        int maxCountPeople;

        public fRentalVoucher(Room room, fLoadRoom _fLoadRoom)
        {
            InitializeComponent();

            this.Tag = room;

            this.fLoadRoom = _fLoadRoom;

            LoadInforRentalVoucher(room);

            if (tb_IDPerson.Text == "")
            {
                btn_Edit.Enabled = false;
            }
        }

        void LoadInforRentalVoucher(Room room)
        {
            LoadRoomInfor(room);

            rentalVoucher = RentalVoucherDAO.Instance.GetUnCheckRentalVoucherByRoomID(room.ID);

            if(rentalVoucher == null)
            {
                return;
            }

            LoadCLientInfor(rentalVoucher.ClientID);

            LoadRentalVoucherInfor(room.ID);

        }

        void LoadCLientInfor(int idClient)
        {
            Client client = ClientDAO.Instance.GetClientByID(idClient);
            tb_IDClient.Text = client.ID.ToString();
            tb_IDPerson.Text = client.IDPerson.ToString();
            tb_NameCLient.Text = client.Name;
            tb_Address.Text = client.Address;
            tb_NumberPhone.Text = client.NumberPhone;
        }

        void LoadRoomInfor(Room room)
        {
            tb_NameRoom.Text = room.Name;
            tb_TypeRoom.Text = room.Type;
            tb_NoteRoom.Text = room.Note;
            tb_Status.Text = room.Status;
            tb_Price.Text = room.Price.ToString();

            if (room.Status != "1")
            {
                tb_DateStart.Text = DateTime.Today.ToString("dd/MM/yyyy");
                tb_Status.Text = "Trống";
                cbb_TypeClient.SelectedIndex = 1;
                return;
            }

            tb_Status.Text = "Có người";
        }

        void LoadRentalVoucherInfor(int idRoom)
        {
            RentalVoucher rentalVoucher = RentalVoucherDAO.Instance.GetUnCheckRentalVoucherByRoomID(idRoom);

            tb_IDRentalVoucher.Text = rentalVoucher.ID.ToString();
            tb_NumberPeople.Text = rentalVoucher.NumberPeople.ToString();
            tb_DateStart.Text = rentalVoucher.DateTimeCheckIn?.ToString("dd/MM/yyyy");
            tb_DateEnd.Text = rentalVoucher.DateTimeCheckOut?.ToString("dd/MM/yyyy");

            if (rentalVoucher.TypeClient == "NoiDia")
            {
                cbb_TypeClient.SelectedIndex = 0;
            }
            else
            {
                cbb_TypeClient.SelectedIndex = 1;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Nếu phòng đang có người thì không cho tạo phiếu thuê phòng mới
            if((this.Tag as Room).Status == "1")
            {
                MessageBox.Show("Phòng này đã có người");
                return;
            }


            #region kiểm tra và Inser CLient trước
            int idPerson = 0;
            idPerson = int.Parse(tb_IDPerson.Text);
            Client client = ClientDAO.Instance.GetClientByIDPerson(idPerson);

            if (client == null)
            {
                // Nếu client chưa tồn tại thì Insert client mới
                if (ClientDAO.Instance.InsertLient(tb_NameCLient.Text, idPerson, tb_NumberPhone.Text, tb_Address.Text))
                {
                    client = ClientDAO.Instance.GetClientByIDPerson(idPerson);
                }
                else
                {
                    MessageBox.Show("Isert CLient bị lỗi!");
                    return;
                }
            }
            #endregion

            #region sau đó Insert phiếu thuê phòng mới 
            int countPeople = 0;
            countPeople = Int32.Parse(tb_NumberPeople.Text);
            if (RentalVoucherDAO.Instance.InsertRentalVoucher((this.Tag as Room).ID, client.ID, cbb_TypeClient.SelectedIndex == 1 ? 1: 2, countPeople))
            {
                RoomDAO.Instance.UpdateStatusRoom((this.Tag as Room).ID, 1);
                MessageBox.Show("Thêm phiếu thuê phòng mới thành công!");
            }
            else
            {
                MessageBox.Show("!!!Thêm phiếu thuê phòng mới không thành công!!!");
            }
            #endregion

            LoadInforRentalVoucher(this.Tag as Room);
            fLoadRoom.LoadRoomList();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn sửa?", "Thông báo", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                Client cLient = ClientDAO.Instance.GetClientByID(rentalVoucher.ClientID);

                cLient.Name = tb_NameCLient.Text;
                cLient.IDPerson = Convert.ToInt32(tb_IDPerson.Text);
                cLient.NumberPhone = tb_NumberPhone.Text;
                cLient.Address = tb_Address.Text;

                int idTypeClient = -1;

                switch(cbb_TypeClient.SelectedIndex)
                {
                    case 1:
                        idTypeClient = 2;
                        break;
                    default:
                        idTypeClient = 1;
                        break;
                }

                int countPeople = Convert.ToInt32(tb_NumberPeople.Text);

                RentalVoucherDAO.Instance.UpdateRentalVoucher(rentalVoucher.ID, idTypeClient, countPeople, cLient);

                MessageBox.Show("Sửa thông tin phiếu thuê phòng thành công!");

            }
            catch
            {
                MessageBox.Show("!!!Lỗi sửa thông tin phiếu thuê phòng không thành công!!!");
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(tb_IDClient.Text == "" || tb_IDRentalVoucher.Text == "")
            {
                MessageBox.Show("Không có phiếu thuê phòng nào để xóa");
                return;
            }

            int idRentalVoucher = int.Parse(tb_IDRentalVoucher.Text);
            int idClient = int.Parse(tb_IDClient.Text);
            if (RentalVoucherDAO.Instance.DeleteRentalVoucher(idRentalVoucher, idClient))
            {
                RoomDAO.Instance.UpdateStatusRoom((this.Tag as Room).ID, 0);
                MessageBox.Show("Xóa phiếu thuê phòng thành công! ");
            }
            else
            {
                MessageBox.Show("!!!Xóa phiếu thuê phòng không thành công!!! ");
            }

            LoadInforRentalVoucher(this.Tag as Room);
            fLoadRoom.LoadRoomList();
        }

        private void tb_NumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_IDPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_NumberPeople_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
