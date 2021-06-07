
namespace Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets
{
    partial class uc_location_common
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
            this.comboFloor = new System.Windows.Forms.ComboBox();
            this.comboRoom = new System.Windows.Forms.ComboBox();
            this.comboBuilding = new System.Windows.Forms.ComboBox();
            this.comboBranch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboFloor);
            this.groupBox1.Controls.Add(this.comboRoom);
            this.groupBox1.Controls.Add(this.comboBuilding);
            this.groupBox1.Controls.Add(this.comboBranch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 165);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboFloor
            // 
            this.comboFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFloor.FormattingEnabled = true;
            this.comboFloor.Location = new System.Drawing.Point(39, 122);
            this.comboFloor.Name = "comboFloor";
            this.comboFloor.Size = new System.Drawing.Size(406, 24);
            this.comboFloor.TabIndex = 3;
            // 
            // comboRoom
            // 
            this.comboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRoom.FormattingEnabled = true;
            this.comboRoom.Location = new System.Drawing.Point(498, 122);
            this.comboRoom.Name = "comboRoom";
            this.comboRoom.Size = new System.Drawing.Size(406, 24);
            this.comboRoom.TabIndex = 4;
            // 
            // comboBuilding
            // 
            this.comboBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBuilding.FormattingEnabled = true;
            this.comboBuilding.Location = new System.Drawing.Point(498, 52);
            this.comboBuilding.Name = "comboBuilding";
            this.comboBuilding.Size = new System.Drawing.Size(406, 24);
            this.comboBuilding.TabIndex = 2;
            // 
            // comboBranch
            // 
            this.comboBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBranch.FormattingEnabled = true;
            this.comboBranch.Location = new System.Drawing.Point(39, 52);
            this.comboBranch.Name = "comboBranch";
            this.comboBranch.Size = new System.Drawing.Size(406, 24);
            this.comboBranch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Building";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Room";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Floor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Branch";
            // 
            // uc_location_common
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "uc_location_common";
            this.Size = new System.Drawing.Size(934, 168);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboFloor;
        private System.Windows.Forms.ComboBox comboBuilding;
        private System.Windows.Forms.ComboBox comboBranch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboRoom;
    }
}
