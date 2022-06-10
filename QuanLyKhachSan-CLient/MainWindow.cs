using QuanLyKhachSan_CLient.Network;
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

namespace QuanLyKhachSan_CLient
{
    public partial class MainWindow : Form
    {

        bool menuIsHide = true;
        Point panel2startPosition;

        public MainWindow()
        {
            InitializeComponent();

            Load();
        }

        void Load()
        {
            pn_Menu.Hide();
            panel2startPosition = new Point(pn_Window.Location.X, pn_Window.Location.Y);
            pn_Window.Location = new Point(12, 13);
            pn_Window.Size = new Size(2000, 2000);
            pn_MenuOnWD.Size = new Size(pn_MenuOnWD.Width, 1000);

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btn_Menu, "Tùy chọn");

            this.FormClosing += MainWindow_FormClosing;

            if (User.Instance.TypeUser == "Admin")
            {
                
            }
            else if (User.Instance.TypeUser == "Employee")
            {
                btn_Admin.Enabled = false;
            }
            else
            {
                btn_Admin.Enabled = false;
                btn_AccountInfo.Enabled = false;
                btn_BillMgmt.Enabled = false;
                btn_GuestMgmt.Enabled = false;
                btn_RoomMgmt.Enabled = false;
            }

        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn tắt?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    TCPClient.Instance.TCPCLientStop();

                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }


        private void btn_Menu_Click(object sender, EventArgs e)
        {
            if (menuIsHide)
            {
                pn_Menu.Show();
                pn_MenuOnWD.Hide();
                menuIsHide = false;
                pn_Window.Location = panel2startPosition;
            }
            else
            {
                pn_Menu.Hide();
                pn_MenuOnWD.Show();
                menuIsHide = true;
                pn_Window.Location = new Point(12, 13);
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

        // Hover Effect
        private void btn_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(160)))), ((int)(((byte)(90)))));
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

        private void btn_Notice_Click(object sender, EventArgs e)
        {
            fNotice fNotice = new fNotice();
            fNotice.ShowDialog();
        }
    }
}
