namespace QuanLyKhachSan_CLient
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
            this.pn_Control = new System.Windows.Forms.Panel();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_AddNotice = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Subject = new System.Windows.Forms.TextBox();
            this.rtb_Content = new System.Windows.Forms.RichTextBox();
            this.lb_Username = new System.Windows.Forms.Label();
            this.pn_ListAccount = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_Client = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Emloyee = new System.Windows.Forms.DataGridView();
            this.dgv_ListNotice = new System.Windows.Forms.DataGridView();
            this.pn_Control.SuspendLayout();
            this.pn_ListAccount.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Client)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Emloyee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListNotice)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Control
            // 
            this.pn_Control.Controls.Add(this.btn_Send);
            this.pn_Control.Controls.Add(this.btn_AddNotice);
            this.pn_Control.Controls.Add(this.btn_Delete);
            this.pn_Control.Location = new System.Drawing.Point(13, 87);
            this.pn_Control.Name = "pn_Control";
            this.pn_Control.Size = new System.Drawing.Size(1005, 45);
            this.pn_Control.TabIndex = 30;
            // 
            // btn_Send
            // 
            this.btn_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.Location = new System.Drawing.Point(876, 1);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(97, 44);
            this.btn_Send.TabIndex = 14;
            this.btn_Send.Text = "Gửi";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_AddNotice
            // 
            this.btn_AddNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNotice.Location = new System.Drawing.Point(396, 1);
            this.btn_AddNotice.Name = "btn_AddNotice";
            this.btn_AddNotice.Size = new System.Drawing.Size(205, 44);
            this.btn_AddNotice.TabIndex = 13;
            this.btn_AddNotice.Text = "Tạo thông báo mới";
            this.btn_AddNotice.UseVisualStyleBackColor = true;
            this.btn_AddNotice.Click += new System.EventHandler(this.btn_AddNotice_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(3, 1);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(366, 44);
            this.btn_Delete.TabIndex = 12;
            this.btn_Delete.Text = "Xóa những thông báo đã chọn";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
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
            this.tb_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.rtb_Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Content.Location = new System.Drawing.Point(409, 263);
            this.rtb_Content.Name = "rtb_Content";
            this.rtb_Content.ReadOnly = true;
            this.rtb_Content.Size = new System.Drawing.Size(608, 485);
            this.rtb_Content.TabIndex = 27;
            this.rtb_Content.Text = "";
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Username.Location = new System.Drawing.Point(414, 141);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(0, 20);
            this.lb_Username.TabIndex = 31;
            // 
            // pn_ListAccount
            // 
            this.pn_ListAccount.Controls.Add(this.panel3);
            this.pn_ListAccount.Controls.Add(this.panel2);
            this.pn_ListAccount.Location = new System.Drawing.Point(1024, 138);
            this.pn_ListAccount.Name = "pn_ListAccount";
            this.pn_ListAccount.Size = new System.Drawing.Size(622, 610);
            this.pn_ListAccount.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dgv_Client);
            this.panel3.Location = new System.Drawing.Point(321, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 604);
            this.panel3.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Danh sách khách hàng nhận";
            // 
            // dgv_Client
            // 
            this.dgv_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Client.Location = new System.Drawing.Point(3, 27);
            this.dgv_Client.Name = "dgv_Client";
            this.dgv_Client.RowHeadersWidth = 51;
            this.dgv_Client.RowTemplate.Height = 24;
            this.dgv_Client.Size = new System.Drawing.Size(292, 577);
            this.dgv_Client.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dgv_Emloyee);
            this.panel2.Location = new System.Drawing.Point(4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 604);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Danh sách nhân viên nhận";
            // 
            // dgv_Emloyee
            // 
            this.dgv_Emloyee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Emloyee.Location = new System.Drawing.Point(3, 27);
            this.dgv_Emloyee.Name = "dgv_Emloyee";
            this.dgv_Emloyee.RowHeadersWidth = 51;
            this.dgv_Emloyee.RowTemplate.Height = 24;
            this.dgv_Emloyee.Size = new System.Drawing.Size(292, 577);
            this.dgv_Emloyee.TabIndex = 33;
            // 
            // dgv_ListNotice
            // 
            this.dgv_ListNotice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListNotice.Location = new System.Drawing.Point(12, 138);
            this.dgv_ListNotice.Name = "dgv_ListNotice";
            this.dgv_ListNotice.RowHeadersWidth = 51;
            this.dgv_ListNotice.RowTemplate.Height = 24;
            this.dgv_ListNotice.Size = new System.Drawing.Size(370, 607);
            this.dgv_ListNotice.TabIndex = 34;
            // 
            // fNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1658, 760);
            this.Controls.Add(this.dgv_ListNotice);
            this.Controls.Add(this.pn_ListAccount);
            this.Controls.Add(this.lb_Username);
            this.Controls.Add(this.pn_Control);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Subject);
            this.Controls.Add(this.rtb_Content);
            this.Name = "fNotice";
            this.Text = "fNotice";
            this.pn_Control.ResumeLayout(false);
            this.pn_ListAccount.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Client)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Emloyee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListNotice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_Control;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Subject;
        private System.Windows.Forms.RichTextBox rtb_Content;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.Panel pn_ListAccount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_Client;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Emloyee;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_AddNotice;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dgv_ListNotice;
    }
}