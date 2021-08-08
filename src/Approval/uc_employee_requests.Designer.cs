
namespace Asset_and_Maintenance_Management_System.src.Approval
{
    partial class uc_employee_requests
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
            this.dataGridViewEmployeeRequests = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployeeRequests
            // 
            this.dataGridViewEmployeeRequests.AllowUserToAddRows = false;
            this.dataGridViewEmployeeRequests.AllowUserToDeleteRows = false;
            this.dataGridViewEmployeeRequests.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.dataGridViewEmployeeRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeRequests.Location = new System.Drawing.Point(75, 68);
            this.dataGridViewEmployeeRequests.Name = "dataGridViewEmployeeRequests";
            this.dataGridViewEmployeeRequests.RowHeadersWidth = 51;
            this.dataGridViewEmployeeRequests.RowTemplate.Height = 24;
            this.dataGridViewEmployeeRequests.Size = new System.Drawing.Size(1085, 564);
            this.dataGridViewEmployeeRequests.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(875, 660);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Approve";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_print.Location = new System.Drawing.Point(1016, 660);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(123, 33);
            this.btn_print.TabIndex = 5;
            this.btn_print.Text = "&Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(37, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 767);
            this.panel1.TabIndex = 6;
            // 
            // uc_employee_requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.dataGridViewEmployeeRequests);
            this.Controls.Add(this.panel1);
            this.Name = "uc_employee_requests";
            this.Size = new System.Drawing.Size(1356, 826);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeRequests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployeeRequests;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Panel panel1;
    }
}
