namespace Asset_and_Maintenance_Management_System.src.Maintenance
{
    partial class uc_preventive_maintenance
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewPreventiveMaintenance = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreventiveMaintenance)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.dataGridViewPreventiveMaintenance);
            this.panel1.Location = new System.Drawing.Point(67, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 623);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewPreventiveMaintenance
            // 
            this.dataGridViewPreventiveMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPreventiveMaintenance.Location = new System.Drawing.Point(47, 46);
            this.dataGridViewPreventiveMaintenance.Name = "dataGridViewPreventiveMaintenance";
            this.dataGridViewPreventiveMaintenance.RowHeadersWidth = 51;
            this.dataGridViewPreventiveMaintenance.RowTemplate.Height = 24;
            this.dataGridViewPreventiveMaintenance.Size = new System.Drawing.Size(852, 563);
            this.dataGridViewPreventiveMaintenance.TabIndex = 0;
            // 
            // uc_preventive_maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.panel1);
            this.Name = "uc_preventive_maintenance";
            this.Size = new System.Drawing.Size(1356, 826);
            this.Load += new System.EventHandler(this.uc_preventive_maintenance_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreventiveMaintenance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewPreventiveMaintenance;
    }
}
