
namespace QuanLyKhachSan
{
    partial class fClientManage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_CLientManage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tab_RentalVoucherManage = new System.Windows.Forms.TabPage();
            this.pn_ControlBar = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab_CLientManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pn_ControlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_CLientManage);
            this.tabControl1.Controls.Add(this.tab_RentalVoucherManage);
            this.tabControl1.Location = new System.Drawing.Point(12, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1074, 484);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_CLientManage
            // 
            this.tab_CLientManage.Controls.Add(this.dataGridView1);
            this.tab_CLientManage.Location = new System.Drawing.Point(4, 25);
            this.tab_CLientManage.Name = "tab_CLientManage";
            this.tab_CLientManage.Padding = new System.Windows.Forms.Padding(3);
            this.tab_CLientManage.Size = new System.Drawing.Size(1066, 455);
            this.tab_CLientManage.TabIndex = 0;
            this.tab_CLientManage.Text = "Quản lý khách hàng";
            this.tab_CLientManage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(693, 429);
            this.dataGridView1.TabIndex = 0;
            // 
            // tab_RentalVoucherManage
            // 
            this.tab_RentalVoucherManage.Location = new System.Drawing.Point(4, 25);
            this.tab_RentalVoucherManage.Name = "tab_RentalVoucherManage";
            this.tab_RentalVoucherManage.Padding = new System.Windows.Forms.Padding(3);
            this.tab_RentalVoucherManage.Size = new System.Drawing.Size(1066, 455);
            this.tab_RentalVoucherManage.TabIndex = 1;
            this.tab_RentalVoucherManage.Text = "Quản lý phiếu thuê phòng";
            this.tab_RentalVoucherManage.UseVisualStyleBackColor = true;
            // 
            // pn_ControlBar
            // 
            this.pn_ControlBar.Controls.Add(this.btn_Close);
            this.pn_ControlBar.Location = new System.Drawing.Point(12, 12);
            this.pn_ControlBar.Name = "pn_ControlBar";
            this.pn_ControlBar.Size = new System.Drawing.Size(1070, 36);
            this.pn_ControlBar.TabIndex = 3;
            // 
            // btn_Close
            // 
            this.btn_Close.AutoSize = true;
            this.btn_Close.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Close.Location = new System.Drawing.Point(1041, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(26, 25);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "X";
            // 
            // fClientManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 550);
            this.Controls.Add(this.pn_ControlBar);
            this.Controls.Add(this.tabControl1);
            this.Name = "fClientManage";
            this.Text = "fClientManage";
            this.tabControl1.ResumeLayout(false);
            this.tab_CLientManage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pn_ControlBar.ResumeLayout(false);
            this.pn_ControlBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_CLientManage;
        private System.Windows.Forms.TabPage tab_RentalVoucherManage;
        private System.Windows.Forms.Panel pn_ControlBar;
        private System.Windows.Forms.Label btn_Close;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}