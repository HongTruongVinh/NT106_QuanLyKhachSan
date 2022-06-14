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
    public partial class fInformation : Form
    {
        public fInformation()
        {
            InitializeComponent();
            Load();
        }

        void Load()
        {
            tb_UserName.Enabled = false;
            tb_UserName.Text = User.Instance.UserName;
            tb_DisplayName.Text = User.Instance.DisplayName;
            tb_DisplayName.Enabled = false;
            //tb_PassWord.Text = User.Instance.Password;
            pn_Password.Hide();
            pn_NewPassword.Hide();
            pn_ReNewPassword.Hide();


            lb_Save.Enabled = false;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            lb_Save.Enabled = true;
            pn_Password.Show();
            pn_NewPassword.Show();
            pn_ReNewPassword.Show();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            lb_Save.Enabled = false;
            pn_Password.Hide();
            pn_NewPassword.Hide();
            pn_ReNewPassword.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_DisplayName.Text == "" || tb_NewPassword.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!"); return;
            }

            string newPassword = fLogin.MD5(tb_NewPassword.Text);

            if (tb_NewPassword.Text != tb_ReNewPassword.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu mới không khớp!"); return;
            }

            if (tb_PassWord.Text != User.Instance.Password)
            {
                MessageBox.Show("Mật khẩu không đúng!");
                return;
            }

            if (AccountDAO.Instance.ResetPassword(User.Instance.UserName, newPassword))
            {
                MessageBox.Show("Thay đổi thông tin thành công");
                User.Instance.Create(tb_UserName.Text, tb_NewPassword.Text);
                pn_Password.Hide();
                pn_NewPassword.Hide();
                pn_ReNewPassword.Hide();
                tb_PassWord.Text = "";
                tb_NewPassword.Text = "";
                tb_ReNewPassword.Text = "";
                tb_DisplayName.Enabled = false;
            }
            else
            {
                MessageBox.Show("!!!Thay đổi thông tin không thành công");
            }
        }

        bool isShowPassword = false;
        private void btn_ShowPassword_Click(object sender, EventArgs e)
        {
            if (isShowPassword == false)
            {
                isShowPassword = true;
                tb_PassWord.UseSystemPasswordChar = false;
            }
            else
            {
                isShowPassword = false;
                tb_PassWord.UseSystemPasswordChar = true;
            }
        }

        bool isShowNewPassword = false;
        private void btn_ShowNewPassword_Click(object sender, EventArgs e)
        {
            if (isShowNewPassword == false)
            {
                isShowNewPassword = true;
                tb_NewPassword.UseSystemPasswordChar = false;
            }
            else
            {
                isShowNewPassword = false;
                tb_NewPassword.UseSystemPasswordChar = true;
            }
        }

        bool isShowReNewPassword = false;
        private void btn_ShowReNewPass_Click(object sender, EventArgs e)
        {
            if (isShowReNewPassword == false)
            {
                isShowReNewPassword = true;
                tb_ReNewPassword.UseSystemPasswordChar = false;
            }
            else
            {
                isShowReNewPassword = false;
                tb_ReNewPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
