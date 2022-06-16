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

        public fChat()
        {
            InitializeComponent();

            this.FormClosing += FChat_FormClosing;

            LoadForm();
        }


        void LoadForm()
        {
            timeToReload = new Timer();
            timeToReload.Tick += TimeToReload_Tick; ;
            timeToReload.Interval = 30000; // 3s Reload 1 lần 
            //timeToReload.Start();

            tb_NameReceiver.ReadOnly= true;
            lv_Show.Columns.Add("BoxChat");
            lv_Show.View = System.Windows.Forms.View.Details;
            lv_Show.Columns[0].Width = 500;

            if (User.Instance.TypeUser == "Employee")
            {
                LoadMessagesOfEmployee();
            }
            else
            {
                dgv_ListMsg.Hide();
            }
        }

        void LoadMessage()
        {
            lv_Show.Items.Clear();

            DataTable dt = MessageDAO.Instance.TableMessage(User.Instance.UserName, tb_NameReceiver.Text) ;
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem msg = new ListViewItem((string)dt.Rows[i]["NoiDung"]);

                lv_Show.Items.Add(msg);

                if (tb_NameReceiver.Text != "_") continue;

                if(User.Instance.TypeUser == "Employee")
                {
                    tb_NameReceiver.Text = (string)dt.Rows[i]["UserNameKhachHang"];
                }
                else
                {
                    tb_NameReceiver.Text = (string)dt.Rows[i]["UserNameNhanVien"];
                }
            }
        }

        void LoadMessagesOfEmployee()
        {
            dgv_ListMsg.DataSource = MessageDAO.Instance.MessageOfEmployee(User.Instance.UserName);
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


            string msg = FormatMessage(User.Instance.UserName, tb_Message.Text);

            if(MessageDAO.Instance.SendMessage(tb_NameReceiver.Text, User.Instance.UserName, msg) == true)
            {
                tb_Message.Text = "";
            }
        }

        private void TimeToReload_Tick(object sender, EventArgs e)
        {
            LoadMessage();
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
    }
}
