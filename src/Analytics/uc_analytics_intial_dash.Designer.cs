
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_warranty = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_lifetime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_warranty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_lifetime)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_warranty
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_warranty.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_warranty.Legends.Add(legend1);
            this.chart_warranty.Location = new System.Drawing.Point(58, 154);
            this.chart_warranty.Name = "chart_warranty";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "warranty";
            this.chart_warranty.Series.Add(series1);
            this.chart_warranty.Size = new System.Drawing.Size(582, 390);
            this.chart_warranty.TabIndex = 0;
            this.chart_warranty.Text = "chart1";
            // 
            // chart_lifetime
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_lifetime.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_lifetime.Legends.Add(legend2);
            this.chart_lifetime.Location = new System.Drawing.Point(717, 154);
            this.chart_lifetime.Name = "chart_lifetime";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "warranty";
            this.chart_lifetime.Series.Add(series2);
            this.chart_lifetime.Size = new System.Drawing.Size(582, 390);
            this.chart_lifetime.TabIndex = 1;
            this.chart_lifetime.Text = "chart2";
            // 
            // uc_analytics_intial_dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart_lifetime);
            this.Controls.Add(this.chart_warranty);
            this.Name = "uc_analytics_intial_dash";
            this.Size = new System.Drawing.Size(1356, 826);
            ((System.ComponentModel.ISupportInitialize)(this.chart_warranty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_lifetime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_warranty;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_lifetime;
    }
}
