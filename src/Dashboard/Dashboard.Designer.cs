
namespace Asset_and_Maintenance_Management_System.src.Dashboard
{
    partial class Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_uname = new System.Windows.Forms.Label();
            this.dataGridAssets = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uc_calendar1 = new Asset_and_Maintenance_Management_System.src.Dashboard.uc_calendar();
            this.uc_navPanel_assets1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.uc_navPanel_assets();
            this.uc_assets_11 = new Asset_and_Maintenance_Management_System.src.Dashboard.uc_assets_1();
            this.uc_dash_main1 = new Asset_and_Maintenance_Management_System.src.Dashboard.uc_dash_main();
            this.navPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAssets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.navPanel.Controls.Add(this.uc_navPanel_assets1);
            this.navPanel.Controls.Add(this.panel2);
            this.navPanel.Controls.Add(this.uc_assets_11);
            this.navPanel.Controls.Add(this.uc_dash_main1);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(311, 826);
            this.navPanel.TabIndex = 1;
            this.navPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.navPanel_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_uname);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 204);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbl_uname
            // 
            this.lbl_uname.AutoSize = true;
            this.lbl_uname.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_uname.Location = new System.Drawing.Point(115, 172);
            this.lbl_uname.Name = "lbl_uname";
            this.lbl_uname.Size = new System.Drawing.Size(80, 20);
            this.lbl_uname.TabIndex = 2;
            this.lbl_uname.Text = "Username";
            // 
            // dataGridAssets
            // 
            this.dataGridAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAssets.Location = new System.Drawing.Point(311, 0);
            this.dataGridAssets.Name = "dataGridAssets";
            this.dataGridAssets.RowHeadersWidth = 51;
            this.dataGridAssets.RowTemplate.Height = 24;
            this.dataGridAssets.Size = new System.Drawing.Size(1356, 826);
            this.dataGridAssets.TabIndex = 5;
            this.dataGridAssets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Asset_and_Maintenance_Management_System.Properties.Resources.User_with_smile_svg;
            this.pictureBox1.Location = new System.Drawing.Point(23, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // uc_calendar1
            // 
            this.uc_calendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.uc_calendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_calendar1.Location = new System.Drawing.Point(311, 0);
            this.uc_calendar1.Name = "uc_calendar1";
            this.uc_calendar1.Size = new System.Drawing.Size(1356, 826);
            this.uc_calendar1.TabIndex = 2;
            // 
            // uc_navPanel_assets1
            // 
            this.uc_navPanel_assets1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.uc_navPanel_assets1.Location = new System.Drawing.Point(20, 204);
            this.uc_navPanel_assets1.Name = "uc_navPanel_assets1";
            this.uc_navPanel_assets1.Size = new System.Drawing.Size(267, 616);
            this.uc_navPanel_assets1.TabIndex = 4;
            // 
            // uc_assets_11
            // 
            this.uc_assets_11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.uc_assets_11.Location = new System.Drawing.Point(20, 207);
            this.uc_assets_11.Name = "uc_assets_11";
            this.uc_assets_11.Size = new System.Drawing.Size(267, 616);
            this.uc_assets_11.TabIndex = 2;
            this.uc_assets_11.Load += new System.EventHandler(this.uc_assets_11_Load);
            // 
            // uc_dash_main1
            // 
            this.uc_dash_main1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.uc_dash_main1.Location = new System.Drawing.Point(21, 210);
            this.uc_dash_main1.Name = "uc_dash_main1";
            this.uc_dash_main1.Size = new System.Drawing.Size(267, 616);
            this.uc_dash_main1.TabIndex = 3;
            this.uc_dash_main1.Load += new System.EventHandler(this.uc_dash_main1_Load);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1667, 826);
            this.Controls.Add(this.dataGridAssets);
            this.Controls.Add(this.uc_calendar1);
            this.Controls.Add(this.navPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.navPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAssets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_uname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private uc_dash_main uc_dash_main1;
        private uc_assets_1 uc_assets_11;
        private uc_calendar uc_calendar1;
        private System.Windows.Forms.DataGridView dataGridAssets;
        private Master_Data_Capturing.Assets.uc_navPanel_assets uc_navPanel_assets1;
    }
}