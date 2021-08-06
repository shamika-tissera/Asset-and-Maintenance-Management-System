
namespace Asset_and_Maintenance_Management_System.src.Analytics
{
    partial class uc_analytics_utilization
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
            this.dataGridViewUtilization = new System.Windows.Forms.DataGridView();
            this.chartUtilization = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUtilization)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUtilization
            // 
            this.dataGridViewUtilization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUtilization.Location = new System.Drawing.Point(20, 117);
            this.dataGridViewUtilization.Name = "dataGridViewUtilization";
            this.dataGridViewUtilization.RowHeadersWidth = 51;
            this.dataGridViewUtilization.RowTemplate.Height = 24;
            this.dataGridViewUtilization.Size = new System.Drawing.Size(554, 609);
            this.dataGridViewUtilization.TabIndex = 0;
            // 
            // chartUtilization
            // 
            chartArea1.Name = "ChartArea1";
            this.chartUtilization.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartUtilization.Legends.Add(legend1);
            this.chartUtilization.Location = new System.Drawing.Point(580, 117);
            this.chartUtilization.Name = "chartUtilization";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "%";
            this.chartUtilization.Series.Add(series1);
            this.chartUtilization.Size = new System.Drawing.Size(601, 609);
            this.chartUtilization.TabIndex = 1;
            this.chartUtilization.Text = "chart1";
            this.chartUtilization.Click += new System.EventHandler(this.chartUtilization_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.panel1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(251)))));
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 791);
            this.panel1.TabIndex = 4;
            // 
            // uc_analytics_utilization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.chartUtilization);
            this.Controls.Add(this.dataGridViewUtilization);
            this.Controls.Add(this.panel1);
            this.Name = "uc_analytics_utilization";
            this.Size = new System.Drawing.Size(1356, 826);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUtilization)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUtilization;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUtilization;
        private System.Windows.Forms.Panel panel1;
    }
}
