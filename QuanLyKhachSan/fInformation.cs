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
    public partial class fInformation : Form
    {
        public fInformation()
        {
            InitializeComponent();

            Load();
        }

        void Load()
        {
            lb_Save.Enabled = false;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            lb_Save.Enabled = true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            lb_Save.Enabled = false;
        }
    }
}
