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
using QuanLyKhachSan_CLient.Network;

namespace QuanLyKhachSan_CLient
{
    public partial class fLoadRoom : Form
    {
        Timer timeToReload;

        public fLoadRoom()
        {
            InitializeComponent();

            this.FormClosing += FLoadRoom_FormClosing;

            SetDefulControl();

            LoadRoomList();
        }


        void SetDefulControl()
        {
            lb_TypeA.BackColor = Color.LightCyan;
            lb_TypeB.BackColor = Color.PaleTurquoise;
            lb_TypeC.BackColor = Color.Aqua;
            lb_Ordered.BackColor = Color.LightPink;

            timeToReload = new Timer();
            timeToReload.Tick += TimeToReload_Tick;
            timeToReload.Interval = 10000; // 10s Reload 1 lần 
            //timeToReload.Start();
        }

        private void TimeToReload_Tick(object sender, EventArgs e)
        {
            LoadRoomList();
        }

        #region Method



        public void LoadRoomList()
        {
            flp_LoadRooms.Controls.Clear();

            List<Room> roomList = RoomDAO.Instance.GetRoomList(); 

            foreach (Room room in roomList)
            {
                Button btn = new Button() { Width = RoomDAO.RoomWidth, Height = RoomDAO.RoomHeight }; 
                btn.Click += Room_Click;
                btn.Tag = room;
                btn.Margin = new Padding(10, 30, 30, 0);

                string statusRoom = "...";

                switch (room.Status)
                {
                    case "1":
                        btn.BackColor = Color.LightPink;
                        statusRoom = "có người";
                        break;
                    default:
                        if(room.Type == "A")
                        {
                            btn.BackColor = Color.LightCyan;
                        }
                        else if(room.Type == "B")
                        {
                            btn.BackColor = Color.PaleTurquoise;
                        }
                        else if(room.Type == "C")
                        {
                            btn.BackColor = Color.Aqua;
                        }
                        else
                        {

                        }

                        statusRoom = "Trống";

                        break;
                }

                btn.Text = room.Name + Environment.NewLine + "Hạng " + room.Type + Environment.NewLine +statusRoom;

                flp_LoadRooms.Controls.Add(btn);
            }
        }

        #endregion


        #region Event
        private void Room_Click(object sender, EventArgs e)
        {
            if (User.Instance.TypeUser == "Admin" || User.Instance.TypeUser == "Employee")
            {
                Button btn = (sender as Button);
                Room thisRoom = (Room)btn.Tag;
                fRentalVoucher fInforRoom = new fRentalVoucher(thisRoom, this);
                fInforRoom.Show();
            }
            else if(User.Instance.TypeUser == "Client")
            {
                Button btn = (sender as Button);
                Room thisRoom = (Room)btn.Tag;
                if (thisRoom.Status== "1")
                {
                    MessageBox.Show("Phòng này đã có người! Xin vui lòng đặt phòng khác."); return;
                }
                else
                {
                    fRentalVoucher fInforRoom = new fRentalVoucher(thisRoom, this);
                    fInforRoom.Show();
                }
                
            }
        }

        #endregion

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FLoadRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            timeToReload.Stop();
        }

        private void lb_Reload_Click(object sender, EventArgs e)
        {
            LoadRoomList();
        }

        private void btn_ListRoomOdered_Click(object sender, EventArgs e)
        {
            if(User.Instance.TypeUser == "Client")
            {
                fListOrderedRoom fListOrderedRoom = new fListOrderedRoom(this);
                fListOrderedRoom.ShowDialog();
            }
        }
    }
}
