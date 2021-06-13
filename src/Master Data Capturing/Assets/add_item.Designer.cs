
namespace Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets
{
    partial class add_item
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
            this.btn_reset = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uc_location_common1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.uc_location_common();
            this.uc_maintenance_common1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.uc_maintenance_common();
            this.uc_installInfo_common1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.uc_installInfo_common();
            this.uc_warranty_common1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.uc_warranty_common();
            this.uc_administrative_common1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.uc_administrative_common();
            this.uc_general_common1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.uc_general_common();
            this.SuspendLayout();
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(717, 1868);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(95, 32);
            this.btn_reset.TabIndex = 109;
            this.btn_reset.Text = "&Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(845, 1868);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 32);
            this.btnOK.TabIndex = 107;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(582, 1868);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 32);
            this.btnCancel.TabIndex = 108;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(301, 2112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 19);
            this.panel1.TabIndex = 106;
            // 
            // uc_location_common1
            // 
            this.uc_location_common1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_location_common1.Location = new System.Drawing.Point(0, 1139);
            this.uc_location_common1.Name = "uc_location_common1";
            this.uc_location_common1.Size = new System.Drawing.Size(1080, 174);
            this.uc_location_common1.TabIndex = 10;
            // 
            // uc_maintenance_common1
            // 
            this.uc_maintenance_common1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_maintenance_common1.Location = new System.Drawing.Point(0, 960);
            this.uc_maintenance_common1.Name = "uc_maintenance_common1";
            this.uc_maintenance_common1.Size = new System.Drawing.Size(1080, 179);
            this.uc_maintenance_common1.TabIndex = 9;
            // 
            // uc_installInfo_common1
            // 
            this.uc_installInfo_common1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_installInfo_common1.Location = new System.Drawing.Point(0, 791);
            this.uc_installInfo_common1.Name = "uc_installInfo_common1";
            this.uc_installInfo_common1.Size = new System.Drawing.Size(1080, 169);
            this.uc_installInfo_common1.TabIndex = 6;
            this.uc_installInfo_common1.Load += new System.EventHandler(this.uc_installInfo_common1_Load);
            // 
            // uc_warranty_common1
            // 
            this.uc_warranty_common1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_warranty_common1.Location = new System.Drawing.Point(0, 623);
            this.uc_warranty_common1.Name = "uc_warranty_common1";
            this.uc_warranty_common1.Size = new System.Drawing.Size(1080, 168);
            this.uc_warranty_common1.TabIndex = 5;
            this.uc_warranty_common1.Load += new System.EventHandler(this.uc_warranty_common1_Load);
            // 
            // uc_administrative_common1
            // 
            this.uc_administrative_common1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_administrative_common1.Location = new System.Drawing.Point(0, 248);
            this.uc_administrative_common1.Name = "uc_administrative_common1";
            this.uc_administrative_common1.Size = new System.Drawing.Size(1080, 375);
            this.uc_administrative_common1.TabIndex = 3;
            this.uc_administrative_common1.Load += new System.EventHandler(this.uc_administrative_common1_Load);
            // 
            // uc_general_common1
            // 
            this.uc_general_common1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_general_common1.Location = new System.Drawing.Point(0, 0);
            this.uc_general_common1.Name = "uc_general_common1";
            this.uc_general_common1.Size = new System.Drawing.Size(1080, 248);
            this.uc_general_common1.TabIndex = 0;
            // 
            // add_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1101, 1055);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uc_location_common1);
            this.Controls.Add(this.uc_maintenance_common1);
            this.Controls.Add(this.uc_installInfo_common1);
            this.Controls.Add(this.uc_warranty_common1);
            this.Controls.Add(this.uc_administrative_common1);
            this.Controls.Add(this.uc_general_common1);
            this.Name = "add_item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.add_item_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private uc_general_common uc_general_common1;
        private uc_administrative_common uc_administrative_common1;
        private uc_warranty_common uc_warranty_common1;
        private uc_installInfo_common uc_installInfo_common1;
        private uc_maintenance_common uc_maintenance_common1;
        private uc_location_common uc_location_common1;
        protected System.Windows.Forms.Button btn_reset;
        protected System.Windows.Forms.Button btnOK;
        protected System.Windows.Forms.Button btnCancel;
        protected System.Windows.Forms.Panel panel1;
    }
}