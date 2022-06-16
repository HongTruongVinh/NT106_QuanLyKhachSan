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
    public partial class fChat : Form
    {
        Timer timeToReload;

        string usernameReceiver = "";

        public fChat()
        {
            InitializeComponent();

            this.FormClosing += FChat_FormClosing;

            LoadForm();
        }


        void LoadForm()
        {
            dgv_ListMsg.AllowUserToAddRows = false;

            timeToReload = new Timer();
            timeToReload.Tick += TimeToReload_Tick; ;
            timeToReload.Interval = 2000; // 2s Reload 1 lần 
            timeToReload.Start();

            tb_NameReceiver.ReadOnly= true;
            lv_Show.Columns.Add("BoxChat");
            lv_Show.View = System.Windows.Forms.View.Details;
            lv_Show.Columns[0].Width = 500;

            if (User.Instance.TypeUser == "Employee")
            {
                LoadMessagesOfEmployee();

                lb_NameReceiver.Text = "KH: ";
            }
            else if(User.Instance.TypeUser == "Client")
            {
                LoadListEmployee();
            }
        }

        void LoadMessagesOfEmployee()
        {
            //Hàm để lấy danh sách tin nhắn của nhân viên
            dgv_ListMsg.DataSource = MessageDAO.Instance.MessageOfEmployee(User.Instance.UserName);
            dgv_ListMsg.Columns[1].Visible = false;
        }

        void LoadListEmployee()
        {
            //Hàm lấy danh sách nhân viên cho KH
            dgv_ListMsg.DataSource = MessageDAO.Instance.LoadListEmployee();
            dgv_ListMsg.Columns[1].Visible = false;
        }

        string FormatMessage(string sender, string message)
        {
            string formattedMessage = $"{sender} [{DateTime.Now:dd//MM//yyyy   hh:mm tt}]: {message}";
            return formattedMessage;
        }
        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (tb_Message.Text == "") return;

            if (User.Instance.TypeUser == "Employee" && tb_NameReceiver.Text=="_")
            {
                return;//Nếu ko có người để gửi thì Nhân viên ko thể gửi tin nhắn
            }

            string msg = FormatMessage(User.Instance.DisplayName, tb_Message.Text);

            if (usernameReceiver == "") return;

            if (User.Instance.TypeUser == "Employee")
            {
                if (MessageDAO.Instance.SendMessage(User.Instance.UserName, usernameReceiver, msg) == true)
                {
                    tb_Message.Text = "";
                }
            }
            else
            {
                if (MessageDAO.Instance.SendMessage(usernameReceiver, User.Instance.UserName, msg) == true)
                {
                    tb_Message.Text = "";
                }
            }

            LoadMessage();
        }

        private void TimeToReload_Tick(object sender, EventArgs e)
        {
            LoadMessage();

            if (User.Instance.TypeUser=="Employee")
            {
                LoadMessagesOfEmployee();
            }
        }
        private void FChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timeToReload != null)
            {
                timeToReload.Stop();
            }
        }

        private void lb_Reload_Click(object sender, EventArgs e)
        {
            LoadMessage();

            if (User.Instance.TypeUser == "Employee")
            {
                LoadMessagesOfEmployee();
            }
        }

        void LoadMessage()
        {
            DataTable dt;

            if (User.Instance.TypeUser == "Employee")
            {
                dt = MessageDAO.Instance.LoadMessage(User.Instance.UserName, usernameReceiver);
            }
            else
            {
                dt = MessageDAO.Instance.LoadMessage(usernameReceiver, User.Instance.UserName);
            }

            lv_Show.Items.Clear();

            if (dt != null)
            {

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem msg = new ListViewItem((string)dt.Rows[i]["NoiDung"]);

                    lv_Show.Items.Add(msg);

                    if (tb_NameReceiver.Text != "_") continue;

                    if (User.Instance.TypeUser == "Employee")
                    {
                        tb_NameReceiver.Text = (string)dt.Rows[i]["UserNameKhachHang"];
                    }
                    else
                    {
                        tb_NameReceiver.Text = (string)dt.Rows[i]["UserNameNhanVien"];
                    }
                }
            }
        }

        private void dgv_ListMsg_Click(object sender, EventArgs e)
        {
            try
            {

                usernameReceiver = (string)dgv_ListMsg.SelectedCells[0].OwningRow.Cells["TenDangNhap"].Value;

                LoadMessage();

                tb_NameReceiver.Text = (string)dgv_ListMsg.SelectedCells[0].OwningRow.Cells["Tên"].Value;
            }
            catch
            {

            }
        }
    }
}
