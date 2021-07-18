﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.navPanel = new System.Windows.Forms.Panel();
            this.pnl_highlight = new System.Windows.Forms.Panel();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.initialInterfaceAsset1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.initialInterfaceAsset();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_uname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uc_navPanel_assets1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.uc_navPanel_assets();
            this.uc_assets_11 = new Asset_and_Maintenance_Management_System.src.Dashboard.uc_assets_1();
            this.uc_analytics_navi_one1 = new Asset_and_Maintenance_Management_System.src.Analytics.uc_analytics_navi_one();
            this.uc_inventory_navi1 = new Asset_and_Maintenance_Management_System.src.Inventory.uc_inventory_navi();
            this.uc_maintenance_navi1 = new Asset_and_Maintenance_Management_System.src.Maintenance.uc_maintenance_navi();
            this.uc_dash_main1 = new Asset_and_Maintenance_Management_System.src.Dashboard.uc_dash_main();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.uc_calendar1 = new Asset_and_Maintenance_Management_System.src.Dashboard.uc_calendar();
            this.dashboard_info1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.dashboard_info();
            this.uc_maintenance_reccomendations1 = new Asset_and_Maintenance_Management_System.src.Maintenance.uc_maintenance_reccomendations();
            this.uc_maintenance_backlog1 = new Asset_and_Maintenance_Management_System.src.Maintenance.uc_maintenance_backlog();
            this.uc_maintenance_dashboard_info1 = new Asset_and_Maintenance_Management_System.src.Maintenance.uc_maintenance_dashboard_info();
            this.uc_analytics_intial_dash2 = new Asset_and_Maintenance_Management_System.src.Analytics.uc_analytics_intial_dash();
            this.uc_inventory_dash1 = new Asset_and_Maintenance_Management_System.src.Inventory.uc_inventory_dash();
            this.uc_asset_browse1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.uc_asset_browse();
            this.uc_inventory_trends1 = new Asset_and_Maintenance_Management_System.src.Inventory.uc_inventory_trends();
            this.navPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.navPanel.Controls.Add(this.pnl_highlight);
            this.navPanel.Controls.Add(this.elementHost1);
            this.navPanel.Controls.Add(this.panel2);
            this.navPanel.Controls.Add(this.uc_navPanel_assets1);
            this.navPanel.Controls.Add(this.uc_assets_11);
            this.navPanel.Controls.Add(this.uc_analytics_navi_one1);
            this.navPanel.Controls.Add(this.uc_inventory_navi1);
            this.navPanel.Controls.Add(this.uc_maintenance_navi1);
            this.navPanel.Controls.Add(this.uc_dash_main1);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(311, 826);
            this.navPanel.TabIndex = 1;
            this.navPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.navPanel_Paint);
            // 
            // pnl_highlight
            // 
            this.pnl_highlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(251)))));
            this.pnl_highlight.Location = new System.Drawing.Point(0, 261);
            this.pnl_highlight.Name = "pnl_highlight";
            this.pnl_highlight.Size = new System.Drawing.Size(3, 45);
            this.pnl_highlight.TabIndex = 14;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(9, 10);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(10, 0);
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
            this.lbl_uname.Location = new System.Drawing.Point(111, 172);
            this.lbl_uname.Name = "lbl_uname";
            this.lbl_uname.Size = new System.Drawing.Size(88, 20);
            this.lbl_uname.TabIndex = 2;
            this.lbl_uname.Text = "John Smith";
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
            // uc_inventory_navi1
            // 
            this.uc_inventory_navi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.uc_inventory_navi1.Location = new System.Drawing.Point(16, 210);
            this.uc_inventory_navi1.Name = "uc_inventory_navi1";
            this.uc_inventory_navi1.Size = new System.Drawing.Size(273, 616);
            this.uc_inventory_navi1.TabIndex = 8;
            // 
            // uc_maintenance_navi1
            // 
            this.uc_maintenance_navi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.uc_maintenance_navi1.Location = new System.Drawing.Point(21, 210);
            this.uc_maintenance_navi1.Name = "uc_maintenance_navi1";
            this.uc_maintenance_navi1.Size = new System.Drawing.Size(267, 616);
            this.uc_maintenance_navi1.TabIndex = 9;
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
            // pic_close
            // 
            this.pic_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(69)))), ((int)(((byte)(114)))));
            this.pic_close.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_close.Image = ((System.Drawing.Image)(resources.GetObject("pic_close.Image")));
            this.pic_close.Location = new System.Drawing.Point(1478, 11);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(30, 27);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_close.TabIndex = 11;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
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
            // uc_maintenance_reccomendations1
            // 
            this.uc_maintenance_reccomendations1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.uc_maintenance_reccomendations1.Location = new System.Drawing.Point(311, 0);
            this.uc_maintenance_reccomendations1.Name = "uc_maintenance_reccomendations1";
            this.uc_maintenance_reccomendations1.Size = new System.Drawing.Size(1356, 826);
            this.uc_maintenance_reccomendations1.TabIndex = 10;
            // 
            // uc_maintenance_backlog1
            // 
            this.uc_maintenance_backlog1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.uc_maintenance_backlog1.Location = new System.Drawing.Point(311, 0);
            this.uc_maintenance_backlog1.Name = "uc_maintenance_backlog1";
            this.uc_maintenance_backlog1.Size = new System.Drawing.Size(1356, 826);
            this.uc_maintenance_backlog1.TabIndex = 9;
            // 
            // uc_maintenance_dashboard_info1
            // 
            this.uc_maintenance_dashboard_info1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.uc_maintenance_dashboard_info1.Location = new System.Drawing.Point(311, 0);
            this.uc_maintenance_dashboard_info1.Name = "uc_maintenance_dashboard_info1";
            this.uc_maintenance_dashboard_info1.Size = new System.Drawing.Size(1356, 826);
            this.uc_maintenance_dashboard_info1.TabIndex = 8;
            // 
            // uc_analytics_intial_dash2
            // 
            this.uc_analytics_intial_dash2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.uc_analytics_intial_dash2.Location = new System.Drawing.Point(311, 0);
            this.uc_analytics_intial_dash2.Name = "uc_analytics_intial_dash2";
            this.uc_analytics_intial_dash2.Size = new System.Drawing.Size(1356, 826);
            this.uc_analytics_intial_dash2.TabIndex = 12;
            // 
            // uc_inventory_dash1
            // 
            this.uc_inventory_dash1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.uc_inventory_dash1.Location = new System.Drawing.Point(311, 0);
            this.uc_inventory_dash1.Name = "uc_inventory_dash1";
            this.uc_inventory_dash1.Size = new System.Drawing.Size(1356, 826);
            this.uc_inventory_dash1.TabIndex = 7;
            // 
            // uc_asset_browse1
            // 
            this.uc_asset_browse1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.uc_asset_browse1.Location = new System.Drawing.Point(311, 0);
            this.uc_asset_browse1.Name = "uc_asset_browse1";
            this.uc_asset_browse1.Size = new System.Drawing.Size(1356, 826);
            this.uc_asset_browse1.TabIndex = 13;
            // 
            // uc_inventory_trends1
            // 
            this.uc_inventory_trends1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.uc_inventory_trends1.Location = new System.Drawing.Point(311, 0);
            this.uc_inventory_trends1.Name = "uc_inventory_trends1";
            this.uc_inventory_trends1.Size = new System.Drawing.Size(1356, 826);
            this.uc_inventory_trends1.TabIndex = 14;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1520, 826);
            this.Controls.Add(this.uc_inventory_trends1);
            this.Controls.Add(this.pic_close);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.uc_calendar1);
            this.Controls.Add(this.dashboard_info1);
            this.Controls.Add(this.uc_maintenance_reccomendations1);
            this.Controls.Add(this.uc_maintenance_backlog1);
            this.Controls.Add(this.uc_maintenance_dashboard_info1);
            this.Controls.Add(this.uc_analytics_intial_dash2);
            this.Controls.Add(this.uc_inventory_dash1);
            this.Controls.Add(this.uc_asset_browse1);
            this.Controls.Add(this.navPanel);
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
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
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
        private Inventory.uc_inventory_navi uc_inventory_navi1;
        private Maintenance.uc_maintenance_navi uc_maintenance_navi1;
        private Maintenance.uc_maintenance_dashboard_info uc_maintenance_dashboard_info1;
        private Maintenance.uc_maintenance_backlog uc_maintenance_backlog1;
        private Maintenance.uc_maintenance_reccomendations uc_maintenance_reccomendations1;
        private System.Windows.Forms.PictureBox pic_close;
        private Analytics.uc_analytics_intial_dash uc_analytics_intial_dash2;
        private Master_Data_Capturing.Assets.uc_asset_browse uc_asset_browse1;
        private System.Windows.Forms.Panel pnl_highlight;
        private Inventory.uc_inventory_trends uc_inventory_trends1;
    }
}