namespace QuanLyKhachSan
{
    partial class BillByTypeOfRoom
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbIDTypeOfRoom = new System.Windows.Forms.Label();
            this.txbIDTypeOfRoom = new System.Windows.Forms.TextBox();
            this.lbTypeOfRoom = new System.Windows.Forms.Label();
            this.cmbTypeOfRoom = new System.Windows.Forms.ComboBox();
            this.btnViewBillByTypeOfRoom = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.lbAmount = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvBill);
            this.panel4.Location = new System.Drawing.Point(3, 90);
            this.panel4.Margin = new System.Windows.Forms.Padding(6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1492, 741);
            this.panel4.TabIndex = 3;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(6, 6);
            this.dtgvBill.Margin = new System.Windows.Forms.Padding(6);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersWidth = 82;
            this.dtgvBill.Size = new System.Drawing.Size(1482, 729);
            this.dtgvBill.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbIDTypeOfRoom);
            this.panel2.Controls.Add(this.txbIDTypeOfRoom);
            this.panel2.Controls.Add(this.lbTypeOfRoom);
            this.panel2.Controls.Add(this.cmbTypeOfRoom);
            this.panel2.Controls.Add(this.btnViewBillByTypeOfRoom);
            this.panel2.Location = new System.Drawing.Point(7, 7);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1492, 77);
            this.panel2.TabIndex = 6;
            // 
            // lbIDTypeOfRoom
            // 
            this.lbIDTypeOfRoom.AutoSize = true;
            this.lbIDTypeOfRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDTypeOfRoom.Location = new System.Drawing.Point(631, 23);
            this.lbIDTypeOfRoom.Name = "lbIDTypeOfRoom";
            this.lbIDTypeOfRoom.Size = new System.Drawing.Size(213, 33);
            this.lbIDTypeOfRoom.TabIndex = 8;
            this.lbIDTypeOfRoom.Text = "Mã loại phòng: ";
            // 
            // txbIDTypeOfRoom
            // 
            this.txbIDTypeOfRoom.Enabled = false;
            this.txbIDTypeOfRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDTypeOfRoom.Location = new System.Drawing.Point(841, 20);
            this.txbIDTypeOfRoom.Name = "txbIDTypeOfRoom";
            this.txbIDTypeOfRoom.Size = new System.Drawing.Size(141, 40);
            this.txbIDTypeOfRoom.TabIndex = 7;
            // 
            // lbTypeOfRoom
            // 
            this.lbTypeOfRoom.AutoSize = true;
            this.lbTypeOfRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeOfRoom.Location = new System.Drawing.Point(20, 21);
            this.lbTypeOfRoom.Name = "lbTypeOfRoom";
            this.lbTypeOfRoom.Size = new System.Drawing.Size(215, 33);
            this.lbTypeOfRoom.TabIndex = 6;
            this.lbTypeOfRoom.Text = "Tên loại phòng:";
            // 
            // cmbTypeOfRoom
            // 
            this.cmbTypeOfRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTypeOfRoom.FormattingEnabled = true;
            this.cmbTypeOfRoom.Location = new System.Drawing.Point(241, 20);
            this.cmbTypeOfRoom.Name = "cmbTypeOfRoom";
            this.cmbTypeOfRoom.Size = new System.Drawing.Size(368, 41);
            this.cmbTypeOfRoom.TabIndex = 5;
            // 
            // btnViewBillByTypeOfRoom
            // 
            this.btnViewBillByTypeOfRoom.AutoSize = true;
            this.btnViewBillByTypeOfRoom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewBillByTypeOfRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBillByTypeOfRoom.ForeColor = System.Drawing.Color.Crimson;
            this.btnViewBillByTypeOfRoom.Location = new System.Drawing.Point(1225, 3);
            this.btnViewBillByTypeOfRoom.Name = "btnViewBillByTypeOfRoom";
            this.btnViewBillByTypeOfRoom.Size = new System.Drawing.Size(259, 68);
            this.btnViewBillByTypeOfRoom.TabIndex = 4;
            this.btnViewBillByTypeOfRoom.Text = "Thống kê";
            this.btnViewBillByTypeOfRoom.UseVisualStyleBackColor = false;
            this.btnViewBillByTypeOfRoom.Click += new System.EventHandler(this.btnViewBillByTypeOfRoom_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbAmount);
            this.panel1.Controls.Add(this.lbAmount);
            this.panel1.Location = new System.Drawing.Point(7, 837);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1492, 77);
            this.panel1.TabIndex = 7;
            // 
            // txbAmount
            // 
            this.txbAmount.Enabled = false;
            this.txbAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAmount.Location = new System.Drawing.Point(940, 16);
            this.txbAmount.Margin = new System.Windows.Forms.Padding(6);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.Size = new System.Drawing.Size(546, 44);
            this.txbAmount.TabIndex = 2;
            this.txbAmount.Text = "0";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.Location = new System.Drawing.Point(696, 21);
            this.lbAmount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(231, 37);
            this.lbAmount.TabIndex = 1;
            this.lbAmount.Text = "Tổng doanh thu:";
            // 
            // BillByTypeOfRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1504, 922);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Name = "BillByTypeOfRoom";
            this.Text = "BillByTypeOfRoom";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnViewBillByTypeOfRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbAmount;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbTypeOfRoom;
        private System.Windows.Forms.ComboBox cmbTypeOfRoom;
        private System.Windows.Forms.Label lbIDTypeOfRoom;
        private System.Windows.Forms.TextBox txbIDTypeOfRoom;
    }
}