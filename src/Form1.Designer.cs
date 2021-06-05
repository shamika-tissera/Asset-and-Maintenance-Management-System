
namespace Asset_and_Maintenance_Management_System
{
    partial class startup_main
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
            this.btn_continue = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.uc_compName1 = new Asset_and_Maintenance_Management_System.uc_compName();
            this.uc_welcome_11 = new Asset_and_Maintenance_Management_System.uc_welcome_1();
            this.assetTypes1 = new Asset_and_Maintenance_Management_System.src.assetTypes();
            this.SuspendLayout();
            // 
            // btn_continue
            // 
            this.btn_continue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.btn_continue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_continue.Location = new System.Drawing.Point(973, 642);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(123, 33);
            this.btn_continue.TabIndex = 0;
            this.btn_continue.Text = "Continue";
            this.btn_continue.UseVisualStyleBackColor = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancel.Location = new System.Drawing.Point(830, 642);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(123, 33);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // uc_compName1
            // 
            this.uc_compName1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.uc_compName1.Location = new System.Drawing.Point(0, 0);
            this.uc_compName1.Name = "uc_compName1";
            this.uc_compName1.Size = new System.Drawing.Size(1136, 636);
            this.uc_compName1.TabIndex = 2;
            // 
            // uc_welcome_11
            // 
            this.uc_welcome_11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.uc_welcome_11.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_welcome_11.Location = new System.Drawing.Point(0, 0);
            this.uc_welcome_11.Name = "uc_welcome_11";
            this.uc_welcome_11.Size = new System.Drawing.Size(1136, 636);
            this.uc_welcome_11.TabIndex = 1;
            // 
            // assetTypes1
            // 
            this.assetTypes1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.assetTypes1.Location = new System.Drawing.Point(0, 0);
            this.assetTypes1.Name = "assetTypes1";
            this.assetTypes1.Size = new System.Drawing.Size(1136, 636);
            this.assetTypes1.TabIndex = 3;
            // 
            // startup_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1136, 708);
            this.Controls.Add(this.assetTypes1);
            this.Controls.Add(this.uc_compName1);
            this.Controls.Add(this.uc_welcome_11);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_continue);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "startup_main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Button btn_cancel;
        private uc_welcome_1 uc_welcome_11;
        private uc_compName uc_compName1;
        private src.assetTypes assetTypes1;
    }
}

