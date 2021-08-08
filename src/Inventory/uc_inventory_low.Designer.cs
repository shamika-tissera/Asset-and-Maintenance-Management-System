
namespace Asset_and_Maintenance_Management_System.src.Inventory
{
    partial class uc_inventory_low
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
            this.dataGridViewLowInventory = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDispose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLowInventory)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewLowInventory
            // 
            this.dataGridViewLowInventory.AllowUserToAddRows = false;
            this.dataGridViewLowInventory.AllowUserToDeleteRows = false;
            this.dataGridViewLowInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.dataGridViewLowInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLowInventory.Location = new System.Drawing.Point(31, 23);
            this.dataGridViewLowInventory.Name = "dataGridViewLowInventory";
            this.dataGridViewLowInventory.ReadOnly = true;
            this.dataGridViewLowInventory.RowHeadersWidth = 51;
            this.dataGridViewLowInventory.RowTemplate.Height = 24;
            this.dataGridViewLowInventory.Size = new System.Drawing.Size(1016, 652);
            this.dataGridViewLowInventory.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnDispose);
            this.panel1.Controls.Add(this.dataGridViewLowInventory);
            this.panel1.Location = new System.Drawing.Point(52, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 764);
            this.panel1.TabIndex = 1;
            // 
            // btnDispose
            // 
            this.btnDispose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.btnDispose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDispose.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDispose.Location = new System.Drawing.Point(892, 705);
            this.btnDispose.Name = "btnDispose";
            this.btnDispose.Size = new System.Drawing.Size(123, 33);
            this.btnDispose.TabIndex = 8;
            this.btnDispose.Text = "&Print";
            this.btnDispose.UseVisualStyleBackColor = false;
            this.btnDispose.Click += new System.EventHandler(this.btnDispose_Click);
            // 
            // uc_inventory_low
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.panel1);
            this.Name = "uc_inventory_low";
            this.Size = new System.Drawing.Size(1356, 826);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLowInventory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLowInventory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDispose;
    }
}
