
namespace Asset_and_Maintenance_Management_System.src.Analytics
{
    partial class uc_analytics_warranty
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
            this.dataGridViewWarranty = new System.Windows.Forms.DataGridView();
            this.btn_print = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarranty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.lbl_uname);
            this.panel1.Controls.Add(this.dataGridViewWarranty);
            this.panel1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(251)))));
            this.panel1.Location = new System.Drawing.Point(51, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 791);
            this.panel1.TabIndex = 3;
            // 
            // lbl_uname
            // 
            this.lbl_uname.AutoSize = true;
            this.lbl_uname.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_uname.Location = new System.Drawing.Point(519, 587);
            this.lbl_uname.Name = "lbl_uname";
            this.lbl_uname.Size = new System.Drawing.Size(564, 28);
            this.lbl_uname.TabIndex = 3;
            this.lbl_uname.Text = "Note: Only assets with active warranty are displayed here.";
            // 
            // dataGridViewWarranty
            // 
            this.dataGridViewWarranty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWarranty.Location = new System.Drawing.Point(58, 49);
            this.dataGridViewWarranty.Name = "dataGridViewWarranty";
            this.dataGridViewWarranty.RowHeadersWidth = 51;
            this.dataGridViewWarranty.RowTemplate.Height = 24;
            this.dataGridViewWarranty.Size = new System.Drawing.Size(1025, 535);
            this.dataGridViewWarranty.TabIndex = 0;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_print.Location = new System.Drawing.Point(960, 708);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(123, 33);
            this.btn_print.TabIndex = 4;
            this.btn_print.Text = "&Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // uc_analytics_warranty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.panel1);
            this.Name = "uc_analytics_warranty";
            this.Size = new System.Drawing.Size(1356, 826);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarranty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewWarranty;
        private System.Windows.Forms.Label lbl_uname;
        private System.Windows.Forms.Button btn_print;
    }
}
