namespace QuanLyKhachSan
{
    partial class fChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartColumn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartColumn)).BeginInit();
            this.SuspendLayout();
            // 
            // chartColumn
            // 
            chartArea2.Name = "ChartArea1";
            this.chartColumn.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartColumn.Legends.Add(legend2);
            this.chartColumn.Location = new System.Drawing.Point(13, 13);
            this.chartColumn.Name = "chartColumn";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartColumn.Series.Add(series2);
            this.chartColumn.Size = new System.Drawing.Size(1529, 850);
            this.chartColumn.TabIndex = 0;
            this.chartColumn.Text = "chart1";
            // 
            // fChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1554, 875);
            this.Controls.Add(this.chartColumn);
            this.Name = "fChart";
            this.Text = "fChart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fChart_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chartColumn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartColumn;
    }
}