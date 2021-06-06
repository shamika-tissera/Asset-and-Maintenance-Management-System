
namespace Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets
{
    partial class add_item
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.uc_location_common1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.uc_location_common();
            this.uc_maintenance_common1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.uc_maintenance_common();
            this.uc_installInfo_common1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.uc_installInfo_common();
            this.uc_warranty_common1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.uc_warranty_common();
            this.uc_administrative_common1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.uc_administrative_common();
            this.uc_general_common1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.uc_general_common();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(575, 1319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 102);
            this.panel1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // uc_location_common1
            // 
            this.uc_location_common1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_location_common1.Location = new System.Drawing.Point(0, 1139);
            this.uc_location_common1.Name = "uc_location_common1";
            this.uc_location_common1.Size = new System.Drawing.Size(979, 174);
            this.uc_location_common1.TabIndex = 10;
            // 
            // uc_maintenance_common1
            // 
            this.uc_maintenance_common1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_maintenance_common1.Location = new System.Drawing.Point(0, 960);
            this.uc_maintenance_common1.Name = "uc_maintenance_common1";
            this.uc_maintenance_common1.Size = new System.Drawing.Size(979, 179);
            this.uc_maintenance_common1.TabIndex = 9;
            // 
            // uc_installInfo_common1
            // 
            this.uc_installInfo_common1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_installInfo_common1.Location = new System.Drawing.Point(0, 791);
            this.uc_installInfo_common1.Name = "uc_installInfo_common1";
            this.uc_installInfo_common1.Size = new System.Drawing.Size(979, 169);
            this.uc_installInfo_common1.TabIndex = 6;
            this.uc_installInfo_common1.Load += new System.EventHandler(this.uc_installInfo_common1_Load);
            // 
            // uc_warranty_common1
            // 
            this.uc_warranty_common1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_warranty_common1.Location = new System.Drawing.Point(0, 623);
            this.uc_warranty_common1.Name = "uc_warranty_common1";
            this.uc_warranty_common1.Size = new System.Drawing.Size(979, 168);
            this.uc_warranty_common1.TabIndex = 5;
            this.uc_warranty_common1.Load += new System.EventHandler(this.uc_warranty_common1_Load);
            // 
            // uc_administrative_common1
            // 
            this.uc_administrative_common1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_administrative_common1.Location = new System.Drawing.Point(0, 248);
            this.uc_administrative_common1.Name = "uc_administrative_common1";
            this.uc_administrative_common1.Size = new System.Drawing.Size(979, 375);
            this.uc_administrative_common1.TabIndex = 3;
            this.uc_administrative_common1.Load += new System.EventHandler(this.uc_administrative_common1_Load);
            // 
            // uc_general_common1
            // 
            this.uc_general_common1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_general_common1.Location = new System.Drawing.Point(0, 0);
            this.uc_general_common1.Name = "uc_general_common1";
            this.uc_general_common1.Size = new System.Drawing.Size(979, 248);
            this.uc_general_common1.TabIndex = 0;
            // 
            // add_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1000, 1055);
            this.Controls.Add(this.uc_location_common1);
            this.Controls.Add(this.uc_maintenance_common1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uc_installInfo_common1);
            this.Controls.Add(this.uc_warranty_common1);
            this.Controls.Add(this.uc_administrative_common1);
            this.Controls.Add(this.uc_general_common1);
            this.Name = "add_item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.add_item_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private uc_general_common uc_general_common1;
        private uc_administrative_common uc_administrative_common1;
        private uc_warranty_common uc_warranty_common1;
        private uc_installInfo_common uc_installInfo_common1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private uc_maintenance_common uc_maintenance_common1;
        private uc_location_common uc_location_common1;
    }
}