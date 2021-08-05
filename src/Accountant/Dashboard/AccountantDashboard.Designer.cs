
namespace Asset_and_Maintenance_Management_System.src.Accountant.Dashboard
{
    partial class AccountantDashboard
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
            this.initialInterfaceAsset1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.initialInterfaceAsset();
            this.uc_dash_main_accountant1 = new Asset_and_Maintenance_Management_System.src.Accountant.Navigation.uc_dash_main_accountant();
            this.uc_calendar_accountant1 = new Asset_and_Maintenance_Management_System.src.Accountant.Dashboard.uc_calendar_accountant();
            this.navPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.Controls.Add(this.uc_dash_main_accountant1);
            this.navPanel.Controls.SetChildIndex(this.uc_dash_main_accountant1, 0);
            this.navPanel.Controls.SetChildIndex(this.uc_maintenance_navi1, 0);
            this.navPanel.Controls.SetChildIndex(this.uc_approval_navi1, 0);
            this.navPanel.Controls.SetChildIndex(this.uc_inventory_navi1, 0);
            this.navPanel.Controls.SetChildIndex(this.uc_analytics_navi_one1, 0);
            this.navPanel.Controls.SetChildIndex(this.uc_assets_11, 0);
            this.navPanel.Controls.SetChildIndex(this.uc_navPanel_assets1, 0);
            this.navPanel.Controls.SetChildIndex(this.uc_dash_main1, 0);
            this.navPanel.Controls.SetChildIndex(this.panel2, 0);
            this.navPanel.Controls.SetChildIndex(this.elementHost1, 0);
            this.navPanel.Controls.SetChildIndex(this.pnl_highlight, 0);
            // 
            // uc_dash_main1
            // 
            this.uc_dash_main1.Location = new System.Drawing.Point(21, 204);
            this.uc_dash_main1.Visible = false;
            this.elementHost1.Child = this.initialInterfaceAsset1;
            // 
            // uc_analytics_utilization1
            // 
            this.uc_analytics_utilization1.Location = new System.Drawing.Point(311, 0);
            // 
            // uc_dash_main_accountant1
            // 
            this.uc_dash_main_accountant1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.uc_dash_main_accountant1.Location = new System.Drawing.Point(21, 204);
            this.uc_dash_main_accountant1.Name = "uc_dash_main_accountant1";
            this.uc_dash_main_accountant1.Size = new System.Drawing.Size(267, 616);
            this.uc_dash_main_accountant1.TabIndex = 16;
            // 
            // uc_calendar_accountant1
            // 
            this.uc_calendar_accountant1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.uc_calendar_accountant1.Location = new System.Drawing.Point(311, 0);
            this.uc_calendar_accountant1.Name = "uc_calendar_accountant1";
            this.uc_calendar_accountant1.Size = new System.Drawing.Size(1225, 901);
            this.uc_calendar_accountant1.TabIndex = 25;
            // 
            // AccountantDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 826);
            this.Controls.Add(this.uc_calendar_accountant1);
            this.Name = "AccountantDashboard";
            this.Text = "AccountantDashboard";
            this.Controls.SetChildIndex(this.uc_stock_requests1, 0);
            this.Controls.SetChildIndex(this.uc_stock_reception1, 0);
            this.Controls.SetChildIndex(this.uc_preventive_maintenance1, 0);
            this.Controls.SetChildIndex(this.uc_corrective_maintenance1, 0);
            this.Controls.SetChildIndex(this.uc_analytics_utilization1, 0);
            this.Controls.SetChildIndex(this.uc_inventory_trends1, 0);
            this.Controls.SetChildIndex(this.uc_asset_browse1, 0);
            this.Controls.SetChildIndex(this.uc_analytics_warranty1, 0);
            this.Controls.SetChildIndex(this.uc_profit_on_disposal1, 0);
            this.Controls.SetChildIndex(this.uc_inventory_levels1, 0);
            this.Controls.SetChildIndex(this.uc_inventory_dash1, 0);
            this.Controls.SetChildIndex(this.uc_analytics_intial_dash2, 0);
            this.Controls.SetChildIndex(this.uc_maintenance_dashboard_info1, 0);
            this.Controls.SetChildIndex(this.uc_maintenance_backlog1, 0);
            this.Controls.SetChildIndex(this.uc_maintenance_reccomendations1, 0);
            this.Controls.SetChildIndex(this.dashboard_info1, 0);
            this.Controls.SetChildIndex(this.uc_calendar1, 0);
            this.Controls.SetChildIndex(this.navPanel, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.pic_close, 0);
            this.Controls.SetChildIndex(this.uc_calendar_accountant1, 0);
            this.navPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Navigation.uc_dash_main_accountant uc_dash_main_accountant1;
        protected Master_Data_Capturing.Assets.initialInterfaceAsset hostedComponent1;
        protected Master_Data_Capturing.Assets.initialInterfaceAsset initialInterfaceAsset1;
        private uc_calendar_accountant uc_calendar_accountant1;
    }
}