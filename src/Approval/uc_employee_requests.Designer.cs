
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployeeRequests
            // 
            this.dataGridViewEmployeeRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeRequests.Location = new System.Drawing.Point(75, 68);
            this.dataGridViewEmployeeRequests.Name = "dataGridViewEmployeeRequests";
            this.dataGridViewEmployeeRequests.RowHeadersWidth = 51;
            this.dataGridViewEmployeeRequests.RowTemplate.Height = 24;
            this.dataGridViewEmployeeRequests.Size = new System.Drawing.Size(1229, 584);
            this.dataGridViewEmployeeRequests.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(1040, 747);
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
            this.btn_print.Location = new System.Drawing.Point(1181, 747);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(123, 33);
            this.btn_print.TabIndex = 5;
            this.btn_print.Text = "&Print";
            this.btn_print.UseVisualStyleBackColor = false;
            // 
            // uc_employee_requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.dataGridViewEmployeeRequests);
            this.Name = "uc_employee_requests";
            this.Size = new System.Drawing.Size(1356, 826);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeRequests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployeeRequests;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_print;
    }
}
