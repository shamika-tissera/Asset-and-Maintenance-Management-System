
namespace Asset_and_Maintenance_Management_System.src.Maintenance
{
    partial class uc_corrective_maintenance
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dataGridViewCorrectiveMaintenance = new System.Windows.Forms.DataGridView();
            this.lbl_uname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorrectiveMaintenance)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lbl_uname);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.dataGridViewCorrectiveMaintenance);
            this.panel1.Location = new System.Drawing.Point(24, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 764);
            this.panel1.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmit.Location = new System.Drawing.Point(999, 662);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(123, 33);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "&Performed";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dataGridViewCorrectiveMaintenance
            // 
            this.dataGridViewCorrectiveMaintenance.AllowUserToAddRows = false;
            this.dataGridViewCorrectiveMaintenance.AllowUserToDeleteRows = false;
            this.dataGridViewCorrectiveMaintenance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.dataGridViewCorrectiveMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCorrectiveMaintenance.Location = new System.Drawing.Point(34, 46);
            this.dataGridViewCorrectiveMaintenance.Name = "dataGridViewCorrectiveMaintenance";
            this.dataGridViewCorrectiveMaintenance.RowHeadersWidth = 51;
            this.dataGridViewCorrectiveMaintenance.RowTemplate.Height = 24;
            this.dataGridViewCorrectiveMaintenance.Size = new System.Drawing.Size(1115, 563);
            this.dataGridViewCorrectiveMaintenance.TabIndex = 0;
            // 
            // lbl_uname
            // 
            this.lbl_uname.AutoSize = true;
            this.lbl_uname.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(251)))));
            this.lbl_uname.Location = new System.Drawing.Point(342, 612);
            this.lbl_uname.Name = "lbl_uname";
            this.lbl_uname.Size = new System.Drawing.Size(807, 28);
            this.lbl_uname.TabIndex = 6;
            this.lbl_uname.Text = "Note: Shows all assets which needs corrective maintenance approved by a manager.";
            // 
            // uc_corrective_maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.panel1);
            this.Name = "uc_corrective_maintenance";
            this.Size = new System.Drawing.Size(1356, 826);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorrectiveMaintenance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.DataGridView dataGridViewCorrectiveMaintenance;
        protected System.Windows.Forms.Button btnSubmit;
        protected System.Windows.Forms.Label lbl_uname;
    }
}
