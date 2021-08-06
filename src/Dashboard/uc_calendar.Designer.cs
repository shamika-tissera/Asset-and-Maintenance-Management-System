
namespace Asset_and_Maintenance_Management_System.src.Dashboard
{
    partial class uc_calendar
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
            this.components = new System.ComponentModel.Container();
            this.lbl_uname = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNotif3 = new System.Windows.Forms.Label();
            this.lblNotif2 = new System.Windows.Forms.Label();
            this.lblNotif1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_uname
            // 
            this.lbl_uname.AutoSize = true;
            this.lbl_uname.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbl_uname.Location = new System.Drawing.Point(6, 20);
            this.lbl_uname.Name = "lbl_uname";
            this.lbl_uname.Size = new System.Drawing.Size(155, 30);
            this.lbl_uname.TabIndex = 3;
            this.lbl_uname.Text = "Notifications";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(300, 210);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNotif3);
            this.groupBox1.Controls.Add(this.lblNotif2);
            this.groupBox1.Controls.Add(this.lblNotif1);
            this.groupBox1.Controls.Add(this.lbl_uname);
            this.groupBox1.Location = new System.Drawing.Point(39, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 557);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lblNotif3
            // 
            this.lblNotif3.AutoSize = true;
            this.lblNotif3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNotif3.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotif3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblNotif3.Location = new System.Drawing.Point(11, 377);
            this.lblNotif3.Name = "lblNotif3";
            this.lblNotif3.Size = new System.Drawing.Size(0, 32);
            this.lblNotif3.TabIndex = 6;
            this.lblNotif3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblNotif2
            // 
            this.lblNotif2.AutoSize = true;
            this.lblNotif2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNotif2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotif2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblNotif2.Location = new System.Drawing.Point(11, 211);
            this.lblNotif2.Name = "lblNotif2";
            this.lblNotif2.Size = new System.Drawing.Size(0, 32);
            this.lblNotif2.TabIndex = 6;
            this.lblNotif2.Click += new System.EventHandler(this.lblNotif2_Click);
            // 
            // lblNotif1
            // 
            this.lblNotif1.AutoSize = true;
            this.lblNotif1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNotif1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotif1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblNotif1.Location = new System.Drawing.Point(11, 64);
            this.lblNotif1.Name = "lblNotif1";
            this.lblNotif1.Size = new System.Drawing.Size(0, 32);
            this.lblNotif1.TabIndex = 6;
            this.lblNotif1.Click += new System.EventHandler(this.lblNotif1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1313, 100);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Asset_and_Maintenance_Management_System.Properties.Resources.salute;
            this.pictureBox1.Location = new System.Drawing.Point(384, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(457, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome Back John!";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_date.Location = new System.Drawing.Point(1034, 140);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(262, 32);
            this.lbl_date.TabIndex = 9;
            this.lbl_date.Text = "Displays Today\'s Date";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_time.Location = new System.Drawing.Point(1033, 106);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(165, 32);
            this.lbl_time.TabIndex = 9;
            this.lbl_time.Text = "Current Time";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // uc_calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "uc_calendar";
            this.Size = new System.Drawing.Size(1313, 658);
            this.Load += new System.EventHandler(this.uc_calendar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label lbl_uname;
        protected System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label lbl_date;
        protected System.Windows.Forms.Label lbl_time;
        protected System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblNotif1;
        public System.Windows.Forms.Label lblNotif2;
        public System.Windows.Forms.Label lblNotif3;
    }
}
