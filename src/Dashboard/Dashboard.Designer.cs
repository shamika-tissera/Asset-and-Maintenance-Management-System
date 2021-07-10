
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
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.initialInterfaceAsset1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.initialInterfaceAsset();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_uname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uc_dash_main1 = new Asset_and_Maintenance_Management_System.src.Dashboard.uc_dash_main();
            this.uc_navPanel_assets1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.uc_navPanel_assets();
            this.uc_assets_11 = new Asset_and_Maintenance_Management_System.src.Dashboard.uc_assets_1();
            this.uc_analytics_navi_one1 = new Asset_and_Maintenance_Management_System.src.Analytics.uc_analytics_navi_one();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uc_calendar1 = new Asset_and_Maintenance_Management_System.src.Dashboard.uc_calendar();
            this.uc_analytics_intial_dash1 = new Asset_and_Maintenance_Management_System.src.Analytics.uc_analytics_intial_dash();
            this.dashboard_info1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.dashboard_info();
            this.uc_inventory_dash1 = new Asset_and_Maintenance_Management_System.src.Inventory.uc_inventory_dash();
            this.navPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.navPanel.Controls.Add(this.elementHost1);
            this.navPanel.Controls.Add(this.panel2);
            this.navPanel.Controls.Add(this.uc_dash_main1);
            this.navPanel.Controls.Add(this.uc_navPanel_assets1);
            this.navPanel.Controls.Add(this.uc_assets_11);
            this.navPanel.Controls.Add(this.uc_analytics_navi_one1);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(311, 826);
            this.navPanel.TabIndex = 1;
            this.navPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.navPanel_Paint);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(92, 631);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(10, 10);
            this.elementHost1.TabIndex = 7;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.initialInterfaceAsset1;
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
            // uc_dash_main1
            // 
            this.uc_dash_main1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.uc_dash_main1.Location = new System.Drawing.Point(21, 210);
            this.uc_dash_main1.Name = "uc_dash_main1";
            this.uc_dash_main1.Size = new System.Drawing.Size(267, 616);
            this.uc_dash_main1.TabIndex = 3;
            this.uc_dash_main1.Load += new System.EventHandler(this.uc_dash_main1_Load);
            // 
            // uc_navPanel_assets1
            // 
            this.uc_navPanel_assets1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.uc_navPanel_assets1.Location = new System.Drawing.Point(20, 204);
            this.uc_navPanel_assets1.Name = "uc_navPanel_assets1";
            this.uc_navPanel_assets1.Size = new System.Drawing.Size(267, 616);
            this.uc_navPanel_assets1.TabIndex = 4;
            this.uc_navPanel_assets1.Load += new System.EventHandler(this.uc_navPanel_assets1_Load);
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
            // uc_analytics_navi_one1
            // 
            this.uc_analytics_navi_one1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.uc_analytics_navi_one1.Location = new System.Drawing.Point(20, 204);
            this.uc_analytics_navi_one1.Name = "uc_analytics_navi_one1";
            this.uc_analytics_navi_one1.Size = new System.Drawing.Size(267, 616);
            this.uc_analytics_navi_one1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Asset_and_Maintenance_Management_System.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(1627, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // uc_calendar1
            // 
            this.uc_calendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.uc_calendar1.Location = new System.Drawing.Point(311, 0);
            this.uc_calendar1.Name = "uc_calendar1";
            this.uc_calendar1.Size = new System.Drawing.Size(1261, 826);
            this.uc_calendar1.TabIndex = 2;
            this.uc_calendar1.Load += new System.EventHandler(this.uc_calendar1_Load);
            // 
            // uc_analytics_intial_dash1
            // 
            this.uc_analytics_intial_dash1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.uc_analytics_intial_dash1.Location = new System.Drawing.Point(311, 0);
            this.uc_analytics_intial_dash1.Name = "uc_analytics_intial_dash1";
            this.uc_analytics_intial_dash1.Size = new System.Drawing.Size(1210, 826);
            this.uc_analytics_intial_dash1.TabIndex = 6;
            // 
            // dashboard_info1
            // 
            this.dashboard_info1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.dashboard_info1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dashboard_info1.Location = new System.Drawing.Point(311, 0);
            this.dashboard_info1.Name = "dashboard_info1";
            this.dashboard_info1.Size = new System.Drawing.Size(1245, 826);
            this.dashboard_info1.TabIndex = 5;
            this.dashboard_info1.Load += new System.EventHandler(this.dashboard_info1_Load);
            // 
            // uc_inventory_dash1
            // 
            this.uc_inventory_dash1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.uc_inventory_dash1.Location = new System.Drawing.Point(311, 0);
            this.uc_inventory_dash1.Name = "uc_inventory_dash1";
            this.uc_inventory_dash1.Size = new System.Drawing.Size(1356, 826);
            this.uc_inventory_dash1.TabIndex = 7;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1520, 826);
            this.Controls.Add(this.uc_inventory_dash1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.uc_calendar1);
            this.Controls.Add(this.uc_analytics_intial_dash1);
            this.Controls.Add(this.dashboard_info1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.navPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_uname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private uc_dash_main uc_dash_main1;
        private uc_assets_1 uc_assets_11;
        private Master_Data_Capturing.Assets.uc_navPanel_assets uc_navPanel_assets1;
        private uc_calendar uc_calendar1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Master_Data_Capturing.Assets.dashboard_info dashboard_info1;
        private Analytics.uc_analytics_navi_one uc_analytics_navi_one1;
        private Analytics.uc_analytics_intial_dash uc_analytics_intial_dash1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private Master_Data_Capturing.Assets.initialInterfaceAsset initialInterfaceAsset1;
        private Inventory.uc_inventory_dash uc_inventory_dash1;
    }
}