
namespace Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets
{
    partial class uc_AllAssets
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
            this.lbl_uname = new System.Windows.Forms.Label();
            this.dataGridAssets = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAssets)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.lbl_uname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 100);
            this.panel1.TabIndex = 0;
            // 
            // lbl_uname
            // 
            this.lbl_uname.AutoSize = true;
            this.lbl_uname.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbl_uname.Location = new System.Drawing.Point(548, 38);
            this.lbl_uname.Name = "lbl_uname";
            this.lbl_uname.Size = new System.Drawing.Size(125, 32);
            this.lbl_uname.TabIndex = 4;
            this.lbl_uname.Text = "All Assets";
            // 
            // dataGridAssets
            // 
            this.dataGridAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAssets.Location = new System.Drawing.Point(0, 100);
            this.dataGridAssets.Name = "dataGridAssets";
            this.dataGridAssets.RowHeadersWidth = 51;
            this.dataGridAssets.RowTemplate.Height = 24;
            this.dataGridAssets.Size = new System.Drawing.Size(1356, 726);
            this.dataGridAssets.TabIndex = 1;
            // 
            // uc_AllAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.Controls.Add(this.dataGridAssets);
            this.Controls.Add(this.panel1);
            this.Name = "uc_AllAssets";
            this.Size = new System.Drawing.Size(1356, 826);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAssets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_uname;
        private System.Windows.Forms.DataGridView dataGridAssets;
    }
}
