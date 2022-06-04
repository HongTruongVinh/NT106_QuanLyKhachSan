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
        public fNotice()
        {
            InitializeComponent();

            LoadListNotice();
        }

        void LoadListNotice()
        {
            tb_Username.ReadOnly = true;
            tb_Subject.ReadOnly = true;
            rtb_Content.ReadOnly = true;

            lv_Show.Clear(); 
            lv_Show.Columns.Add("Tài khoản", 100);
            lv_Show.Columns.Add("Tiêu đề", 150);
            lv_Show.Columns.Add("Nội dung", 300);
            lv_Show.View = View.Details;

            List<Notice> noticeList = NoticeDAO.Instance.GetListNotice();

            for (int i = noticeList.Count - 1; i > 0; i--)
            {
                ListViewItem name = new ListViewItem(noticeList[i].Username);

                ListViewItem.ListViewSubItem from = new ListViewItem.ListViewSubItem(name, noticeList[i].Subject);
                name.SubItems.Add(from);

                ListViewItem.ListViewSubItem date = new ListViewItem.ListViewSubItem(name, noticeList[i].Content);
                name.SubItems.Add(date);

                lv_Show.Items.Add(name);
            }
        }

        private void btn_AddNotice_Click(object sender, EventArgs e)
        {
            if (tb_Subject.Text != "")
            {
                string message = "Bạn có muốn xóa thông báo này không?";
                string title = "Thông báo";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    tb_Username.ReadOnly = false;
                    tb_Subject.ReadOnly = false;
                    rtb_Content.ReadOnly = false;

                    tb_Username.Text = "All";
                    tb_Subject.Text = "";
                    rtb_Content.Text = "";
                }
            }
        }

        private void lv_Show_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Subject.Text == "" || rtb_Content.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ tiêu đề và nội dung!");
                return;
            }

            if(tb_Username.Text == "All")
            {
                int success = NoticeDAO.Instance.InsertForAllAccount(tb_Subject.Text, rtb_Content.Text);
                MessageBox.Show("Đã gửi cho " + success + " người");
                return ;
            }

            if (NoticeDAO.Instance.Insert(Name, tb_Subject.Text, rtb_Content.Text))
            {
                MessageBox.Show("Thêm thành công");
                LoadListNotice();
                
            }
            else
            {
                MessageBox.Show("Lỗi!!! Thêm không thành công");
            }
        }
    }
}
