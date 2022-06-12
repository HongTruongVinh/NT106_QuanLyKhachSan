using QuanLyKhachSan_CLient.DAO;
using QuanLyKhachSan_CLient.Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan_CLient
{
    public partial class fListOrderedRoom : Form
    {
        fLoadRoom fLoadRoom = null;
        public fListOrderedRoom(fLoadRoom fLoadRoom)
        {
            InitializeComponent();

            this.fLoadRoom = fLoadRoom;

            Load();
        }

        void Load()
        {
            LoadListRoomOrdered();
        }

        void LoadListRoomOrdered()
        {
            dgv_LiadRoomOrdered.DataSource = RoomDAO.Instance.ListRoomOrdered(User.Instance.UserName);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string message = "Bạn có muốn xóa những phòng đã đặt này?";
            string title = "Thông báo";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int success = 0;
                for (int i = 0; i < dgv_LiadRoomOrdered.SelectedCells.Count; i++)
                {
                    int id = (int)dgv_LiadRoomOrdered.SelectedCells[i].OwningRow.Cells["MaPhong"].Value;

                    if (RentalVoucherDAO.Instance.ClientDeleteRoomOrdered(User.Instance.UserName,id.ToString()))
                    {
                        success++;
                    }
                }

                LoadListRoomOrdered();
                fLoadRoom.LoadRoomList();
            }
            else
            {

            }
        }
    }
}
