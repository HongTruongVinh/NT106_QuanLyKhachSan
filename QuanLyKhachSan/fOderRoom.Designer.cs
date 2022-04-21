
namespace QuanLyKhachSan
{
    partial class fOderRoom
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_1stFloor = new System.Windows.Forms.FlowLayoutPanel();
            this.pn_ControlBar = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.pn_ControlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.flp_1stFloor);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1214, 595);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // flp_1stFloor
            // 
            this.flp_1stFloor.AutoScroll = true;
            this.flp_1stFloor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.flp_1stFloor.Location = new System.Drawing.Point(3, 3);
            this.flp_1stFloor.Name = "flp_1stFloor";
            this.flp_1stFloor.Size = new System.Drawing.Size(1180, 588);
            this.flp_1stFloor.TabIndex = 7;
            // 
            // pn_ControlBar
            // 
            this.pn_ControlBar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pn_ControlBar.Controls.Add(this.btn_Close);
            this.pn_ControlBar.Location = new System.Drawing.Point(12, 12);
            this.pn_ControlBar.Name = "pn_ControlBar";
            this.pn_ControlBar.Size = new System.Drawing.Size(1217, 36);
            this.pn_ControlBar.TabIndex = 3;
            // 
            // btn_Close
            // 
            this.btn_Close.AutoSize = true;
            this.btn_Close.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Close.Location = new System.Drawing.Point(1188, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(26, 25);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "X";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // fOderRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1241, 670);
            this.Controls.Add(this.pn_ControlBar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fOderRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt phòng";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pn_ControlBar.ResumeLayout(false);
            this.pn_ControlBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flp_1stFloor;
        private System.Windows.Forms.Panel pn_ControlBar;
        private System.Windows.Forms.Label btn_Close;
    }
}