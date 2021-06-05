﻿
namespace Asset_and_Maintenance_Management_System.src
{
    partial class depreciationMethod
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.assetType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depreMethod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.accDepr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 115);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(396, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Asset Information";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assetType,
            this.totCost,
            this.depreMethod,
            this.accDepr});
            this.dataGridView1.Location = new System.Drawing.Point(205, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 287);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // assetType
            // 
            this.assetType.HeaderText = "Asset Type";
            this.assetType.MinimumWidth = 6;
            this.assetType.Name = "assetType";
            this.assetType.ReadOnly = true;
            this.assetType.Width = 125;
            // 
            // totCost
            // 
            this.totCost.HeaderText = "Total Cost";
            this.totCost.MinimumWidth = 6;
            this.totCost.Name = "totCost";
            this.totCost.ReadOnly = true;
            this.totCost.Width = 125;
            // 
            // depreMethod
            // 
            this.depreMethod.HeaderText = "Depreciation Method";
            this.depreMethod.Items.AddRange(new object[] {
            "Reducing Balance",
            "Straight Line"});
            this.depreMethod.MinimumWidth = 6;
            this.depreMethod.Name = "depreMethod";
            this.depreMethod.ReadOnly = true;
            this.depreMethod.Width = 125;
            // 
            // accDepr
            // 
            this.accDepr.HeaderText = "Accumulated Depreciation";
            this.accDepr.MinimumWidth = 6;
            this.accDepr.Name = "accDepr";
            this.accDepr.ReadOnly = true;
            this.accDepr.Width = 125;
            // 
            // depreciationMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "depreciationMethod";
            this.Size = new System.Drawing.Size(1136, 636);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetType;
        private System.Windows.Forms.DataGridViewTextBoxColumn totCost;
        private System.Windows.Forms.DataGridViewComboBoxColumn depreMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn accDepr;
    }
}
