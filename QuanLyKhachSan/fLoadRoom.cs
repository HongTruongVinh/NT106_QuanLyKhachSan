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
    public partial class fLoadRoom : Form
    {
        public fLoadRoom()
        {
            InitializeComponent();

            SetDefulControl();

            LoadRoomList();
        }

        void SetDefulControl()
        {
            lb_TypeA.BackColor = Color.LightCyan;
            lb_TypeB.BackColor = Color.PaleTurquoise;
            lb_TypeC.BackColor = Color.Aqua;
            lb_Ordered.BackColor = Color.LightPink;
        }

        #region Method

        void LoadRoomList()
        {
            List<Room> roomList = RoomDAO.Instance.LoadRoomList(); 

            foreach (Room room in roomList)
            {
                Button btn = new Button() { Width = RoomDAO.RoomWidth, Height = RoomDAO.RoomHeight };

                btn.Text = room.Name + Environment.NewLine + room.Status;

                btn.Click += Room_Click;
                btn.Tag = room;

                btn.Margin = new Padding(10, 30, 30, 0);

                switch (room.Status)
                {
                    case "1":
                        btn.BackColor = Color.LightPink;
                        btn.Text = room.ID + "\n" + "có người";
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
                        else
                        {
                            btn.BackColor = Color.Aqua;
                        }

                        btn.Text = room.ID + "\n" + "Trống";

                        break;
                }

                flp_1stFloor.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {

        }

        #endregion


        #region Event
        private void Room_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            Room thisRoom = (Room)btn.Tag;
            fInforRoom fInforRoom = new fInforRoom();
            fInforRoom.ShowDialog();
        }

        private void btn_AddBill_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
