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
using QuanLyKhachSan.Network;

namespace QuanLyKhachSan
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();

            tb_UserName.Text = "Admin";
            tb_PassWord.Text = "1";

        }

        public static string MD5(string s)
        {
            StringBuilder builder = new StringBuilder();

            using (var provider = System.Security.Cryptography.MD5.Create())
            {
                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(s)))
                    builder.Append(b.ToString("x2").ToLower());
            }

            return builder.ToString();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = tb_UserName.Text;
            string stringPassword = MD5(tb_PassWord.Text);

            if (AccountDAO.Instance.Login(username, stringPassword))
            {
                this.Hide();

                User.Instance.Create(username, tb_PassWord.Text);

                MainWindow mainWindow = new MainWindow();
                mainWindow.ShowDialog();

                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }

        }

        private void btn_Out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
