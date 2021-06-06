
namespace Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets
{
    partial class uc_installInfo_common
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboPlant = new System.Windows.Forms.ComboBox();
            this.dateInstallation = new System.Windows.Forms.DateTimePicker();
            this.dateAcceptance = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboPlant);
            this.groupBox1.Controls.Add(this.dateInstallation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateAcceptance);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 162);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Installation Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboPlant
            // 
            this.comboPlant.FormattingEnabled = true;
            this.comboPlant.Items.AddRange(new object[] {
            "On-site",
            "Limited",
            "Life-time"});
            this.comboPlant.Location = new System.Drawing.Point(29, 115);
            this.comboPlant.Name = "comboPlant";
            this.comboPlant.Size = new System.Drawing.Size(406, 24);
            this.comboPlant.TabIndex = 8;
            this.comboPlant.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dateInstallation
            // 
            this.dateInstallation.Location = new System.Drawing.Point(29, 50);
            this.dateInstallation.MaxDate = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            this.dateInstallation.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dateInstallation.Name = "dateInstallation";
            this.dateInstallation.Size = new System.Drawing.Size(406, 22);
            this.dateInstallation.TabIndex = 7;
            this.dateInstallation.Value = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            // 
            // dateAcceptance
            // 
            this.dateAcceptance.Location = new System.Drawing.Point(488, 50);
            this.dateAcceptance.MaxDate = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            this.dateAcceptance.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dateAcceptance.Name = "dateAcceptance";
            this.dateAcceptance.Size = new System.Drawing.Size(406, 22);
            this.dateAcceptance.TabIndex = 7;
            this.dateAcceptance.Value = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plant";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Acceptance Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Installation Date";
            // 
            // uc_installInfo_common
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "uc_installInfo_common";
            this.Size = new System.Drawing.Size(928, 169);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboPlant;
        private System.Windows.Forms.DateTimePicker dateInstallation;
        private System.Windows.Forms.DateTimePicker dateAcceptance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
