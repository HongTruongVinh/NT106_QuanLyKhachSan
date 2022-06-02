
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_GuestMgmt = new System.Windows.Forms.Button();
            this.btn_BillMgmt = new System.Windows.Forms.Button();
            this.btn_RoomMgmt = new System.Windows.Forms.Button();
            this.btn_Booking = new System.Windows.Forms.Button();
            this.tlp_Window = new System.Windows.Forms.TableLayoutPanel();
            this.pn_MenuOnWD = new System.Windows.Forms.Panel();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.tlp_Menu = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.btn_MenuOnMenu = new System.Windows.Forms.Button();
            this.btn_AccountInfo = new System.Windows.Forms.Button();
            this.btn_SignOut = new System.Windows.Forms.Button();
            this.btn_About = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlp_Window.SuspendLayout();
            this.pn_MenuOnWD.SuspendLayout();
            this.tlp_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_GuestMgmt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_BillMgmt, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_RoomMgmt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Booking, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(250, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1010, 669);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btn_GuestMgmt
            // 
            this.btn_GuestMgmt.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.hotel_customer_gray;
            this.btn_GuestMgmt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_GuestMgmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_GuestMgmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuestMgmt.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuestMgmt.ForeColor = System.Drawing.Color.White;
            this.btn_GuestMgmt.Location = new System.Drawing.Point(508, 337);
            this.btn_GuestMgmt.Name = "btn_GuestMgmt";
            this.btn_GuestMgmt.Size = new System.Drawing.Size(499, 329);
            this.btn_GuestMgmt.TabIndex = 9;
            this.btn_GuestMgmt.Text = "Quản lý khách hàng";
            this.btn_GuestMgmt.UseVisualStyleBackColor = true;
            this.btn_GuestMgmt.Click += new System.EventHandler(this.btn_GuestMgmt_Click);
            // 
            // btn_BillMgmt
            // 
            this.btn_BillMgmt.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.hotel_receipt_gray;
            this.btn_BillMgmt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BillMgmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_BillMgmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BillMgmt.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BillMgmt.ForeColor = System.Drawing.Color.White;
            this.btn_BillMgmt.Location = new System.Drawing.Point(3, 337);
            this.btn_BillMgmt.Name = "btn_BillMgmt";
            this.btn_BillMgmt.Size = new System.Drawing.Size(499, 329);
            this.btn_BillMgmt.TabIndex = 8;
            this.btn_BillMgmt.Text = "Quản lý hóa đơn";
            this.btn_BillMgmt.UseVisualStyleBackColor = true;
            this.btn_BillMgmt.Click += new System.EventHandler(this.btn_BillMgmt_Click);
            // 
            // btn_RoomMgmt
            // 
            this.btn_RoomMgmt.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.hotel_room_gray;
            this.btn_RoomMgmt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_RoomMgmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_RoomMgmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RoomMgmt.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RoomMgmt.ForeColor = System.Drawing.Color.White;
            this.btn_RoomMgmt.Location = new System.Drawing.Point(508, 3);
            this.btn_RoomMgmt.Name = "btn_RoomMgmt";
            this.btn_RoomMgmt.Size = new System.Drawing.Size(499, 328);
            this.btn_RoomMgmt.TabIndex = 7;
            this.btn_RoomMgmt.Text = "Quản lý phiếu thuê phòng";
            this.btn_RoomMgmt.UseVisualStyleBackColor = true;
            this.btn_RoomMgmt.Click += new System.EventHandler(this.btn_RoomMgmt_Click);
            // 
            // btn_Booking
            // 
            this.btn_Booking.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.hotel_booking_gray;
            this.btn_Booking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Booking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Booking.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Booking.ForeColor = System.Drawing.Color.White;
            this.btn_Booking.Location = new System.Drawing.Point(3, 3);
            this.btn_Booking.Name = "btn_Booking";
            this.btn_Booking.Size = new System.Drawing.Size(499, 328);
            this.btn_Booking.TabIndex = 2;
            this.btn_Booking.Text = "Đặt phòng";
            this.btn_Booking.UseVisualStyleBackColor = true;
            this.btn_Booking.Click += new System.EventHandler(this.btn_Booking_Click);
            // 
            // tlp_Window
            // 
            this.tlp_Window.ColumnCount = 3;
            this.tlp_Window.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Window.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Window.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Window.Controls.Add(this.pn_MenuOnWD, 0, 0);
            this.tlp_Window.Controls.Add(this.tableLayoutPanel1, 2, 0);
            this.tlp_Window.Controls.Add(this.tlp_Menu, 0, 0);
            this.tlp_Window.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Window.Location = new System.Drawing.Point(0, 0);
            this.tlp_Window.Name = "tlp_Window";
            this.tlp_Window.RowCount = 1;
            this.tlp_Window.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Window.Size = new System.Drawing.Size(1262, 673);
            this.tlp_Window.TabIndex = 24;
            // 
            // pn_MenuOnWD
            // 
            this.pn_MenuOnWD.BackColor = System.Drawing.Color.Black;
            this.pn_MenuOnWD.Controls.Add(this.btn_Menu);
            this.pn_MenuOnWD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_MenuOnWD.Location = new System.Drawing.Point(192, 0);
            this.pn_MenuOnWD.Margin = new System.Windows.Forms.Padding(0);
            this.pn_MenuOnWD.Name = "pn_MenuOnWD";
            this.pn_MenuOnWD.Padding = new System.Windows.Forms.Padding(8);
            this.pn_MenuOnWD.Size = new System.Drawing.Size(56, 673);
            this.pn_MenuOnWD.TabIndex = 25;
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Menu.FlatAppearance.BorderSize = 0;
            this.btn_Menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.ForeColor = System.Drawing.Color.White;
            this.btn_Menu.Image = global::QuanLyKhachSan.Properties.Resources.menu_outline;
            this.btn_Menu.Location = new System.Drawing.Point(8, 8);
            this.btn_Menu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(40, 40);
            this.btn_Menu.TabIndex = 12;
            this.btn_Menu.UseVisualStyleBackColor = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // tlp_Menu
            // 
            this.tlp_Menu.BackColor = System.Drawing.Color.Black;
            this.tlp_Menu.ColumnCount = 1;
            this.tlp_Menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Menu.Controls.Add(this.btn_Admin, 0, 2);
            this.tlp_Menu.Controls.Add(this.btn_MenuOnMenu, 0, 0);
            this.tlp_Menu.Controls.Add(this.btn_AccountInfo, 0, 3);
            this.tlp_Menu.Controls.Add(this.btn_SignOut, 0, 6);
            this.tlp_Menu.Controls.Add(this.btn_About, 0, 4);
            this.tlp_Menu.Controls.Add(this.btn_Help, 0, 5);
            this.tlp_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Menu.Location = new System.Drawing.Point(0, 0);
            this.tlp_Menu.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Menu.Name = "tlp_Menu";
            this.tlp_Menu.RowCount = 7;
            this.tlp_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tlp_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tlp_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tlp_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tlp_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tlp_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlp_Menu.Size = new System.Drawing.Size(192, 673);
            this.tlp_Menu.TabIndex = 24;
            // 
            // btn_Admin
            // 
            this.btn_Admin.BackColor = System.Drawing.Color.Transparent;
            this.btn_Admin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Admin.FlatAppearance.BorderSize = 0;
            this.btn_Admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Admin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.ForeColor = System.Drawing.Color.White;
            this.btn_Admin.Image = global::QuanLyKhachSan.Properties.Resources.shield_checkmark_outline;
            this.btn_Admin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Admin.Location = new System.Drawing.Point(16, 393);
            this.btn_Admin.Margin = new System.Windows.Forms.Padding(16, 8, 8, 8);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Admin.Size = new System.Drawing.Size(160, 40);
            this.btn_Admin.TabIndex = 11;
            this.btn_Admin.Text = "    Quản trị viên";
            this.btn_Admin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Admin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Admin.UseVisualStyleBackColor = false;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // btn_MenuOnMenu
            // 
            this.btn_MenuOnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btn_MenuOnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_MenuOnMenu.FlatAppearance.BorderSize = 0;
            this.btn_MenuOnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_MenuOnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MenuOnMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MenuOnMenu.ForeColor = System.Drawing.Color.White;
            this.btn_MenuOnMenu.Image = global::QuanLyKhachSan.Properties.Resources.menu_outline;
            this.btn_MenuOnMenu.Location = new System.Drawing.Point(16, 8);
            this.btn_MenuOnMenu.Margin = new System.Windows.Forms.Padding(16, 8, 8, 8);
            this.btn_MenuOnMenu.Name = "btn_MenuOnMenu";
            this.btn_MenuOnMenu.Size = new System.Drawing.Size(40, 40);
            this.btn_MenuOnMenu.TabIndex = 9;
            this.btn_MenuOnMenu.UseVisualStyleBackColor = false;
            this.btn_MenuOnMenu.Click += new System.EventHandler(this.btn_MenuOnMenu_Click);
            // 
            // btn_AccountInfo
            // 
            this.btn_AccountInfo.BackColor = System.Drawing.Color.Transparent;
            this.btn_AccountInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_AccountInfo.FlatAppearance.BorderSize = 0;
            this.btn_AccountInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_AccountInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AccountInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AccountInfo.ForeColor = System.Drawing.Color.White;
            this.btn_AccountInfo.Image = global::QuanLyKhachSan.Properties.Resources.person_circle_outline;
            this.btn_AccountInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AccountInfo.Location = new System.Drawing.Point(16, 449);
            this.btn_AccountInfo.Margin = new System.Windows.Forms.Padding(16, 8, 8, 8);
            this.btn_AccountInfo.Name = "btn_AccountInfo";
            this.btn_AccountInfo.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_AccountInfo.Size = new System.Drawing.Size(160, 40);
            this.btn_AccountInfo.TabIndex = 15;
            this.btn_AccountInfo.Text = "    Tài khoản";
            this.btn_AccountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AccountInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AccountInfo.UseVisualStyleBackColor = false;
            this.btn_AccountInfo.Click += new System.EventHandler(this.btn_AccountInfo_Click);
            // 
            // btn_SignOut
            // 
            this.btn_SignOut.BackColor = System.Drawing.Color.Transparent;
            this.btn_SignOut.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_SignOut.FlatAppearance.BorderSize = 0;
            this.btn_SignOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_SignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignOut.ForeColor = System.Drawing.Color.White;
            this.btn_SignOut.Image = global::QuanLyKhachSan.Properties.Resources.log_out_outline_1;
            this.btn_SignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SignOut.Location = new System.Drawing.Point(16, 617);
            this.btn_SignOut.Margin = new System.Windows.Forms.Padding(16, 8, 8, 16);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_SignOut.Size = new System.Drawing.Size(160, 40);
            this.btn_SignOut.TabIndex = 12;
            this.btn_SignOut.Text = "    Đăng xuất";
            this.btn_SignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SignOut.UseVisualStyleBackColor = false;
            this.btn_SignOut.Click += new System.EventHandler(this.btn_SignOut_Click);
            // 
            // btn_About
            // 
            this.btn_About.BackColor = System.Drawing.Color.Transparent;
            this.btn_About.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_About.FlatAppearance.BorderSize = 0;
            this.btn_About.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_About.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_About.ForeColor = System.Drawing.Color.White;
            this.btn_About.Image = global::QuanLyKhachSan.Properties.Resources.information_circle_outline;
            this.btn_About.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_About.Location = new System.Drawing.Point(16, 505);
            this.btn_About.Margin = new System.Windows.Forms.Padding(16, 8, 8, 8);
            this.btn_About.Name = "btn_About";
            this.btn_About.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_About.Size = new System.Drawing.Size(160, 40);
            this.btn_About.TabIndex = 14;
            this.btn_About.Text = "    Giới thiệu";
            this.btn_About.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_About.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_About.UseVisualStyleBackColor = false;
            // 
            // btn_Help
            // 
            this.btn_Help.BackColor = System.Drawing.Color.Transparent;
            this.btn_Help.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Help.FlatAppearance.BorderSize = 0;
            this.btn_Help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Help.ForeColor = System.Drawing.Color.White;
            this.btn_Help.Image = global::QuanLyKhachSan.Properties.Resources.help_circle_outline;
            this.btn_Help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Help.Location = new System.Drawing.Point(16, 561);
            this.btn_Help.Margin = new System.Windows.Forms.Padding(16, 8, 8, 8);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Help.Size = new System.Drawing.Size(160, 40);
            this.btn_Help.TabIndex = 13;
            this.btn_Help.Text = "    Trợ giúp";
            this.btn_Help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Help.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Help.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.tlp_Window);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý khách sạn";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlp_Window.ResumeLayout(false);
            this.pn_MenuOnWD.ResumeLayout(false);
            this.tlp_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_GuestMgmt;
        private System.Windows.Forms.Button btn_BillMgmt;
        private System.Windows.Forms.Button btn_RoomMgmt;
        private System.Windows.Forms.Button btn_Booking;
        private System.Windows.Forms.TableLayoutPanel tlp_Window;
        private System.Windows.Forms.Panel pn_MenuOnWD;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.TableLayoutPanel tlp_Menu;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Button btn_MenuOnMenu;
        private System.Windows.Forms.Button btn_AccountInfo;
        private System.Windows.Forms.Button btn_SignOut;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.Button btn_Help;
    }
}

