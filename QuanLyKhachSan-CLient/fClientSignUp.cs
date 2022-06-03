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
            MessageBox.Show(User.Instance.SignUp(tb_NameCLient.Text, tb_NumberPhone.Text, tb_IDPerson.Text, tb_Address.Text));
            this.Close();
        }
    }
}
