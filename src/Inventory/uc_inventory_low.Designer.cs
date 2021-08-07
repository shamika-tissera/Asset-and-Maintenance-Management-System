
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
            this.dataGridViewLowInventory.Size = new System.Drawing.Size(1016, 710);
            this.dataGridViewLowInventory.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.dataGridViewLowInventory);
            this.panel1.Location = new System.Drawing.Point(52, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 764);
            this.panel1.TabIndex = 1;
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
    }
}
