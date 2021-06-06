﻿
namespace Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets
{
    partial class uc_administrative_common
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
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPurchasedPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.txtCurrentVal = new System.Windows.Forms.MaskedTextBox();
            this.dateDisposal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYearsOfLife = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateDepreciationStart = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateDepreciationEnd = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.comboDepreciationMethod = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDepreciationRate = new System.Windows.Forms.MaskedTextBox();
            this.checkboxFullyDepreciated = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkboxFullyDepreciated);
            this.groupBox1.Controls.Add(this.comboDepreciationMethod);
            this.groupBox1.Controls.Add(this.dateDepreciationEnd);
            this.groupBox1.Controls.Add(this.dateDepreciationStart);
            this.groupBox1.Controls.Add(this.dateDisposal);
            this.groupBox1.Controls.Add(this.txtInvoiceNumber);
            this.groupBox1.Controls.Add(this.txtDepreciationRate);
            this.groupBox1.Controls.Add(this.txtYearsOfLife);
            this.groupBox1.Controls.Add(this.txtCurrentVal);
            this.groupBox1.Controls.Add(this.txtPurchasedPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 368);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrative";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Invoice number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Disposal Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Current value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Purchase Price";
            // 
            // txtPurchasedPrice
            // 
            this.txtPurchasedPrice.Location = new System.Drawing.Point(39, 54);
            this.txtPurchasedPrice.Mask = "99999999990.99";
            this.txtPurchasedPrice.Name = "txtPurchasedPrice";
            this.txtPurchasedPrice.Size = new System.Drawing.Size(406, 22);
            this.txtPurchasedPrice.TabIndex = 5;
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Location = new System.Drawing.Point(498, 54);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(406, 22);
            this.txtInvoiceNumber.TabIndex = 6;
            // 
            // txtCurrentVal
            // 
            this.txtCurrentVal.Location = new System.Drawing.Point(39, 122);
            this.txtCurrentVal.Mask = "99999999990.99";
            this.txtCurrentVal.Name = "txtCurrentVal";
            this.txtCurrentVal.Size = new System.Drawing.Size(406, 22);
            this.txtCurrentVal.TabIndex = 5;
            // 
            // dateDisposal
            // 
            this.dateDisposal.Location = new System.Drawing.Point(498, 122);
            this.dateDisposal.MaxDate = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            this.dateDisposal.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dateDisposal.Name = "dateDisposal";
            this.dateDisposal.Size = new System.Drawing.Size(406, 22);
            this.dateDisposal.TabIndex = 7;
            this.dateDisposal.Value = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Years of life";
            // 
            // txtYearsOfLife
            // 
            this.txtYearsOfLife.Location = new System.Drawing.Point(39, 192);
            this.txtYearsOfLife.Mask = "999.099";
            this.txtYearsOfLife.Name = "txtYearsOfLife";
            this.txtYearsOfLife.Size = new System.Drawing.Size(406, 22);
            this.txtYearsOfLife.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Depreciation Start";
            // 
            // dateDepreciationStart
            // 
            this.dateDepreciationStart.Location = new System.Drawing.Point(498, 192);
            this.dateDepreciationStart.MaxDate = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            this.dateDepreciationStart.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dateDepreciationStart.Name = "dateDepreciationStart";
            this.dateDepreciationStart.Size = new System.Drawing.Size(406, 22);
            this.dateDepreciationStart.TabIndex = 7;
            this.dateDepreciationStart.Value = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Depreciation End";
            // 
            // dateDepreciationEnd
            // 
            this.dateDepreciationEnd.Location = new System.Drawing.Point(39, 266);
            this.dateDepreciationEnd.MaxDate = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            this.dateDepreciationEnd.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dateDepreciationEnd.Name = "dateDepreciationEnd";
            this.dateDepreciationEnd.Size = new System.Drawing.Size(406, 22);
            this.dateDepreciationEnd.TabIndex = 7;
            this.dateDepreciationEnd.Value = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(495, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Depreciation Method";
            // 
            // comboDepreciationMethod
            // 
            this.comboDepreciationMethod.FormattingEnabled = true;
            this.comboDepreciationMethod.Items.AddRange(new object[] {
            "Reducing Balance",
            "Straight Line"});
            this.comboDepreciationMethod.Location = new System.Drawing.Point(498, 268);
            this.comboDepreciationMethod.Name = "comboDepreciationMethod";
            this.comboDepreciationMethod.Size = new System.Drawing.Size(406, 24);
            this.comboDepreciationMethod.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Depreciation Rate";
            // 
            // txtDepreciationRate
            // 
            this.txtDepreciationRate.Location = new System.Drawing.Point(39, 335);
            this.txtDepreciationRate.Mask = "99.099";
            this.txtDepreciationRate.Name = "txtDepreciationRate";
            this.txtDepreciationRate.Size = new System.Drawing.Size(406, 22);
            this.txtDepreciationRate.TabIndex = 5;
            // 
            // checkboxFullyDepreciated
            // 
            this.checkboxFullyDepreciated.AutoSize = true;
            this.checkboxFullyDepreciated.Location = new System.Drawing.Point(498, 337);
            this.checkboxFullyDepreciated.Name = "checkboxFullyDepreciated";
            this.checkboxFullyDepreciated.Size = new System.Drawing.Size(140, 21);
            this.checkboxFullyDepreciated.TabIndex = 9;
            this.checkboxFullyDepreciated.Text = "Fully Depreciated";
            this.checkboxFullyDepreciated.UseVisualStyleBackColor = true;
            this.checkboxFullyDepreciated.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // uc_administrative_common
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "uc_administrative_common";
            this.Size = new System.Drawing.Size(951, 375);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.MaskedTextBox txtCurrentVal;
        private System.Windows.Forms.MaskedTextBox txtPurchasedPrice;
        private System.Windows.Forms.CheckBox checkboxFullyDepreciated;
        private System.Windows.Forms.ComboBox comboDepreciationMethod;
        private System.Windows.Forms.DateTimePicker dateDepreciationEnd;
        private System.Windows.Forms.DateTimePicker dateDepreciationStart;
        private System.Windows.Forms.DateTimePicker dateDisposal;
        private System.Windows.Forms.MaskedTextBox txtDepreciationRate;
        private System.Windows.Forms.MaskedTextBox txtYearsOfLife;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
    }
}