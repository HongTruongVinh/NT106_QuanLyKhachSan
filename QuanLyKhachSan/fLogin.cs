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

namespace QuanLyKhachSan
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();

            tb_UserName.Text = "admin";
            tb_PassWord.Text = "0";

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = tb_UserName.Text;
            string password = tb_PassWord.Text;

            if (AccountDAO.Instance.Login(username, password))
            {
                this.Hide();

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
