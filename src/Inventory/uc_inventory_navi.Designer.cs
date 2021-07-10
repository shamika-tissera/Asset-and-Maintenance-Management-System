
namespace Asset_and_Maintenance_Management_System.src.Inventory
{
    partial class uc_inventory_navi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_inventory_navi));
            this.btn_back = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.btn_back.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(216)))), ((int)(((byte)(93)))));
            this.btn_back.Image = global::Asset_and_Maintenance_Management_System.Properties.Resources.backbutton__Custom___2_;
            this.btn_back.Location = new System.Drawing.Point(0, 0);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(273, 53);
            this.btn_back.TabIndex = 5;
            this.btn_back.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(3, 138);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(270, 40);
            this.button6.TabIndex = 6;
            this.button6.Text = "Levels";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(3, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Trends";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // uc_inventory_navi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn_back);
            this.Name = "uc_inventory_navi";
            this.Size = new System.Drawing.Size(273, 616);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
    }
}
