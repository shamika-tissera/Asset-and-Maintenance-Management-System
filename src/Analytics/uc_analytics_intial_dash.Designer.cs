
namespace Asset_and_Maintenance_Management_System.src.Analytics
{
    partial class uc_analytics_intial_dash
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_warranty = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_lifetime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart_warranty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_lifetime)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_warranty
            // 
            this.chart_warranty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(251)))));
            chartArea3.Name = "ChartArea1";
            this.chart_warranty.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_warranty.Legends.Add(legend3);
            this.chart_warranty.Location = new System.Drawing.Point(20, 199);
            this.chart_warranty.Name = "chart_warranty";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "s1";
            this.chart_warranty.Series.Add(series3);
            this.chart_warranty.Size = new System.Drawing.Size(535, 359);
            this.chart_warranty.TabIndex = 0;
            this.chart_warranty.Text = "chart1";
            this.chart_warranty.Click += new System.EventHandler(this.chart_warranty_Click);
            // 
            // chart_lifetime
            // 
            this.chart_lifetime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(251)))));
            chartArea4.Name = "ChartArea1";
            this.chart_lifetime.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_lifetime.Legends.Add(legend4);
            this.chart_lifetime.Location = new System.Drawing.Point(626, 199);
            this.chart_lifetime.Name = "chart_lifetime";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "d1";
            this.chart_lifetime.Series.Add(series4);
            this.chart_lifetime.Size = new System.Drawing.Size(535, 359);
            this.chart_lifetime.TabIndex = 1;
            this.chart_lifetime.Text = "chart2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.chart_warranty);
            this.panel1.Controls.Add(this.chart_lifetime);
            this.panel1.Location = new System.Drawing.Point(30, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 791);
            this.panel1.TabIndex = 2;
            // 
            // uc_analytics_intial_dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.panel1);
            this.Name = "uc_analytics_intial_dash";
            this.Size = new System.Drawing.Size(1356, 826);
            ((System.ComponentModel.ISupportInitialize)(this.chart_warranty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_lifetime)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_warranty;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_lifetime;
        private System.Windows.Forms.Panel panel1;
    }
}
