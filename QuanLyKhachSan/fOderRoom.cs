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
    public partial class fOderRoom : Form
    {
        public fOderRoom()
        {
            InitializeComponent();


            //LoadRoomList();

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

                //if (room.Type == "Vip")
                //{
                //    btn.Text = btn.Text + Environment.NewLine + "VIP";
                //    btn.Font = new Font(Font, FontStyle.Bold);
                //    btn.ForeColor = Color.Red;
                //}

                //switch (room.Status)
                //{
                //    case "Trống":
                //        btn.BackColor = Color.Aqua;
                //        break;
                //    default:
                //        btn.BackColor = Color.LightPink;
                //        break;
                //}

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
