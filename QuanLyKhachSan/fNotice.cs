using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class fNotice : Form
    {
        BindingSource bindingNotice = new BindingSource();

        void AddNoticeBinding()
        {
            tb_Subject.DataBindings.Add(new Binding("Text", dgv_ListNotice.DataSource, "TieuDe", true, DataSourceUpdateMode.Never));
            rtb_Content.DataBindings.Add(new Binding("Text", dgv_ListNotice.DataSource, "NoiDung", true, DataSourceUpdateMode.Never));
            lb_Username.DataBindings.Add(new Binding("Text", dgv_ListNotice.DataSource, "TenDangNhap", true, DataSourceUpdateMode.Never));
        }

        public fNotice()
        {
            InitializeComponent();

            this.Width = 800;
            pn_ListAccount.Hide();

            tb_Subject.ReadOnly = true;
            rtb_Content.ReadOnly = true;

            dgv_Client.AllowUserToAddRows = false;
            dgv_Emloyee.AllowUserToAddRows = false;


            dgv_ListNotice.DataSource = bindingNotice;

            LoadListNotice();
            LoadListAccountEmployee();
            LoadListAccountClient();

            AddNoticeBinding();
        }

        void LoadListNotice()
        {
            dgv_ListNotice.DataSource = NoticeDAO.Instance.GetDataTableNotice();
        }

        private void btn_AddNotice_Click(object sender, EventArgs e)
        {

            if (tb_Subject.Text != "" && lb_Username.Text.Contains(":"))
            {
                lb_Username.Text = "Tiêu đề:";

                string message = "Bạn có muốn xóa thông báo này không?";
                string title = "Thông báo";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    tb_Subject.ReadOnly = false;
                    rtb_Content.ReadOnly = false;
                    tb_Subject.Enabled = true;
                    rtb_Content.Enabled = true;

                    tb_Subject.Text = "";
                    rtb_Content.Text = "";
                }
                else
                {
                    
                }
            }
            else
            {
                lb_Username.Text = "Tiêu đề:";

                tb_Subject.ReadOnly = false;
                rtb_Content.ReadOnly = false;
                tb_Subject.Enabled = true;
                rtb_Content.Enabled = true;

                tb_Subject.Text = "";
                rtb_Content.Text = "";
                this.Width = 1250;
                pn_ListAccount.Show();
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (tb_Subject.Text == "" || rtb_Content.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ tiêu đề và nội dung!");
                return;
            }

            #region Ngay10/06
            List<string> listAccountChecked = new List<string>();
            for (int i = 0; i < dgv_Emloyee.Rows.Count; i++)
            {
                bool isChecked = false;

                try
                {
                    isChecked = (bool)dgv_Emloyee.Rows[i].Cells["BooleanValue"].Value;
                }
                catch
                {

                }

                if (isChecked)
                {
                    listAccountChecked.Add((string)dgv_Emloyee.Rows[i].Cells["TenDangNhap"].Value);
                }
            }

            for (int i = 0; i < dgv_Client.Rows.Count; i++)
            {
                bool isChecked = false;

                try
                {
                    isChecked = (bool)dgv_Client.Rows[i].Cells["BooleanValue"].Value;
                }
                catch
                {

                }
                
                if (isChecked)
                {
                    listAccountChecked.Add((string)dgv_Client.Rows[i].Cells["TenDangNhap"].Value);
                }
            }

            if (listAccountChecked.Count==0)
            {
                MessageBox.Show("Hãy chọn ít nhất 1 người để gửi!");
                return;
            }

            int success = NoticeDAO.Instance.InsertForListAcount(listAccountChecked, tb_Subject.Text, rtb_Content.Text);
            MessageBox.Show("Đã gửi cho " + success + " người");

            LoadListAccountClient();
            LoadListAccountEmployee();
            LoadListNotice();


            tb_Subject.Enabled = false;
            rtb_Content.Enabled = false;

            tb_Subject.Text = "";
            rtb_Content.Text = "";

            #endregion
        }

        #region Ngay10/06
        void LoadListAccountEmployee()
        {
            dgv_Emloyee.DataSource = AccountDAO.Instance.GetListAccountEmployee();
        }

        void LoadListAccountClient()
        {
            dgv_Client.DataSource = AccountDAO.Instance.GetListAccountClient();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string message = "Bạn có muốn xóa những thông báo này?";
            string title = "Thông báo";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int success = 0;
                for (int i = 0; i < dgv_ListNotice.SelectedCells.Count; i++)
                {
                    int id = (int)dgv_ListNotice.SelectedCells[i].OwningRow.Cells["MaThongBao"].Value;

                    if (NoticeDAO.Instance.DeleteByID(id))
                    {
                        success++;
                    }
                }

                MessageBox.Show("Đã xóa " + success + " thông báo");

                LoadListNotice();
            }
            else
            {

            }
        }
        #endregion

    }
}
