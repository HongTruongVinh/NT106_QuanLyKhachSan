using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan_CLient.DAO;
using QuanLyKhachSan_CLient.Network;

namespace QuanLyKhachSan_CLient
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();

            //tb_UserName.Text = "Vinh";
            //tb_PassWord.Text = "1";
            tb_UserName.Text = "Vinh";
            tb_PassWord.Text = "0";
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = tb_UserName.Text;
            string password = tb_PassWord.Text;

            if (TCPClient.Instance.Login(username, password))
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

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            fClientSignUp signUp = new fClientSignUp();
            signUp.ShowDialog();
        }

    }
}
