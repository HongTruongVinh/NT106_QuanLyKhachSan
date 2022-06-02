using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan_CLient.DAO;
using QuanLyKhachSan_CLient.DTO;

namespace QuanLyKhachSan_CLient
{
    public partial class fAdmin : Form
    {
        BindingSource listRoom = new BindingSource();

        BindingSource listTypeRoom = new BindingSource();

        public fAdmin()
        {
            InitializeComponent();

            SetDefaultControls();

            Load();
        }

        #region methods
        void SetDefaultControls()
        {
            dgv_Room.DataSource = listRoom;

            dgv_TypeRoom.DataSource = listTypeRoom;

            cbb_TypeRoom.DropDownStyle = ComboBoxStyle.DropDownList;

            nud_MaxPeople.Maximum = 10;
            nud_MaxPeople.Minimum = 1;
            nud_PriceForCountCLient.Maximum = 10;
            nud_PriceForCountCLient.Minimum = 1;
        }

        void Load()
        {

            LoadAccountList();
            LoadRoomList();
            LoadCategoryRoom();
            LoadCategoryRoomIntoCBB(cbb_TypeRoom);


            AddRoomBinding();
            AddTypeRoomBinding();
            LoadDateTimePickerBill();
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

        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        } 
        #endregion

        #region events
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
                    if (dgv_Room.SelectedCells[0].OwningRow.Cells["Mã loại phòng"].Value == null)
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
            var result = MessageBox.Show("Bạn có chắc muốn sửa?", "Thông báo", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

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
            var result = MessageBox.Show("Bạn có chắc muốn XÓA?", "Thông báo", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

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

        private void btn_EditTypeRoom_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn sửa?", "Thông báo", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            string name = tb_NameTypeRoom.Text;
            int price = Convert.ToInt32(tb_PriceTypeRoom.Text);
            int id = Convert.ToInt32(tb_idTypeRoom.Text);

            if (TypeRoomDAO.Instance.Update(id, name, price))
            {
                MessageBox.Show("Sửa danh mục phòng thành công!");
                LoadCategoryRoom();
                LoadCategoryRoomIntoCBB(cbb_TypeRoom);
            }
            else
            {
                MessageBox.Show("!!!Lỗi sửa danh mục phòng không thành công!!!");
            }
        }

        private void btn_DeleteTypeRoom_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn XÓA?", "Thông báo", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            int id = Convert.ToInt32(tb_idTypeRoom.Text);

            if (TypeRoomDAO.Instance.Delete(id))
            {
                MessageBox.Show("Xóa danh mục phòng thành công!");
                LoadCategoryRoom();
                LoadCategoryRoomIntoCBB(cbb_TypeRoom);
            }
            else
            {
                MessageBox.Show("!!!Lỗi xóa danh mục phòng không thành công!!!");
            }
        }

        private void tb_Surcharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_SurchargeForeign_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }
        #endregion

        #region Them xoa sua account
        private void btn_AddAccount_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_UserName.Text) || String.IsNullOrEmpty(tb_DisplayName.Text) || String.IsNullOrEmpty(tb_Password.Text))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
                return;
            }

            if (AccountDAO.Instance.Insert(tb_UserName.Text, tb_DisplayName.Text, tb_Password.Text))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Lỗi!!! Thêm tài khoản không thành công");
            }
        }
        private void btn_DeleteAccount_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.Delete(tb_UserName.Text))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Lỗi!!! Xóa tài khoản không thành công");
            }
        }
        private void btn_ResetAccount_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.ResetPassword(tb_UserName.Text, "1"))
            {
                MessageBox.Show("Reset mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Lỗi!!! Reset mật khẩu không thành công");
            }
        }

        #endregion

    }
}
