namespace QuanLyKhachSan_CLient
{
    partial class fChat
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_NameReceiver = new System.Windows.Forms.TextBox();
            this.lv_Show = new System.Windows.Forms.ListView();
            this.tb_Message = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.lb_Reload = new System.Windows.Forms.Label();
            this.dgv_ListMsg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListMsg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân viên:";
            // 
            // tb_NameReceiver
            // 
            this.tb_NameReceiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NameReceiver.Location = new System.Drawing.Point(107, 10);
            this.tb_NameReceiver.Name = "tb_NameReceiver";
            this.tb_NameReceiver.ReadOnly = true;
            this.tb_NameReceiver.Size = new System.Drawing.Size(643, 27);
            this.tb_NameReceiver.TabIndex = 1;
            this.tb_NameReceiver.Text = "_";
            // 
            // lv_Show
            // 
            this.lv_Show.HideSelection = false;
            this.lv_Show.Location = new System.Drawing.Point(12, 43);
            this.lv_Show.Name = "lv_Show";
            this.lv_Show.Size = new System.Drawing.Size(776, 336);
            this.lv_Show.TabIndex = 2;
            this.lv_Show.UseCompatibleStateImageBehavior = false;
            // 
            // tb_Message
            // 
            this.tb_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Message.Location = new System.Drawing.Point(12, 395);
            this.tb_Message.Multiline = true;
            this.tb_Message.Name = "tb_Message";
            this.tb_Message.Size = new System.Drawing.Size(677, 56);
            this.tb_Message.TabIndex = 3;
            // 
            // btn_Send
            // 
            this.btn_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.Location = new System.Drawing.Point(706, 395);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(82, 56);
            this.btn_Send.TabIndex = 4;
            this.btn_Send.Text = "Gửi";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // lb_Reload
            // 
            this.lb_Reload.AutoSize = true;
            this.lb_Reload.BackColor = System.Drawing.Color.LemonChiffon;
            this.lb_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Reload.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Reload.Location = new System.Drawing.Point(756, 15);
            this.lb_Reload.Name = "lb_Reload";
            this.lb_Reload.Size = new System.Drawing.Size(25, 25);
            this.lb_Reload.TabIndex = 15;
            this.lb_Reload.Text = "⟳";
            this.lb_Reload.Click += new System.EventHandler(this.lb_Reload_Click);
            // 
            // dgv_ListMsg
            // 
            this.dgv_ListMsg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListMsg.Location = new System.Drawing.Point(794, 43);
            this.dgv_ListMsg.Name = "dgv_ListMsg";
            this.dgv_ListMsg.RowHeadersWidth = 51;
            this.dgv_ListMsg.RowTemplate.Height = 24;
            this.dgv_ListMsg.Size = new System.Drawing.Size(171, 336);
            this.dgv_ListMsg.TabIndex = 35;
            // 
            // fChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 463);
            this.Controls.Add(this.dgv_ListMsg);
            this.Controls.Add(this.lb_Reload);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.tb_Message);
            this.Controls.Add(this.lv_Show);
            this.Controls.Add(this.tb_NameReceiver);
            this.Controls.Add(this.label1);
            this.Name = "fChat";
            this.Text = "Chating";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListMsg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_NameReceiver;
        private System.Windows.Forms.ListView lv_Show;
        private System.Windows.Forms.TextBox tb_Message;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Label lb_Reload;
        private System.Windows.Forms.DataGridView dgv_ListMsg;
    }
}