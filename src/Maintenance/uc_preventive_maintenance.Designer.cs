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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreventiveMaintenance)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.dataGridViewPreventiveMaintenance);
            this.panel1.Location = new System.Drawing.Point(51, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 697);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewPreventiveMaintenance
            // 
            this.dataGridViewPreventiveMaintenance.AllowUserToAddRows = false;
            this.dataGridViewPreventiveMaintenance.AllowUserToDeleteRows = false;
            this.dataGridViewPreventiveMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPreventiveMaintenance.Location = new System.Drawing.Point(30, 46);
            this.dataGridViewPreventiveMaintenance.Name = "dataGridViewPreventiveMaintenance";
            this.dataGridViewPreventiveMaintenance.RowHeadersWidth = 51;
            this.dataGridViewPreventiveMaintenance.RowTemplate.Height = 24;
            this.dataGridViewPreventiveMaintenance.Size = new System.Drawing.Size(1089, 563);
            this.dataGridViewPreventiveMaintenance.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmit.Location = new System.Drawing.Point(999, 637);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(123, 33);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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
        private System.Windows.Forms.Button btnSubmit;
    }
}
