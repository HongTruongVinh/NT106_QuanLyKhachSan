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
    public partial class fInforRoom : Form
    {
        public fInforRoom()
        {
            InitializeComponent();
        }

        public fInforRoom(Room room)
        {
            InitializeComponent();

            LoadInForRoom(room);
        }

        void LoadInForRoom(Room room)
        {
            //Load Infor Room
            tb_NameRoom.Text = room.Name;
            tb_TypeRoom.Text = room.Type;
            //tb_NoteRoom.Text=room.NoteRoom
            tb_Status.Text = room.Status;
            tb_Price.Text = room.Price.ToString();

            if(room.Status != "1")
            {
                return;
            }

            //Load infor Rental Voucher
                RentalVoucher rentalVoucher = RentalVoucherDAO.Instance.GetUnCheckRentalVoucherByRoomID(room.ID);
                tb_IDRentalVoucher.Text = rentalVoucher.ID.ToString();
                tb_NumberPeople.Text = rentalVoucher.NumberPeople.ToString();
                tb_DateStart.Text = rentalVoucher.DateTimeCheckIn.ToString();

            //Load infor Client
            Client client = ClientDAO.Instance.GetClientByID(rentalVoucher.ClientID);
            tb_IDPerson.Text = client.ID.ToString();
            tb_NameCLient.Text = client.Name;
            tb_Address.Text = client.Address;

            if (client.TypeClient == "NoiDia")
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
    }
}
