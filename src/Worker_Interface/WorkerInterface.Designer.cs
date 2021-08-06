
namespace Asset_and_Maintenance_Management_System.src.Worker_Interface
{
    partial class WorkerInterface
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboCriticalActivity = new System.Windows.Forms.ComboBox();
            this.comboCriticalOperational = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboPlant = new System.Windows.Forms.ComboBox();
            this.comboAssetID = new System.Windows.Forms.ComboBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPreviouslyReported = new System.Windows.Forms.Button();
            this.btn_previouslyReported = new System.Windows.Forms.Button();
            this.btn_reporting = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_uname = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uc_item_usage1 = new Asset_and_Maintenance_Management_System.src.Worker_Interface.uc_item_usage();
            this.uc_previously_reported1 = new Asset_and_Maintenance_Management_System.src.Worker_Interface.uc_previously_reported();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.comboCriticalActivity);
            this.panel1.Controls.Add(this.comboCriticalOperational);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboPlant);
            this.panel1.Controls.Add(this.comboAssetID);
            this.panel1.Controls.Add(this.comboType);
            this.panel1.Controls.Add(this.txtMessage);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.uc_item_usage1);
            this.panel1.Controls.Add(this.uc_previously_reported1);
            this.panel1.Location = new System.Drawing.Point(43, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1419, 700);
            this.panel1.TabIndex = 0;
            // 
            // comboCriticalActivity
            // 
            this.comboCriticalActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCriticalActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCriticalActivity.FormattingEnabled = true;
            this.comboCriticalActivity.Items.AddRange(new object[] {
            "Low",
            "Moderate ",
            "High",
            "Extreme"});
            this.comboCriticalActivity.Location = new System.Drawing.Point(702, 384);
            this.comboCriticalActivity.Name = "comboCriticalActivity";
            this.comboCriticalActivity.Size = new System.Drawing.Size(406, 37);
            this.comboCriticalActivity.TabIndex = 7;
            // 
            // comboCriticalOperational
            // 
            this.comboCriticalOperational.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCriticalOperational.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCriticalOperational.FormattingEnabled = true;
            this.comboCriticalOperational.Items.AddRange(new object[] {
            "Low",
            "Moderate ",
            "High",
            "Extreme"});
            this.comboCriticalOperational.Location = new System.Drawing.Point(702, 306);
            this.comboCriticalOperational.Name = "comboCriticalOperational";
            this.comboCriticalOperational.Size = new System.Drawing.Size(406, 37);
            this.comboCriticalOperational.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1126, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboPlant
            // 
            this.comboPlant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPlant.Enabled = false;
            this.comboPlant.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPlant.FormattingEnabled = true;
            this.comboPlant.Items.AddRange(new object[] {
            "Minuwangoda"});
            this.comboPlant.Location = new System.Drawing.Point(702, 233);
            this.comboPlant.Name = "comboPlant";
            this.comboPlant.Size = new System.Drawing.Size(406, 37);
            this.comboPlant.TabIndex = 7;
            // 
            // comboAssetID
            // 
            this.comboAssetID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAssetID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAssetID.FormattingEnabled = true;
            this.comboAssetID.Items.AddRange(new object[] {
            "Production Machinery",
            "Heater",
            "Network Device",
            "Sanitation Device",
            "Printer/Scanner",
            "Lift",
            "Fire Extinguisher",
            "Computer",
            "Plumbing Device",
            "Phone",
            "Sink",
            "Lighting"});
            this.comboAssetID.Location = new System.Drawing.Point(702, 93);
            this.comboAssetID.Name = "comboAssetID";
            this.comboAssetID.Size = new System.Drawing.Size(406, 37);
            this.comboAssetID.TabIndex = 7;
            this.comboAssetID.SelectedIndexChanged += new System.EventHandler(this.assetCode_SelectionChanged);
            // 
            // comboType
            // 
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.Enabled = false;
            this.comboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "Production Machinery",
            "Heater",
            "Network Device",
            "Sanitation Device",
            "Printer/Scanner",
            "Lift",
            "Fire Extinguisher",
            "Computer",
            "Plumbing Device",
            "Phone",
            "Sink",
            "Lighting"});
            this.comboType.Location = new System.Drawing.Point(702, 160);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(406, 37);
            this.comboType.TabIndex = 7;
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(702, 451);
            this.txtMessage.MaxLength = 100;
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(406, 148);
            this.txtMessage.TabIndex = 6;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtWarrantyCode_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.panel2.Controls.Add(this.btnPreviouslyReported);
            this.panel2.Controls.Add(this.btn_previouslyReported);
            this.panel2.Controls.Add(this.btn_reporting);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lbl_uname);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 724);
            this.panel2.TabIndex = 5;
            // 
            // btnPreviouslyReported
            // 
            this.btnPreviouslyReported.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.btnPreviouslyReported.FlatAppearance.BorderSize = 0;
            this.btnPreviouslyReported.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviouslyReported.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviouslyReported.ForeColor = System.Drawing.Color.Black;
            this.btnPreviouslyReported.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreviouslyReported.Location = new System.Drawing.Point(6, 379);
            this.btnPreviouslyReported.Name = "btnPreviouslyReported";
            this.btnPreviouslyReported.Size = new System.Drawing.Size(264, 50);
            this.btnPreviouslyReported.TabIndex = 6;
            this.btnPreviouslyReported.Text = "&Previously Reported";
            this.btnPreviouslyReported.UseVisualStyleBackColor = false;
            this.btnPreviouslyReported.Click += new System.EventHandler(this.click_previouslyReported);
            // 
            // btn_previouslyReported
            // 
            this.btn_previouslyReported.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.btn_previouslyReported.FlatAppearance.BorderSize = 0;
            this.btn_previouslyReported.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_previouslyReported.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previouslyReported.ForeColor = System.Drawing.Color.Black;
            this.btn_previouslyReported.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_previouslyReported.Location = new System.Drawing.Point(4, 323);
            this.btn_previouslyReported.Name = "btn_previouslyReported";
            this.btn_previouslyReported.Size = new System.Drawing.Size(264, 50);
            this.btn_previouslyReported.TabIndex = 6;
            this.btn_previouslyReported.Text = "&Item Usage";
            this.btn_previouslyReported.UseVisualStyleBackColor = false;
            this.btn_previouslyReported.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_reporting
            // 
            this.btn_reporting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.btn_reporting.FlatAppearance.BorderSize = 0;
            this.btn_reporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporting.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporting.ForeColor = System.Drawing.Color.Black;
            this.btn_reporting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reporting.Location = new System.Drawing.Point(4, 261);
            this.btn_reporting.Name = "btn_reporting";
            this.btn_reporting.Size = new System.Drawing.Size(264, 56);
            this.btn_reporting.TabIndex = 6;
            this.btn_reporting.Text = "&Reporting";
            this.btn_reporting.UseVisualStyleBackColor = false;
            this.btn_reporting.Click += new System.EventHandler(this.btn_reporting_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(4, 641);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(264, 54);
            this.button4.TabIndex = 6;
            this.button4.Text = "&Logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Asset_and_Maintenance_Management_System.Properties.Resources.User_with_smile_svg;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_uname
            // 
            this.lbl_uname.AutoSize = true;
            this.lbl_uname.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_uname.Location = new System.Drawing.Point(88, 154);
            this.lbl_uname.Name = "lbl_uname";
            this.lbl_uname.Size = new System.Drawing.Size(88, 20);
            this.lbl_uname.TabIndex = 4;
            this.lbl_uname.Text = "John Smith";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(320, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "Message:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(320, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(333, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Criticality (Activity Constraint):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(320, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Criticality (Operational):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(320, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Plant:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(317, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Asset Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(317, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Asset Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(301, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Equipment Error Reporting";
            // 
            // uc_item_usage1
            // 
            this.uc_item_usage1.Location = new System.Drawing.Point(272, 0);
            this.uc_item_usage1.Name = "uc_item_usage1";
            this.uc_item_usage1.Size = new System.Drawing.Size(1144, 700);
            this.uc_item_usage1.TabIndex = 8;
            // 
            // uc_previously_reported1
            // 
            this.uc_previously_reported1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.uc_previously_reported1.Location = new System.Drawing.Point(272, 0);
            this.uc_previously_reported1.Name = "uc_previously_reported1";
            this.uc_previously_reported1.Size = new System.Drawing.Size(1144, 700);
            this.uc_previously_reported1.TabIndex = 9;
            // 
            // WorkerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1502, 779);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkerInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkerInterface";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_uname;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboCriticalActivity;
        private System.Windows.Forms.ComboBox comboCriticalOperational;
        private System.Windows.Forms.ComboBox comboPlant;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Button btn_previouslyReported;
        private System.Windows.Forms.Button btn_reporting;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboAssetID;
        private System.Windows.Forms.Button btnPreviouslyReported;
        private uc_item_usage uc_item_usage1;
        private uc_previously_reported uc_previously_reported1;
    }
}