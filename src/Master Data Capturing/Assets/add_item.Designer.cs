
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
            this.uc_general_common1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.uc_general_common();
            this.uc_maintenance_common1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.uc_maintenance_common();
            this.uc_location_common1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.uc_location_common();
            this.uc_administrative_common1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.uc_administrative_common();
            this.uc_warranty_common1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.uc_warranty_common();
            this.uc_installInfo_common1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.uc_installInfo_common();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uc_general_common1
            // 
            this.uc_general_common1.Location = new System.Drawing.Point(12, 3);
            this.uc_general_common1.Name = "uc_general_common1";
            this.uc_general_common1.Size = new System.Drawing.Size(963, 248);
            this.uc_general_common1.TabIndex = 0;
            // 
            // uc_maintenance_common1
            // 
            this.uc_maintenance_common1.Location = new System.Drawing.Point(19, 242);
            this.uc_maintenance_common1.Name = "uc_maintenance_common1";
            this.uc_maintenance_common1.Size = new System.Drawing.Size(952, 242);
            this.uc_maintenance_common1.TabIndex = 1;
            // 
            // uc_location_common1
            // 
            this.uc_location_common1.Location = new System.Drawing.Point(23, 489);
            this.uc_location_common1.Name = "uc_location_common1";
            this.uc_location_common1.Size = new System.Drawing.Size(952, 168);
            this.uc_location_common1.TabIndex = 2;
            // 
            // uc_administrative_common1
            // 
            this.uc_administrative_common1.Location = new System.Drawing.Point(24, 657);
            this.uc_administrative_common1.Name = "uc_administrative_common1";
            this.uc_administrative_common1.Size = new System.Drawing.Size(951, 375);
            this.uc_administrative_common1.TabIndex = 3;
            // 
            // uc_warranty_common1
            // 
            this.uc_warranty_common1.Location = new System.Drawing.Point(24, 1038);
            this.uc_warranty_common1.Name = "uc_warranty_common1";
            this.uc_warranty_common1.Size = new System.Drawing.Size(929, 168);
            this.uc_warranty_common1.TabIndex = 5;
            this.uc_warranty_common1.Load += new System.EventHandler(this.uc_warranty_common1_Load);
            // 
            // uc_installInfo_common1
            // 
            this.uc_installInfo_common1.Location = new System.Drawing.Point(27, 1212);
            this.uc_installInfo_common1.Name = "uc_installInfo_common1";
            this.uc_installInfo_common1.Size = new System.Drawing.Size(928, 169);
            this.uc_installInfo_common1.TabIndex = 6;
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
            this.panel1.Location = new System.Drawing.Point(657, 1447);
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
            // add_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1082, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uc_installInfo_common1);
            this.Controls.Add(this.uc_warranty_common1);
            this.Controls.Add(this.uc_administrative_common1);
            this.Controls.Add(this.uc_location_common1);
            this.Controls.Add(this.uc_maintenance_common1);
            this.Controls.Add(this.uc_general_common1);
            this.Name = "add_item";
            this.Text = "Add Item";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private uc_general_common uc_general_common1;
        private uc_maintenance_common uc_maintenance_common1;
        private uc_location_common uc_location_common1;
        private uc_administrative_common uc_administrative_common1;
        private uc_warranty_common uc_warranty_common1;
        private uc_installInfo_common uc_installInfo_common1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}