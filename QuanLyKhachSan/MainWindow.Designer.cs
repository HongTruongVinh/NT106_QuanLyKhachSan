
namespace QuanLyKhachSan
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pn_Menu = new System.Windows.Forms.Panel();
            this.btn_MenuOnMenu = new System.Windows.Forms.Label();
            this.btn_SignOut = new System.Windows.Forms.Label();
            this.btn_About = new System.Windows.Forms.Label();
            this.btn_Help = new System.Windows.Forms.Label();
            this.btn_InforAccount = new System.Windows.Forms.Label();
            this.pn_Window = new System.Windows.Forms.Panel();
            this.pn_MenuOnWD = new System.Windows.Forms.Panel();
            this.btn_Menu = new System.Windows.Forms.Label();
            this.pn_Menu.SuspendLayout();
            this.pn_Window.SuspendLayout();
            this.pn_MenuOnWD.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Menu
            // 
            this.pn_Menu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pn_Menu.Controls.Add(this.btn_MenuOnMenu);
            this.pn_Menu.Controls.Add(this.btn_SignOut);
            this.pn_Menu.Controls.Add(this.btn_About);
            this.pn_Menu.Controls.Add(this.btn_Help);
            this.pn_Menu.Controls.Add(this.btn_InforAccount);
            this.pn_Menu.Location = new System.Drawing.Point(13, 13);
            this.pn_Menu.Name = "pn_Menu";
            this.pn_Menu.Size = new System.Drawing.Size(242, 636);
            this.pn_Menu.TabIndex = 0;
            // 
            // btn_MenuOnMenu
            // 
            this.btn_MenuOnMenu.AutoSize = true;
            this.btn_MenuOnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MenuOnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_MenuOnMenu.Location = new System.Drawing.Point(9, 4);
            this.btn_MenuOnMenu.Name = "btn_MenuOnMenu";
            this.btn_MenuOnMenu.Size = new System.Drawing.Size(52, 55);
            this.btn_MenuOnMenu.TabIndex = 9;
            this.btn_MenuOnMenu.Text = "≡";
            this.btn_MenuOnMenu.Click += new System.EventHandler(this.btn_MenuOnMenu_Click);
            // 
            // btn_SignOut
            // 
            this.btn_SignOut.AutoSize = true;
            this.btn_SignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SignOut.Location = new System.Drawing.Point(14, 560);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.Size = new System.Drawing.Size(132, 25);
            this.btn_SignOut.TabIndex = 7;
            this.btn_SignOut.Text = "❌  Đăng xuất";
            this.btn_SignOut.Click += new System.EventHandler(this.btn_SignOut_Click);
            this.btn_SignOut.MouseLeave += new System.EventHandler(this.btn_SignOut_MouseLeave);
            this.btn_SignOut.MouseHover += new System.EventHandler(this.btn_SignOut_MouseHover);
            // 
            // btn_About
            // 
            this.btn_About.AutoSize = true;
            this.btn_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_About.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_About.Location = new System.Drawing.Point(14, 509);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(124, 25);
            this.btn_About.TabIndex = 6;
            this.btn_About.Text = "❗️  Giới thiệu";
            this.btn_About.MouseLeave += new System.EventHandler(this.btn_About_MouseLeave);
            this.btn_About.MouseHover += new System.EventHandler(this.btn_About_MouseHover);
            // 
            // btn_Help
            // 
            this.btn_Help.AutoSize = true;
            this.btn_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Help.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Help.Location = new System.Drawing.Point(14, 462);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(115, 25);
            this.btn_Help.TabIndex = 5;
            this.btn_Help.Text = "❓  Trợ giúp";
            this.btn_Help.MouseLeave += new System.EventHandler(this.btn_Help_MouseLeave);
            this.btn_Help.MouseHover += new System.EventHandler(this.btn_Help_MouseHover);
            // 
            // btn_InforAccount
            // 
            this.btn_InforAccount.AutoSize = true;
            this.btn_InforAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InforAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_InforAccount.Location = new System.Drawing.Point(14, 417);
            this.btn_InforAccount.Name = "btn_InforAccount";
            this.btn_InforAccount.Size = new System.Drawing.Size(209, 25);
            this.btn_InforAccount.TabIndex = 4;
            this.btn_InforAccount.Text = "🤵  Thông tin tài khoản";
            this.btn_InforAccount.Click += new System.EventHandler(this.btn_InforAccount_Click);
            this.btn_InforAccount.MouseLeave += new System.EventHandler(this.btn_InforAccount_MouseLeave);
            this.btn_InforAccount.MouseHover += new System.EventHandler(this.btn_InforAccount_MouseHover);
            // 
            // pn_Window
            // 
            this.pn_Window.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pn_Window.Controls.Add(this.pn_MenuOnWD);
            this.pn_Window.Location = new System.Drawing.Point(261, 13);
            this.pn_Window.Name = "pn_Window";
            this.pn_Window.Size = new System.Drawing.Size(924, 636);
            this.pn_Window.TabIndex = 1;
            // 
            // pn_MenuOnWD
            // 
            this.pn_MenuOnWD.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pn_MenuOnWD.Controls.Add(this.btn_Menu);
            this.pn_MenuOnWD.Location = new System.Drawing.Point(0, 0);
            this.pn_MenuOnWD.Name = "pn_MenuOnWD";
            this.pn_MenuOnWD.Size = new System.Drawing.Size(64, 636);
            this.pn_MenuOnWD.TabIndex = 1;
            // 
            // btn_Menu
            // 
            this.btn_Menu.AutoSize = true;
            this.btn_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Menu.Location = new System.Drawing.Point(3, 0);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(52, 55);
            this.btn_Menu.TabIndex = 8;
            this.btn_Menu.Text = "≡";
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1263, 727);
            this.Controls.Add(this.pn_Window);
            this.Controls.Add(this.pn_Menu);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý khách sạn";
            this.pn_Menu.ResumeLayout(false);
            this.pn_Menu.PerformLayout();
            this.pn_Window.ResumeLayout(false);
            this.pn_MenuOnWD.ResumeLayout(false);
            this.pn_MenuOnWD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Menu;
        private System.Windows.Forms.Panel pn_Window;
        private System.Windows.Forms.Label btn_InforAccount;
        private System.Windows.Forms.Label btn_Help;
        private System.Windows.Forms.Label btn_SignOut;
        private System.Windows.Forms.Label btn_About;
        private System.Windows.Forms.Label btn_Menu;
        private System.Windows.Forms.Panel pn_MenuOnWD;
        private System.Windows.Forms.Label btn_MenuOnMenu;
    }
}

