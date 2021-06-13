
namespace Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets
{
    partial class FormHeater
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
            this.uc_HeaterTechnical1 = new Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets.uc_HeaterTechnical();
            this.SuspendLayout();
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(782, 1851);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(917, 1851);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(647, 1851);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(313, 1985);
            // 
            // uc_HeaterTechnical1
            // 
            this.uc_HeaterTechnical1.Location = new System.Drawing.Point(0, 1319);
            this.uc_HeaterTechnical1.Name = "uc_HeaterTechnical1";
            this.uc_HeaterTechnical1.Size = new System.Drawing.Size(1028, 488);
            this.uc_HeaterTechnical1.TabIndex = 11;
            // 
            // FormHeater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 735);
            this.Controls.Add(this.uc_HeaterTechnical1);
            this.Name = "FormHeater";
            this.Text = "FormHeater";
            this.Load += new System.EventHandler(this.FormHeater_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btn_reset, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.uc_HeaterTechnical1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private uc_HeaterTechnical uc_HeaterTechnical1;
    }
}