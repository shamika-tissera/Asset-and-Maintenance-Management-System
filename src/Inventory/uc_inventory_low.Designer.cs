
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLowInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLowInventory
            // 
            this.dataGridViewLowInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLowInventory.Location = new System.Drawing.Point(52, 43);
            this.dataGridViewLowInventory.Name = "dataGridViewLowInventory";
            this.dataGridViewLowInventory.RowHeadersWidth = 51;
            this.dataGridViewLowInventory.RowTemplate.Height = 24;
            this.dataGridViewLowInventory.Size = new System.Drawing.Size(1151, 710);
            this.dataGridViewLowInventory.TabIndex = 0;
            // 
            // uc_inventory_low
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.dataGridViewLowInventory);
            this.Name = "uc_inventory_low";
            this.Size = new System.Drawing.Size(1356, 826);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLowInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLowInventory;
    }
}
