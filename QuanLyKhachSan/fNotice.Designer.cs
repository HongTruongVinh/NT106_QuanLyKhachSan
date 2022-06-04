namespace QuanLyKhachSan
{
    partial class fNotice
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
            this.panel21 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Subject = new System.Windows.Forms.TextBox();
            this.rtb_Content = new System.Windows.Forms.RichTextBox();
            this.lv_Show = new System.Windows.Forms.ListView();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_UsernameFine = new System.Windows.Forms.TextBox();
            this.btn_EditAccount = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_AddNotice = new System.Windows.Forms.Button();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel21.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.btn_Save);
            this.panel21.Controls.Add(this.tb_UsernameFine);
            this.panel21.Controls.Add(this.btn_EditAccount);
            this.panel21.Controls.Add(this.btn_Delete);
            this.panel21.Controls.Add(this.btn_AddNotice);
            this.panel21.Location = new System.Drawing.Point(549, 7);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(468, 125);
            this.panel21.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 46);
            this.label1.TabIndex = 29;
            this.label1.Text = "Thông báo từ quản trị viên";
            // 
            // tb_Subject
            // 
            this.tb_Subject.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Subject.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_Subject.Location = new System.Drawing.Point(409, 171);
            this.tb_Subject.Multiline = true;
            this.tb_Subject.Name = "tb_Subject";
            this.tb_Subject.ReadOnly = true;
            this.tb_Subject.Size = new System.Drawing.Size(608, 86);
            this.tb_Subject.TabIndex = 28;
            // 
            // rtb_Content
            // 
            this.rtb_Content.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtb_Content.Location = new System.Drawing.Point(409, 263);
            this.rtb_Content.Name = "rtb_Content";
            this.rtb_Content.ReadOnly = true;
            this.rtb_Content.Size = new System.Drawing.Size(608, 485);
            this.rtb_Content.TabIndex = 27;
            this.rtb_Content.Text = "";
            // 
            // lv_Show
            // 
            this.lv_Show.HideSelection = false;
            this.lv_Show.Location = new System.Drawing.Point(13, 138);
            this.lv_Show.Name = "lv_Show";
            this.lv_Show.Size = new System.Drawing.Size(366, 610);
            this.lv_Show.TabIndex = 26;
            this.lv_Show.UseCompatibleStateImageBehavior = false;
            this.lv_Show.SelectedIndexChanged += new System.EventHandler(this.lv_Show_SelectedIndexChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(185, 7);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(95, 47);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_UsernameFine
            // 
            this.tb_UsernameFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_UsernameFine.Location = new System.Drawing.Point(26, 81);
            this.tb_UsernameFine.Name = "tb_UsernameFine";
            this.tb_UsernameFine.Size = new System.Drawing.Size(315, 27);
            this.tb_UsernameFine.TabIndex = 8;
            this.tb_UsernameFine.Text = "Nhập tên tài khoản";
            // 
            // btn_EditAccount
            // 
            this.btn_EditAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditAccount.Location = new System.Drawing.Point(352, 71);
            this.btn_EditAccount.Name = "btn_EditAccount";
            this.btn_EditAccount.Size = new System.Drawing.Size(90, 47);
            this.btn_EditAccount.TabIndex = 7;
            this.btn_EditAccount.Text = "Tìm";
            this.btn_EditAccount.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(347, 7);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(95, 47);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_AddNotice
            // 
            this.btn_AddNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNotice.Location = new System.Drawing.Point(26, 7);
            this.btn_AddNotice.Name = "btn_AddNotice";
            this.btn_AddNotice.Size = new System.Drawing.Size(92, 47);
            this.btn_AddNotice.TabIndex = 5;
            this.btn_AddNotice.Text = "Thêm";
            this.btn_AddNotice.UseVisualStyleBackColor = true;
            this.btn_AddNotice.Click += new System.EventHandler(this.btn_AddNotice_Click);
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(519, 138);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(498, 27);
            this.tb_Username.TabIndex = 10;
            this.tb_Username.Text = "All";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(414, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tài khoản:";
            // 
            // fNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 760);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Subject);
            this.Controls.Add(this.rtb_Content);
            this.Controls.Add(this.lv_Show);
            this.Name = "fNotice";
            this.Text = "fNotice";
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Subject;
        private System.Windows.Forms.RichTextBox rtb_Content;
        private System.Windows.Forms.ListView lv_Show;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_UsernameFine;
        private System.Windows.Forms.Button btn_EditAccount;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_AddNotice;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label label2;
    }
}