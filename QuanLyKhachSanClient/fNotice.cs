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

            try
            {
                lv_Show.Clear();
                lv_Show.Columns.Add("Email", 200);
                lv_Show.Columns.Add("From", 200);
                lv_Show.Columns.Add("Time", 100);
                lv_Show.Columns.Add("Content", 300);
                lv_Show.View = View.Details;

                //LoadListMessage(this.lv_Show, "imap.gmail.com", 993, tb_MailAddress.Text, tb_Password.Text);
            }
            catch
            {
                MessageBox.Show("Error for load inbox");
            }
        }
    }
}
