
namespace Asset_and_Maintenance_Management_System.src.Inventory
{
    partial class uc_inventory_levels
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
            this.chartInventoryLevels = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartInventoryLevels)).BeginInit();
            this.SuspendLayout();
            // 
            // chartInventoryLevels
            // 
            chartArea1.Name = "ChartArea1";
            this.chartInventoryLevels.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartInventoryLevels.Legends.Add(legend1);
            this.chartInventoryLevels.Location = new System.Drawing.Point(92, 80);
            this.chartInventoryLevels.Name = "chartInventoryLevels";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Units";
            this.chartInventoryLevels.Series.Add(series1);
            this.chartInventoryLevels.Size = new System.Drawing.Size(1004, 663);
            this.chartInventoryLevels.TabIndex = 0;
            this.chartInventoryLevels.Text = "chart1";
            // 
            // uc_inventory_levels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.chartInventoryLevels);
            this.Name = "uc_inventory_levels";
            this.Size = new System.Drawing.Size(1356, 826);
            ((System.ComponentModel.ISupportInitialize)(this.chartInventoryLevels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartInventoryLevels;
    }
}
