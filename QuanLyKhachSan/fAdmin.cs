using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan
{
    public partial class fAdmin : Form
    {
        BindingSource listRoom = new BindingSource();

        BindingSource listTypeRoom = new BindingSource();

        public fAdmin()
        {
            InitializeComponent();

            Load();
        }

        void Load()
        {

            dgv_Room.DataSource = listRoom;

            dgv_TypeRoom.DataSource = listTypeRoom;

            cbb_TypeRoom.DropDownStyle = ComboBoxStyle.DropDownList;

            LoadAccountList();
            LoadRoomList();
            LoadCategoryRoom();
            LoadCategoryRoomIntoCBB(cbb_TypeRoom);


            AddRoomBinding();
            AddTypeRoomBinding();
        }

        void AddRoomBinding()
        {
            tb_NameRoom.DataBindings.Add(new Binding("Text", dgv_Room.DataSource, "Tên phòng", true, DataSourceUpdateMode.Never));
            tb_idRoom.DataBindings.Add(new Binding("Text", dgv_Room.DataSource, "Mã phòng", true, DataSourceUpdateMode.Never));
            tb_NoteRoom.DataBindings.Add(new Binding("Text", dgv_Room.DataSource, "Ghi chú", true, DataSourceUpdateMode.Never));
        }

        void AddTypeRoomBinding()
        {
            tb_idTypeRoom.DataBindings.Add(new Binding("Text", dgv_TypeRoom.DataSource, "Mã loại phòng", true, DataSourceUpdateMode.Never));
            tb_NameTypeRoom.DataBindings.Add(new Binding("Text", dgv_TypeRoom.DataSource, "Tên Loại phòng", true, DataSourceUpdateMode.Never));
            tb_PriceTypeRoom.DataBindings.Add(new Binding("Text", dgv_TypeRoom.DataSource, "Đơn giá", true, DataSourceUpdateMode.Never));
        }

        void LoadAccountList()
        {
            try
            {
                dgv_Account.DataSource = AccountDAO.Instance.GetListAccount();
            }
            catch
            {
                MessageBox.Show("!!!Không thể hiển thị danh sách tài khoản!!!");
            }
        }

        void LoadRoomList()
        {

            try
            {
                listRoom.DataSource = RoomDAO.Instance.GetRoomList("TiengViet");
                
            }
            catch
            {
                MessageBox.Show("!!!Không thể hiển thị danh sách phòng!!!");
            }
        }

        void LoadCategoryRoom()
        {
            try
            {
                listTypeRoom.DataSource = TypeRoomDAO.Instance.GetCategoryRoom("TiengViet");

            }
            catch
            {
                MessageBox.Show("!!!Không thể hiển thị danh mục phòng!!!");
            }
        }

        void LoadCategoryRoomIntoCBB(ComboBox cb)
        {
            cb.DataSource = TypeRoomDAO.Instance.GetCategoryRoom();
            cb.DisplayMember = "name";
        }

        private void btn_AddRoom_Click(object sender, EventArgs e)
        {
            int idTypeRoom = (cbb_TypeRoom.SelectedItem as TypeRoom).ID;

            if (RoomDAO.Instance.InsertRoom(idTypeRoom, tb_NameRoom.Text, tb_NoteRoom.Text))
            {
                MessageBox.Show("Thêm phòng mới thành công!");
                LoadRoomList();
            }
            else
            {
                MessageBox.Show("!!!Thêm phòng mới không thành công!!!");
            }
        }

        private void tb_idRoom_TextChanged(object sender, EventArgs e)
        {
            if (dgv_Room.SelectedCells.Count > 0)
            {
                try
                {
                    if(dgv_Room.SelectedCells[0].OwningRow.Cells["Mã loại phòng"].Value == null)
                    {
                        return;
                    }

                    int id = (int)dgv_Room.SelectedCells[0].OwningRow.Cells["Mã loại phòng"].Value;

                    TypeRoom typeRoom = TypeRoomDAO.Instance.GetCategoryByID(id);

                    cbb_TypeRoom.SelectedItem = typeRoom;

                    int index = -1;
                    int i = 0;

                    foreach (TypeRoom item in cbb_TypeRoom.Items)
                    {
                        if (item.ID == typeRoom.ID)
                        {
                            index = i;
                            break;
                        }

                        i++;
                    }

                    cbb_TypeRoom.SelectedIndex = index;
                }
                catch
                {

                }
            }
        }

        private void btn_EditRoom_Click(object sender, EventArgs e)
        {
            string name = tb_NameRoom.Text;
            int id = Convert.ToInt32(tb_idRoom.Text);
            int idTpeRoom = (cbb_TypeRoom.SelectedItem as TypeRoom).ID;
            string note = tb_NoteRoom.Text;

            if (RoomDAO.Instance.UpdateRoom(id, idTpeRoom, name, note))
            {
                MessageBox.Show("Sửa thông tin phòng thành công!");
                LoadRoomList();
            }
            else
            {
                MessageBox.Show("!!!Lỗi sửa thông tin phòng không thành công!!!");
            }
        }

        private void btn_DeleteRoom_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tb_idRoom.Text);

            if (RoomDAO.Instance.DeleteRoom(id))
            {
                MessageBox.Show("Xóa phòng thành công!");
                LoadRoomList();
            }
            else
            {
                MessageBox.Show("!!!Lỗi xóa phòng không thành công!!!");
            }
        }

        private void btn_AddTypeRoom_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(tb_PriceTypeRoom.Text);

            if (TypeRoomDAO.Instance.Insert(tb_NameTypeRoom.Text, price))
            {
                MessageBox.Show("Thêm loại phòng mới thành công!");
                LoadCategoryRoom();
                LoadCategoryRoomIntoCBB(cbb_TypeRoom);
            }
            else
            {
                MessageBox.Show("!!!Lỗi thêm loại phòng mới không thành công!!!");
            }
        }
    }
}
