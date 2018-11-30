namespace CoffeeShop
{
    partial class UCThongke
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnSheet = new System.Windows.Forms.Button();
            this.btnLineChart = new System.Windows.Forms.Button();
            this.pnSheet = new System.Windows.Forms.Panel();
            this.btnXuatCSV = new System.Windows.Forms.Button();
            this.lblDoanhthu = new System.Windows.Forms.Label();
            this.dgvDoanhthu = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnThongke = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnSheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhthu)).BeginInit();
            this.pnThongke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSheet
            // 
            this.btnSheet.Location = new System.Drawing.Point(43, 18);
            this.btnSheet.Name = "btnSheet";
            this.btnSheet.Size = new System.Drawing.Size(75, 23);
            this.btnSheet.TabIndex = 6;
            this.btnSheet.Text = "Sheet";
            this.btnSheet.UseVisualStyleBackColor = true;
            this.btnSheet.Click += new System.EventHandler(this.btnSheet_Click);
            // 
            // btnLineChart
            // 
            this.btnLineChart.Location = new System.Drawing.Point(140, 18);
            this.btnLineChart.Name = "btnLineChart";
            this.btnLineChart.Size = new System.Drawing.Size(112, 23);
            this.btnLineChart.TabIndex = 5;
            this.btnLineChart.Text = "Biểu đồ doanh thu";
            this.btnLineChart.UseVisualStyleBackColor = true;
            this.btnLineChart.Click += new System.EventHandler(this.btnLineChart_Click);
            // 
            // pnSheet
            // 
            this.pnSheet.Controls.Add(this.btnXuatCSV);
            this.pnSheet.Controls.Add(this.lblDoanhthu);
            this.pnSheet.Controls.Add(this.dgvDoanhthu);
            this.pnSheet.Location = new System.Drawing.Point(3, 50);
            this.pnSheet.Name = "pnSheet";
            this.pnSheet.Size = new System.Drawing.Size(950, 357);
            this.pnSheet.TabIndex = 8;
            // 
            // btnXuatCSV
            // 
            this.btnXuatCSV.Location = new System.Drawing.Point(800, 37);
            this.btnXuatCSV.Name = "btnXuatCSV";
            this.btnXuatCSV.Size = new System.Drawing.Size(85, 32);
            this.btnXuatCSV.TabIndex = 2;
            this.btnXuatCSV.Text = "Xuất file CSV";
            this.btnXuatCSV.UseVisualStyleBackColor = true;
            this.btnXuatCSV.Click += new System.EventHandler(this.btnXuatCSV_Click);
            // 
            // lblDoanhthu
            // 
            this.lblDoanhthu.AutoSize = true;
            this.lblDoanhthu.Location = new System.Drawing.Point(36, 56);
            this.lblDoanhthu.Name = "lblDoanhthu";
            this.lblDoanhthu.Size = new System.Drawing.Size(100, 13);
            this.lblDoanhthu.TabIndex = 1;
            this.lblDoanhthu.Text = "Tổng doanh thu là: ";
            // 
            // dgvDoanhthu
            // 
            this.dgvDoanhthu.AllowUserToAddRows = false;
            this.dgvDoanhthu.AllowUserToDeleteRows = false;
            this.dgvDoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhthu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvDoanhthu.Location = new System.Drawing.Point(290, 12);
            this.dgvDoanhthu.Name = "dgvDoanhthu";
            this.dgvDoanhthu.ReadOnly = true;
            this.dgvDoanhthu.Size = new System.Drawing.Size(481, 338);
            this.dgvDoanhthu.TabIndex = 0;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ID";
            this.Column3.HeaderText = "ID";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Time";
            this.Column4.HeaderText = "Time";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "Amount";
            this.Column5.HeaderText = "Amount";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // pnThongke
            // 
            this.pnThongke.Controls.Add(this.label2);
            this.pnThongke.Controls.Add(this.label1);
            this.pnThongke.Controls.Add(this.chart1);
            this.pnThongke.Controls.Add(this.chart2);
            this.pnThongke.Location = new System.Drawing.Point(3, 47);
            this.pnThongke.Name = "pnThongke";
            this.pnThongke.Size = new System.Drawing.Size(950, 363);
            this.pnThongke.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thấp nhất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cao nhất";
            // 
            // chart1
            // 
            this.chart1.BorderSkin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            chartArea1.AxisX.Title = "Ngày";
            chartArea1.AxisY.Title = "VND (nghìn đồng)";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 10);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Doanhthu";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(625, 353);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Right;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(628, 0);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(322, 363);
            this.chart2.TabIndex = 4;
            this.chart2.Text = "chart2";
            // 
            // UCThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnSheet);
            this.Controls.Add(this.btnSheet);
            this.Controls.Add(this.btnLineChart);
            this.Controls.Add(this.pnThongke);
            this.Name = "UCThongke";
            this.Size = new System.Drawing.Size(950, 410);
            this.Load += new System.EventHandler(this.UCThongke_Load);
            this.pnSheet.ResumeLayout(false);
            this.pnSheet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhthu)).EndInit();
            this.pnThongke.ResumeLayout(false);
            this.pnThongke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSheet;
        private System.Windows.Forms.Button btnLineChart;
        private System.Windows.Forms.Panel pnSheet;
        private System.Windows.Forms.Button btnXuatCSV;
        private System.Windows.Forms.Label lblDoanhthu;
        private System.Windows.Forms.DataGridView dgvDoanhthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel pnThongke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}
