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
            this.btn_EditAccount = new System.Windows.Forms.Button();
            this.btn_DeleteAccount = new System.Windows.Forms.Button();
            this.btn_AddAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Subject = new System.Windows.Forms.TextBox();
            this.rtb_Content = new System.Windows.Forms.RichTextBox();
            this.lv_Show = new System.Windows.Forms.ListView();
            this.panel21.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.btn_EditAccount);
            this.panel21.Controls.Add(this.btn_DeleteAccount);
            this.panel21.Controls.Add(this.btn_AddAccount);
            this.panel21.Location = new System.Drawing.Point(519, 7);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(498, 81);
            this.panel21.TabIndex = 30;
            // 
            // btn_EditAccount
            // 
            this.btn_EditAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditAccount.Location = new System.Drawing.Point(405, 11);
            this.btn_EditAccount.Name = "btn_EditAccount";
            this.btn_EditAccount.Size = new System.Drawing.Size(90, 47);
            this.btn_EditAccount.TabIndex = 2;
            this.btn_EditAccount.Text = "Lưu";
            this.btn_EditAccount.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteAccount
            // 
            this.btn_DeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteAccount.Location = new System.Drawing.Point(273, 11);
            this.btn_DeleteAccount.Name = "btn_DeleteAccount";
            this.btn_DeleteAccount.Size = new System.Drawing.Size(95, 47);
            this.btn_DeleteAccount.TabIndex = 1;
            this.btn_DeleteAccount.Text = "Xóa";
            this.btn_DeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btn_AddAccount
            // 
            this.btn_AddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddAccount.Location = new System.Drawing.Point(144, 11);
            this.btn_AddAccount.Name = "btn_AddAccount";
            this.btn_AddAccount.Size = new System.Drawing.Size(92, 47);
            this.btn_AddAccount.TabIndex = 0;
            this.btn_AddAccount.Text = "Thêm";
            this.btn_AddAccount.UseVisualStyleBackColor = true;
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
            this.tb_Subject.Location = new System.Drawing.Point(409, 94);
            this.tb_Subject.Multiline = true;
            this.tb_Subject.Name = "tb_Subject";
            this.tb_Subject.ReadOnly = true;
            this.tb_Subject.Size = new System.Drawing.Size(608, 65);
            this.tb_Subject.TabIndex = 28;
            // 
            // rtb_Content
            // 
            this.rtb_Content.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtb_Content.Location = new System.Drawing.Point(409, 165);
            this.rtb_Content.Name = "rtb_Content";
            this.rtb_Content.ReadOnly = true;
            this.rtb_Content.Size = new System.Drawing.Size(608, 539);
            this.rtb_Content.TabIndex = 27;
            this.rtb_Content.Text = "";
            // 
            // lv_Show
            // 
            this.lv_Show.HideSelection = false;
            this.lv_Show.Location = new System.Drawing.Point(13, 94);
            this.lv_Show.Name = "lv_Show";
            this.lv_Show.Size = new System.Drawing.Size(366, 610);
            this.lv_Show.TabIndex = 26;
            this.lv_Show.UseCompatibleStateImageBehavior = false;
            // 
            // fNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 710);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Subject);
            this.Controls.Add(this.rtb_Content);
            this.Controls.Add(this.lv_Show);
            this.Name = "fNotice";
            this.Text = "fNotice";
            this.panel21.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Button btn_EditAccount;
        private System.Windows.Forms.Button btn_DeleteAccount;
        private System.Windows.Forms.Button btn_AddAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Subject;
        private System.Windows.Forms.RichTextBox rtb_Content;
        private System.Windows.Forms.ListView lv_Show;
    }
}