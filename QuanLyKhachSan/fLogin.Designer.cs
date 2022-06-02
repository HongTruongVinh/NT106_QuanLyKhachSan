
namespace QuanLyKhachSan
{
    partial class fLogin
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.pn_HoTen = new System.Windows.Forms.Panel();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lb_Username = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pn_HoTen.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pn_HoTen, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Login, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_Username, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Password, 0, 1);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(352, 168);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tb_Password);
            this.panel4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(104, 64);
            this.panel4.Margin = new System.Windows.Forms.Padding(8);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.panel4.Size = new System.Drawing.Size(240, 40);
            this.panel4.TabIndex = 14;
            // 
            // tb_Password
            // 
            this.tb_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.ForeColor = System.Drawing.Color.Black;
            this.tb_Password.Location = new System.Drawing.Point(8, 10);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(222, 20);
            this.tb_Password.TabIndex = 0;
            this.tb_Password.Text = "0";
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // pn_HoTen
            // 
            this.pn_HoTen.AutoSize = true;
            this.pn_HoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_HoTen.Controls.Add(this.tb_Username);
            this.pn_HoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pn_HoTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_HoTen.Location = new System.Drawing.Point(104, 8);
            this.pn_HoTen.Margin = new System.Windows.Forms.Padding(8);
            this.pn_HoTen.Name = "pn_HoTen";
            this.pn_HoTen.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.pn_HoTen.Size = new System.Drawing.Size(240, 40);
            this.pn_HoTen.TabIndex = 13;
            // 
            // tb_Username
            // 
            this.tb_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.ForeColor = System.Drawing.Color.Black;
            this.tb_Username.Location = new System.Drawing.Point(8, 10);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(222, 20);
            this.tb_Username.TabIndex = 0;
            this.tb_Username.Text = "admin";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Black;
            this.btn_Login.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(184, 120);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(8);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(160, 40);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Username.Location = new System.Drawing.Point(16, 16);
            this.lb_Username.Margin = new System.Windows.Forms.Padding(16, 16, 0, 16);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(80, 24);
            this.lb_Username.TabIndex = 11;
            this.lb_Username.Text = "Tài khoản:";
            this.lb_Username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.Location = new System.Drawing.Point(16, 72);
            this.lb_Password.Margin = new System.Windows.Forms.Padding(16, 16, 0, 16);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(80, 24);
            this.lb_Password.TabIndex = 12;
            this.lb_Password.Text = "Mật khẩu:";
            this.lb_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 200);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fLogin";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pn_HoTen.ResumeLayout(false);
            this.pn_HoTen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Panel pn_HoTen;
        private System.Windows.Forms.TextBox tb_Username;
    }
}