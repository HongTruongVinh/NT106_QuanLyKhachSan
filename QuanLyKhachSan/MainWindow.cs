using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            pn_Menu.Hide();
            panel2startPosition = new Point(pn_Window.Location.X, pn_Window.Location.Y);
            pn_Window.Location = new Point(12, 13);
            pn_Window.Size = new Size(2000, 2000);
            pn_MenuOnWD.Size = new Size(pn_MenuOnWD.Width, 1000);

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btn_Menu, "Tùy chọn");

            
        }

        bool menuIsHide = true;
        Point panel2startPosition;
        private void btn_Menu_Click(object sender, EventArgs e)
        {
            if (menuIsHide)
            {
                pn_Menu.Show();
                pn_MenuOnWD.Hide();
                menuIsHide = false;
                pn_Window.Location = panel2startPosition;
                //pn_Window.Size = new Size(2000, 2000);
            }
            else
            {
                pn_Menu.Hide();
                pn_MenuOnWD.Show();
                menuIsHide = true;
                pn_Window.Location = new Point(12, 13);
                //pn_Window.Size = new Size(2000, 2000);
            }
        }
        private void btn_MenuOnMenu_Click(object sender, EventArgs e)
        {
            btn_Menu_Click(sender, e);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            btn_InforAccount.BackColor = Color.LightSkyBlue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            btn_InforAccount.BackColor = Color.DeepSkyBlue;
        }

        private void btn_Help_MouseHover(object sender, EventArgs e)
        {
            btn_Help.BackColor = Color.LightSkyBlue;
        }

        private void btn_Help_MouseLeave(object sender, EventArgs e)
        {
            btn_Help.BackColor = Color.DeepSkyBlue;
        }

        private void btn_About_MouseHover(object sender, EventArgs e)
        {
            btn_About.BackColor = Color.LightSkyBlue;
        }

        private void btn_About_MouseLeave(object sender, EventArgs e)
        {
            btn_About.BackColor = Color.DeepSkyBlue;
        }

        private void btn_SignOut_MouseHover(object sender, EventArgs e)
        {
            btn_SignOut.BackColor = Color.LightSkyBlue;
        }

        private void btn_SignOut_MouseLeave(object sender, EventArgs e)
        {
            btn_SignOut.BackColor = Color.DeepSkyBlue;
        }

        private void btn_InforAccount_MouseHover(object sender, EventArgs e)
        {
            btn_InforAccount.BackColor = Color.LightSkyBlue;
        }

        private void btn_InforAccount_MouseLeave(object sender, EventArgs e)
        {
            btn_InforAccount.BackColor = Color.DeepSkyBlue;
        }

        

        private void btn_InforAccount_Click(object sender, EventArgs e)
        {
            fAdmin fAdmin = new fAdmin();
            fAdmin.ShowDialog();
        }

        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
