namespace QuanLyKhachSan_CLient
{
    partial class fListOrderedRoom
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
            this.dgv_LiadRoomOrdered = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LiadRoomOrdered)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_LiadRoomOrdered
            // 
            this.dgv_LiadRoomOrdered.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_LiadRoomOrdered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LiadRoomOrdered.Location = new System.Drawing.Point(12, 58);
            this.dgv_LiadRoomOrdered.Name = "dgv_LiadRoomOrdered";
            this.dgv_LiadRoomOrdered.ReadOnly = true;
            this.dgv_LiadRoomOrdered.RowHeadersWidth = 51;
            this.dgv_LiadRoomOrdered.RowTemplate.Height = 24;
            this.dgv_LiadRoomOrdered.Size = new System.Drawing.Size(642, 380);
            this.dgv_LiadRoomOrdered.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách phòng khách hàng đã đặt";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(662, 58);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(126, 40);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Hủy đặt";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // fListOrderedRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_LiadRoomOrdered);
            this.Name = "fListOrderedRoom";
            this.Text = "fListOrderedRoom";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LiadRoomOrdered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LiadRoomOrdered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Delete;
    }
}