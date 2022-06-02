namespace QuanLyKhachSan
{
    partial class Form1
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
            this.pn_HoTen = new System.Windows.Forms.Panel();
            this.tb_HoTen = new System.Windows.Forms.TextBox();
            this.pn_HoTen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_HoTen
            // 
            this.pn_HoTen.AutoSize = true;
            this.pn_HoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_HoTen.Controls.Add(this.tb_HoTen);
            this.pn_HoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pn_HoTen.Location = new System.Drawing.Point(454, 338);
            this.pn_HoTen.Margin = new System.Windows.Forms.Padding(0);
            this.pn_HoTen.Name = "pn_HoTen";
            this.pn_HoTen.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.pn_HoTen.Size = new System.Drawing.Size(160, 40);
            this.pn_HoTen.TabIndex = 5;
            // 
            // tb_HoTen
            // 
            this.tb_HoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_HoTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_HoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_HoTen.ForeColor = System.Drawing.Color.Black;
            this.tb_HoTen.Location = new System.Drawing.Point(8, 10);
            this.tb_HoTen.Margin = new System.Windows.Forms.Padding(0);
            this.tb_HoTen.Name = "tb_HoTen";
            this.tb_HoTen.Size = new System.Drawing.Size(142, 20);
            this.tb_HoTen.TabIndex = 0;
            this.tb_HoTen.Text = "Nguyễn Văn A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1120, 725);
            this.Controls.Add(this.pn_HoTen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pn_HoTen.ResumeLayout(false);
            this.pn_HoTen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_HoTen;
        private System.Windows.Forms.TextBox tb_HoTen;
    }
}