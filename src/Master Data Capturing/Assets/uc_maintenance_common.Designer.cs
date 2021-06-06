
namespace Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets
{
    partial class uc_maintenance_common
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
            this.dateLastChecked = new System.Windows.Forms.DateTimePicker();
            this.comboCriticality = new System.Windows.Forms.ComboBox();
            this.comboCondition = new System.Windows.Forms.ComboBox();
            this.comboMaintainedBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateLastChecked);
            this.groupBox1.Controls.Add(this.comboCriticality);
            this.groupBox1.Controls.Add(this.comboCondition);
            this.groupBox1.Controls.Add(this.comboMaintainedBy);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 170);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maintenance";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateLastChecked
            // 
            this.dateLastChecked.Location = new System.Drawing.Point(498, 124);
            this.dateLastChecked.MaxDate = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            this.dateLastChecked.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dateLastChecked.Name = "dateLastChecked";
            this.dateLastChecked.Size = new System.Drawing.Size(406, 22);
            this.dateLastChecked.TabIndex = 3;
            this.dateLastChecked.Value = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            // 
            // comboCriticality
            // 
            this.comboCriticality.FormattingEnabled = true;
            this.comboCriticality.Location = new System.Drawing.Point(39, 122);
            this.comboCriticality.Name = "comboCriticality";
            this.comboCriticality.Size = new System.Drawing.Size(406, 24);
            this.comboCriticality.TabIndex = 2;
            // 
            // comboCondition
            // 
            this.comboCondition.FormattingEnabled = true;
            this.comboCondition.Location = new System.Drawing.Point(498, 52);
            this.comboCondition.Name = "comboCondition";
            this.comboCondition.Size = new System.Drawing.Size(406, 24);
            this.comboCondition.TabIndex = 2;
            // 
            // comboMaintainedBy
            // 
            this.comboMaintainedBy.FormattingEnabled = true;
            this.comboMaintainedBy.Location = new System.Drawing.Point(39, 52);
            this.comboMaintainedBy.Name = "comboMaintainedBy";
            this.comboMaintainedBy.Size = new System.Drawing.Size(406, 24);
            this.comboMaintainedBy.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Condition";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Last checked date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Criticality";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maintained by";
            // 
            // uc_maintenance_common
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "uc_maintenance_common";
            this.Size = new System.Drawing.Size(952, 183);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateLastChecked;
        private System.Windows.Forms.ComboBox comboCriticality;
        private System.Windows.Forms.ComboBox comboCondition;
        private System.Windows.Forms.ComboBox comboMaintainedBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}
