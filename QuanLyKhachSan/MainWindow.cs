using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            tlp_Menu.Hide();
            panel2startPosition = new Point(tlp_Window.Location.X, tlp_Window.Location.Y);
            tlp_Window.Location = new Point(12, 13);
            tlp_Window.Size = new Size(2000, 2000);
            pn_MenuOnWD.Size = new Size(pn_MenuOnWD.Width, 1000);

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btn_Menu, "Tùy chọn");
        }

        bool menuIsHide = true;
        Point panel2startPosition;

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            if (menuIsHide)
            {
                tlp_Menu.Show();
                pn_MenuOnWD.Hide();
                menuIsHide = false;
                tlp_Window.Location = panel2startPosition;
            }
            else
            {
                tlp_Menu.Hide();
                pn_MenuOnWD.Show();
                menuIsHide = true;
                tlp_Window.Location = new Point(12, 13);
            }
        }

        private void btn_MenuOnMenu_Click(object sender, EventArgs e)
        {
            btn_Menu_Click(sender, e);
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            fAdmin fAdmin = new fAdmin();
            fAdmin.ShowDialog();
        }

        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AccountInfo_Click(object sender, EventArgs e)
        {
            fInformation fInformation = new fInformation();
            fInformation.ShowDialog();
        }

        private void btn_Booking_Click(object sender, EventArgs e)
        {
            fLoadRoom fLoadRoom = new fLoadRoom();
            fLoadRoom.ShowDialog();
        }

        private void btn_GuestMgmt_Click(object sender, EventArgs e)
        {
            fGuestMgmt fGuestMgmt = new fGuestMgmt();
            fGuestMgmt.ShowDialog();
        }

        private void btn_BillMgmt_Click(object sender, EventArgs e)
        {
            fBillMgmt fBillMgmt = new fBillMgmt();
            fBillMgmt.ShowDialog();
        }

        private void btn_RoomMgmt_Click(object sender, EventArgs e)
        {
            fListRentalVoucher fListRentalVoucher = new fListRentalVoucher();
            fListRentalVoucher.ShowDialog();
        }
    }
}
