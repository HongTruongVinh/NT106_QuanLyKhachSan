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
    public partial class fClientSignUp : Form
    {
        public fClientSignUp()
        {
            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            if (tb_Password.Text != tb_Repassword.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không khớp!"); return;
            }

            if(tb_IDPerson.Text == "" || tb_NameCLient.Text==""|| tb_NumberPhone.Text==""|| tb_Address.Text == "" || tb_Password.Text == ""|| tb_Repassword.Text == "")
            {
                MessageBox.Show("Hãy nhập đủ thông tin");return;
            }

            string newPassword = fLogin.MD5(tb_Password.Text);

            MessageBox.Show(User.Instance.SignUp(tb_NameCLient.Text, tb_NumberPhone.Text, tb_IDPerson.Text, tb_Address.Text, newPassword));

            User.Instance.Create(tb_IDPerson.Text, tb_Password.Text);
            User.Instance.TypeUser = "Client";
            User.Instance.Address = tb_Address.Text;
            User.Instance.UserName = tb_IDPerson.Text;
            User.Instance.DisplayName=tb_NameCLient.Text;
            User.Instance.PhoneNumber = tb_NumberPhone.Text;

            this.Close();
        }

        private void tb_NumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled= true;
            }
        }

        private void tb_IDPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
