
namespace Asset_and_Maintenance_Management_System.src.Maintenance
{
    partial class uc_maintenance_backlog
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.asset_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.due_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days_passed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_continue = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asset_id,
            this.due_date,
            this.days_passed});
            this.dataGridView1.Location = new System.Drawing.Point(20, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 619);
            this.dataGridView1.TabIndex = 0;
            // 
            // asset_id
            // 
            this.asset_id.HeaderText = "Asset ID";
            this.asset_id.MinimumWidth = 6;
            this.asset_id.Name = "asset_id";
            this.asset_id.ReadOnly = true;
            this.asset_id.Width = 125;
            // 
            // due_date
            // 
            this.due_date.HeaderText = "Due Date";
            this.due_date.MinimumWidth = 6;
            this.due_date.Name = "due_date";
            this.due_date.ReadOnly = true;
            this.due_date.Width = 125;
            // 
            // days_passed
            // 
            this.days_passed.HeaderText = "Delay";
            this.days_passed.MinimumWidth = 6;
            this.days_passed.Name = "days_passed";
            this.days_passed.ReadOnly = true;
            this.days_passed.Width = 125;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(455, 49);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(688, 619);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btn_continue);
            this.panel1.Location = new System.Drawing.Point(27, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 767);
            this.panel1.TabIndex = 2;
            // 
            // btn_continue
            // 
            this.btn_continue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.btn_continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_continue.Location = new System.Drawing.Point(586, 367);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(123, 33);
            this.btn_continue.TabIndex = 1;
            this.btn_continue.Text = "Continue";
            this.btn_continue.UseVisualStyleBackColor = false;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_print.Location = new System.Drawing.Point(1013, 712);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(123, 33);
            this.btn_print.TabIndex = 3;
            this.btn_print.Text = "&Print...";
            this.btn_print.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(872, 712);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Schedule...";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // uc_maintenance_backlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.panel1);
            this.Name = "uc_maintenance_backlog";
            this.Size = new System.Drawing.Size(1356, 826);
            this.Load += new System.EventHandler(this.uc_maintenance_backlog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn asset_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn due_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn days_passed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_continue;
    }
}
