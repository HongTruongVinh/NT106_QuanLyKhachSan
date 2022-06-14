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
using System.Data;

namespace QuanLyKhachSan
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
            dgv_ListAccClient.AllowUserToAddRows= false;
            dgv_ListAccClient.ReadOnly = false;
            dgv_ListAccEmployee.AllowUserToAddRows = false;
            dgv_ListAccEmployee.ReadOnly = false;

            pn_AddAccEmployee.Hide();

            dgv_Room.DataSource = listRoom;

            dgv_TypeRoom.DataSource = listTypeRoom;

            cbb_TypeRoom.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        void Load()
        {

            LoadAccountListEmployee();
            LoadAccountListClient();
            LoadRoomList();
            LoadCategoryRoom();
            LoadCategoryRoomIntoCBB(cbb_TypeRoom);


            AddRoomBinding();
            AddTypeRoomBinding();

            LoadListYear();
            LoadDefaultData();
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

        void LoadAccountListEmployee()
        {
            try
            {
                dgv_ListAccEmployee.DataSource = AccountDAO.Instance.GetListAccountEmployee();
                dgv_ListAccEmployee.Columns[1].ReadOnly = true;
                dgv_ListAccEmployee.Columns[2].ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("!!!Không thể hiển thị danh sách tài khoản nhân viên!!!");
            }
        }

        void LoadAccountListClient()
        {
            try
            {
                dgv_ListAccClient.DataSource = AccountDAO.Instance.GetListAccountClient();
                dgv_ListAccClient.Columns[1].ReadOnly = true;
                dgv_ListAccClient.Columns[2].ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("!!!Không thể hiển thị danh sách tài khoản KH!!!");
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

        /*DOANH THU VÀ BIỂU ĐỒ*/
        void LoadListYear()
        {
            for (int i = 2015; i <= DateTime.Now.Year; i++)
            {
                cmbYear.Items.Add(i);
            }

            cmbYear.SelectedItem = DateTime.Now.Year;
        }

        void ShowTurnoverByYear()
        {
            dtgvBill.DataSource = BillDAO.Instance.TurnoverByYear((int)cmbYear.SelectedItem);
        }

        void ShowAmountBillMoney()
        {
            txbAmount.Text = BillDAO.Instance.GetAmountBillMoney((int)cmbYear.SelectedItem).ToString();
        }


        /*ĐIỀU CHỈNH ĐIỀU KHOẢN*/


        private void LoadDefaultData()
        {
            DataRow data = null;
            data = RegulationDAO.Instance.GetListParameter().Rows[0];
            txbMaxCustomerPerRoom.Text = data["KhachToiDa"].ToString();
            txbBasePrice.Text = data["DonGiaPhongCho"].ToString();
            tb_Surcharge.Text = data["PhuThuTuKhach"].ToString();
            tb_SurchargeForeign.Text = data["PhuThuTuKhachNuocNgoai"].ToString();
        }

        private void checkInt(string dataIn, out int dataOut)
        {
            dataOut = 0;
            if (dataIn != "")
            {
                if (!Int32.TryParse(dataIn, out dataOut))
                {
                    MessageBox.Show("Vui lòng chỉ nhập số!");
                    return;
                }

                if (dataOut < 0)
                {
                    MessageBox.Show("Vui lòng nhập số nguyên dương!");
                    return;
                }
            }
        }

        private void checkFloat(string dataIn, out float dataOut)
        {
            dataOut = 0;
            if (dataIn != "")
            {
                if (!float.TryParse(dataIn, out dataOut))
                {
                    MessageBox.Show("Vui lòng chỉ nhập số!");
                    return;
                }

                if (dataOut < 0)
                {
                    MessageBox.Show("Vui lòng nhập số dương!");
                    return;
                }
            }
        }

        private void Update_KhachToiDa()
        {
            if (txbMaxCustomerPerRoom.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào ô 'Số khách tối đa cho mỗi phòng'!");
            }
            else
            {
                int result;
                checkInt(txbMaxCustomerPerRoom.Text, out result);
                if (RegulationDAO.Instance.Update_KhachToiDa(result))
                    MessageBox.Show("Cập nhật Số khách tối đa mỗi phòng thành công!");
                else
                    MessageBox.Show("Cập nhật Số khách tối đa mỗi phòng thất bại!");
            }

        }

        private void Update_DonGiaPhongCho()
        {
            if (txbBasePrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào ô 'Đơn giá phòng trọ'!");
            }
            else
            {
                int result;
                checkInt(txbBasePrice.Text, out result);
                if (RegulationDAO.Instance.Update_DonGiaPhongCho(result))
                    MessageBox.Show("Cập nhật Đơn giá phòng trọ thành công!");
                else
                    MessageBox.Show("Cập nhật Đơn giá phòng trọ thất bại!");
            }
        }

        private void Update_PhuThuTuKhach()
        {
            if (tb_Surcharge.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào ô 'Phụ thu từ khách'!");
            }
            else
            {
                float result;
                checkFloat(tb_Surcharge.Text, out result);
                if (RegulationDAO.Instance.Update_PhuThuTuKhach(result))
                    MessageBox.Show("Cập nhật Phụ thu từ khách thành công!");
                else
                    MessageBox.Show("Cập nhật Phụ thu từ khách thất bại!");
            }
        }

        private void Update_PhuThuTuKhachNuocNgoai()
        {
            if (tb_SurchargeForeign.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào ô 'Phụ thu từ khách nước ngoài'!");
            }
            else
            {
                float result;
                checkFloat(tb_SurchargeForeign.Text, out result);
                if (RegulationDAO.Instance.Update_PhuThuTuKhachNuocNgoai(result))
                    MessageBox.Show("Cập nhật Phụ thu từ khách nước ngoài thành công!");
                else
                    MessageBox.Show("Cập nhật Phụ thu từ khách nước ngoài thất bại!");
            }
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb_SurchargeForeign_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        //DOANH THU VÀ BIỂU ĐỒ
        private void cmbYear_SelectedValueChanged(object sender, EventArgs e)
        {
            ShowTurnoverByYear();
            ShowAmountBillMoney();

            this.CmbYear = (int)cmbYear.SelectedItem;
        }

        private void btnShowChart_Click(object sender, EventArgs e)
        {
            fChart f = new fChart(this);
            f.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Update_KhachToiDa();
                Update_DonGiaPhongCho();
                Update_PhuThuTuKhach();
                Update_PhuThuTuKhachNuocNgoai();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadDefaultData();
        }
        //ĐIỀU CHỈNH ĐIỀU KHOẢN
        #endregion

        #region Them xoa sua account Employee
        private void btn_AddAccount_Click(object sender, EventArgs e)
        {
            pn_AddAccEmployee.Show();
        }
        private void btn_SaveAccEmployee_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_UserName.Text) || String.IsNullOrEmpty(tb_DisplayName.Text) || String.IsNullOrEmpty(tb_Password.Text))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
                return;
            }

            string newPassword = fLogin.MD5(tb_Password.Text);

            if (AccountDAO.Instance.Insert(tb_UserName.Text, tb_DisplayName.Text, newPassword))
            {
                MessageBox.Show("Thêm tài khoản thành công");
                LoadAccountListEmployee();
            }
            else
            {
                MessageBox.Show("Lỗi!!! Thêm tài khoản không thành công");
            }

            pn_AddAccEmployee.Hide();
        }
        private void btn_DeleteAccount_Click(object sender, EventArgs e)
        {
            string message = "Bạn có muốn xóa không?";
            string title = "Thông báo";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result != DialogResult.Yes)
            {
                return;
            }

            List<string> listAccountChecked = new List<string>();
            for (int i = 0; i < dgv_ListAccEmployee.Rows.Count; i++)
            {
                bool isChecked = false;

                try
                {
                    isChecked = (bool)dgv_ListAccEmployee.Rows[i].Cells["BooleanValue"].Value;
                }
                catch
                {

                }

                if (isChecked)
                {
                    listAccountChecked.Add((string)dgv_ListAccEmployee.Rows[i].Cells["TenDangNhap"].Value);
                }
            }

            for (int i = 0; i < dgv_ListAccEmployee.Rows.Count; i++)
            {
                bool isChecked = false;

                try
                {
                    isChecked = (bool)dgv_ListAccEmployee.Rows[i].Cells["BooleanValue"].Value;
                }
                catch
                {

                }

                if (isChecked)
                {
                    listAccountChecked.Add((string)dgv_ListAccEmployee.Rows[i].Cells["TenDangNhap"].Value);
                }
            }

            if (listAccountChecked.Count == 0)
            {
                MessageBox.Show("Hãy chọn ít nhất 1 người để xóa!");
                return;
            }

            int success = AccountDAO.Instance.DeleteListAccEmployee(listAccountChecked);
            MessageBox.Show("Đã xóa " + success + " tài khoản nhân viên");
            LoadAccountListEmployee();
        }
        private void btn_ResetAccount_Click(object sender, EventArgs e)
        {
            string message = "Bạn có muốn reset không?";
            string title = "Thông báo";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result != DialogResult.Yes)
            {
                return;
            }

            List<string> listAccountChecked = new List<string>();
            for (int i = 0; i < dgv_ListAccEmployee.Rows.Count; i++)
            {
                bool isChecked = false;

                try
                {
                    isChecked = (bool)dgv_ListAccEmployee.Rows[i].Cells["BooleanValue"].Value;
                }
                catch
                {

                }

                if (isChecked)
                {
                    listAccountChecked.Add((string)dgv_ListAccEmployee.Rows[i].Cells["TenDangNhap"].Value);
                }
            }

            for (int i = 0; i < dgv_ListAccEmployee.Rows.Count; i++)
            {
                bool isChecked = false;

                try
                {
                    isChecked = (bool)dgv_ListAccEmployee.Rows[i].Cells["BooleanValue"].Value;
                }
                catch
                {

                }

                if (isChecked)
                {
                    listAccountChecked.Add((string)dgv_ListAccEmployee.Rows[i].Cells["TenDangNhap"].Value);
                }
            }

            if (listAccountChecked.Count == 0)
            {
                MessageBox.Show("Hãy chọn 1 người để reset!");
                return;
            }

            for (int i = 0; i < listAccountChecked.Count; i++)
            {
                for (int j = i + 1; j < listAccountChecked.Count; j++)
                {
                    if (listAccountChecked[j] == listAccountChecked[i])
                    {
                        listAccountChecked.RemoveAt(j);
                    }
                }
            }

            if (listAccountChecked.Count > 1)
            {
                MessageBox.Show("Chỉ được chọn 1 người để reset!");
                return;
            }

            string newPassword = fLogin.MD5("0");

            if (AccountDAO.Instance.ResetPassword(listAccountChecked[0], newPassword))
            {
                MessageBox.Show("Reset mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Lỗi!!! Reset mật khẩu không thành công");
            }
        }

        #endregion


        #region GETSET FUNCTION
        public int CmbYear
        {
            get { if (cmbYear.SelectedItem == null) return 0; return (int)cmbYear.SelectedItem; }
            set { cmbYear.SelectedItem = value; }
        }


        #endregion

        

        private void btn_Delete_AccClient_Click(object sender, EventArgs e)
        {
            string message = "Bạn có muốn xóa không?";
            string title = "Thông báo";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result != DialogResult.Yes)
            {
                return;
            }

            List<string> listAccountChecked = new List<string>();
            for (int i = 0; i < dgv_ListAccClient.Rows.Count; i++)
            {
                bool isChecked = false;

                try
                {
                    isChecked = (bool)dgv_ListAccClient.Rows[i].Cells["BooleanValue"].Value;
                }
                catch
                {

                }

                if (isChecked)
                {
                    listAccountChecked.Add((string)dgv_ListAccClient.Rows[i].Cells["TenDangNhap"].Value);
                }
            }

            for (int i = 0; i < dgv_ListAccClient.Rows.Count; i++)
            {
                bool isChecked = false;

                try
                {
                    isChecked = (bool)dgv_ListAccClient.Rows[i].Cells["BooleanValue"].Value;
                }
                catch
                {

                }

                if (isChecked)
                {
                    listAccountChecked.Add((string)dgv_ListAccClient.Rows[i].Cells["TenDangNhap"].Value);
                }
            }

            if (listAccountChecked.Count == 0)
            {
                MessageBox.Show("Hãy chọn ít nhất 1 tài khoản để xóa!");
                return;
            }

            int success = AccountDAO.Instance.DeleteListAccEmployee(listAccountChecked);
            MessageBox.Show("Đã xóa " + success + " tài khoản khách hàng");
            LoadAccountListClient();
        }

        private void btn_ResetAccClient_Click(object sender, EventArgs e)
        {
            string message = "Bạn có muốn reset không?";
            string title = "Thông báo";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result != DialogResult.Yes)
            {
                return;
            }

            List<string> listAccountChecked = new List<string>();
            for (int i = 0; i < dgv_ListAccClient.Rows.Count; i++)
            {
                bool isChecked = false;

                try
                {
                    isChecked = (bool)dgv_ListAccClient.Rows[i].Cells["BooleanValue"].Value;
                }
                catch
                {

                }

                if (isChecked)
                {
                    listAccountChecked.Add((string)dgv_ListAccClient.Rows[i].Cells["TenDangNhap"].Value);
                }
            }

            for (int i = 0; i < dgv_ListAccClient.Rows.Count; i++)
            {
                bool isChecked = false;

                try
                {
                    isChecked = (bool)dgv_ListAccClient.Rows[i].Cells["BooleanValue"].Value;
                }
                catch
                {

                }

                if (isChecked)
                {
                    listAccountChecked.Add((string)dgv_ListAccClient.Rows[i].Cells["TenDangNhap"].Value);
                }
            }

            if (listAccountChecked.Count == 0)
            {
                MessageBox.Show("Hãy chọn 1 người để reset!");
                return;
            }

            for (int i = 0; i < listAccountChecked.Count; i++)
            {
                for (int j = i + 1; j < listAccountChecked.Count; j++)
                {
                    if (listAccountChecked[j] == listAccountChecked[i])
                    {
                        listAccountChecked.RemoveAt(j);
                    }
                }
            }

            if (listAccountChecked.Count > 1)
            {
                MessageBox.Show("Chỉ được chọn 1 người để reset!");
                return;
            }

            string newPassword = fLogin.MD5("0");

            if (AccountDAO.Instance.ResetPassword(listAccountChecked[0], newPassword))
            {
                MessageBox.Show("Reset mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Lỗi!!! Reset mật khẩu không thành công");
            }
        }
    }
}
