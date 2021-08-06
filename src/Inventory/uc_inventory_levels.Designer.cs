
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartInventoryLevels = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel26 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartInventoryLevels)).BeginInit();
            this.SuspendLayout();
            // 
            // chartInventoryLevels
            // 
            chartArea2.Name = "ChartArea1";
            this.chartInventoryLevels.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartInventoryLevels.Legends.Add(legend2);
            this.chartInventoryLevels.Location = new System.Drawing.Point(92, 80);
            this.chartInventoryLevels.Name = "chartInventoryLevels";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "Units";
            this.chartInventoryLevels.Series.Add(series2);
            this.chartInventoryLevels.Size = new System.Drawing.Size(1004, 663);
            this.chartInventoryLevels.TabIndex = 0;
            this.chartInventoryLevels.Text = "chart1";
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.panel26.Location = new System.Drawing.Point(21, 27);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(1172, 777);
            this.panel26.TabIndex = 16;
            // 
            // uc_inventory_levels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.chartInventoryLevels);
            this.Controls.Add(this.panel26);
            this.Name = "uc_inventory_levels";
            this.Size = new System.Drawing.Size(1356, 826);
            ((System.ComponentModel.ISupportInitialize)(this.chartInventoryLevels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartInventoryLevels;
        private System.Windows.Forms.Panel panel26;
    }
}
