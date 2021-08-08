
namespace Asset_and_Maintenance_Management_System.src.Analytics
{
    partial class uc_profit_on_disposal
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
            this.dataGridViewProfitOnDisposal = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_uname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfitOnDisposal)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProfitOnDisposal
            // 
            this.dataGridViewProfitOnDisposal.AllowUserToAddRows = false;
            this.dataGridViewProfitOnDisposal.AllowUserToDeleteRows = false;
            this.dataGridViewProfitOnDisposal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.dataGridViewProfitOnDisposal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfitOnDisposal.Location = new System.Drawing.Point(41, 49);
            this.dataGridViewProfitOnDisposal.Name = "dataGridViewProfitOnDisposal";
            this.dataGridViewProfitOnDisposal.RowHeadersWidth = 51;
            this.dataGridViewProfitOnDisposal.RowTemplate.Height = 24;
            this.dataGridViewProfitOnDisposal.Size = new System.Drawing.Size(1025, 535);
            this.dataGridViewProfitOnDisposal.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lbl_uname);
            this.panel1.Controls.Add(this.dataGridViewProfitOnDisposal);
            this.panel1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(251)))));
            this.panel1.Location = new System.Drawing.Point(56, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 791);
            this.panel1.TabIndex = 4;
            // 
            // lbl_uname
            // 
            this.lbl_uname.AutoSize = true;
            this.lbl_uname.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(251)))));
            this.lbl_uname.Location = new System.Drawing.Point(564, 587);
            this.lbl_uname.Name = "lbl_uname";
            this.lbl_uname.Size = new System.Drawing.Size(502, 28);
            this.lbl_uname.TabIndex = 4;
            this.lbl_uname.Text = "Note: All assets which are disposed are shown here.";
            // 
            // uc_profit_on_disposal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.panel1);
            this.Name = "uc_profit_on_disposal";
            this.Size = new System.Drawing.Size(1356, 826);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfitOnDisposal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProfitOnDisposal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_uname;
    }
}
