
namespace Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets
{
    partial class recordItem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_general_code = new System.Windows.Forms.MaskedTextBox();
            this.combo_general_supplier = new System.Windows.Forms.ComboBox();
            this.combo_general_state = new System.Windows.Forms.ComboBox();
            this.combo_general_manu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_general_name = new System.Windows.Forms.TextBox();
            this.txt_general_serial = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupDepreciationMethod = new System.Windows.Forms.GroupBox();
            this.radBtn_reducingBalance = new System.Windows.Forms.RadioButton();
            this.radBtn_straightLine = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.checkboxFullyDepreciated = new System.Windows.Forms.CheckBox();
            this.dateDepreciationEnd = new System.Windows.Forms.DateTimePicker();
            this.dateDepreciationStart = new System.Windows.Forms.DateTimePicker();
            this.dateDisposal = new System.Windows.Forms.DateTimePicker();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.txtDepreciationRate = new System.Windows.Forms.MaskedTextBox();
            this.txtYearsOfLife = new System.Windows.Forms.MaskedTextBox();
            this.txtCurrentVal = new System.Windows.Forms.MaskedTextBox();
            this.txtPurchasedPrice = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.txtWarrantyCode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboPlant = new System.Windows.Forms.ComboBox();
            this.dateInstallation = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.dateAcceptance = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupDepreciationMethod.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_general_code);
            this.groupBox1.Controls.Add(this.combo_general_supplier);
            this.groupBox1.Controls.Add(this.combo_general_state);
            this.groupBox1.Controls.Add(this.combo_general_manu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_general_name);
            this.groupBox1.Controls.Add(this.txt_general_serial);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 235);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // txt_general_code
            // 
            this.txt_general_code.Location = new System.Drawing.Point(39, 50);
            this.txt_general_code.Name = "txt_general_code";
            this.txt_general_code.Size = new System.Drawing.Size(406, 22);
            this.txt_general_code.TabIndex = 7;
            // 
            // combo_general_supplier
            // 
            this.combo_general_supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_general_supplier.FormattingEnabled = true;
            this.combo_general_supplier.Items.AddRange(new object[] {
            "Blanco"});
            this.combo_general_supplier.Location = new System.Drawing.Point(39, 173);
            this.combo_general_supplier.Name = "combo_general_supplier";
            this.combo_general_supplier.Size = new System.Drawing.Size(406, 24);
            this.combo_general_supplier.TabIndex = 5;
            // 
            // combo_general_state
            // 
            this.combo_general_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_general_state.FormattingEnabled = true;
            this.combo_general_state.Items.AddRange(new object[] {
            "In stock",
            "Under maintenance",
            "Disposed",
            "In use"});
            this.combo_general_state.Location = new System.Drawing.Point(498, 173);
            this.combo_general_state.Name = "combo_general_state";
            this.combo_general_state.Size = new System.Drawing.Size(406, 24);
            this.combo_general_state.TabIndex = 6;
            // 
            // combo_general_manu
            // 
            this.combo_general_manu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_general_manu.FormattingEnabled = true;
            this.combo_general_manu.Items.AddRange(new object[] {
            "Samsung"});
            this.combo_general_manu.Location = new System.Drawing.Point(498, 112);
            this.combo_general_manu.Name = "combo_general_manu";
            this.combo_general_manu.Size = new System.Drawing.Size(406, 24);
            this.combo_general_manu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Supplier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Serial number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Manufacturer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code";
            // 
            // txt_general_name
            // 
            this.txt_general_name.Location = new System.Drawing.Point(498, 52);
            this.txt_general_name.MaxLength = 50;
            this.txt_general_name.Name = "txt_general_name";
            this.txt_general_name.Size = new System.Drawing.Size(406, 22);
            this.txt_general_name.TabIndex = 2;
            // 
            // txt_general_serial
            // 
            this.txt_general_serial.Location = new System.Drawing.Point(39, 112);
            this.txt_general_serial.MaxLength = 100;
            this.txt_general_serial.Name = "txt_general_serial";
            this.txt_general_serial.Size = new System.Drawing.Size(406, 22);
            this.txt_general_serial.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupDepreciationMethod);
            this.groupBox2.Controls.Add(this.checkboxFullyDepreciated);
            this.groupBox2.Controls.Add(this.dateDepreciationEnd);
            this.groupBox2.Controls.Add(this.dateDepreciationStart);
            this.groupBox2.Controls.Add(this.dateDisposal);
            this.groupBox2.Controls.Add(this.txtInvoiceNumber);
            this.groupBox2.Controls.Add(this.txtDepreciationRate);
            this.groupBox2.Controls.Add(this.txtYearsOfLife);
            this.groupBox2.Controls.Add(this.txtCurrentVal);
            this.groupBox2.Controls.Add(this.txtPurchasedPrice);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(12, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(940, 368);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Administrative";
            // 
            // groupDepreciationMethod
            // 
            this.groupDepreciationMethod.Controls.Add(this.radBtn_reducingBalance);
            this.groupDepreciationMethod.Controls.Add(this.radBtn_straightLine);
            this.groupDepreciationMethod.Controls.Add(this.label8);
            this.groupDepreciationMethod.Location = new System.Drawing.Point(491, 243);
            this.groupDepreciationMethod.Name = "groupDepreciationMethod";
            this.groupDepreciationMethod.Size = new System.Drawing.Size(272, 66);
            this.groupDepreciationMethod.TabIndex = 13;
            this.groupDepreciationMethod.TabStop = false;
            this.groupDepreciationMethod.Text = "Depreciation Method";
            // 
            // radBtn_reducingBalance
            // 
            this.radBtn_reducingBalance.AutoSize = true;
            this.radBtn_reducingBalance.Location = new System.Drawing.Point(124, 32);
            this.radBtn_reducingBalance.Name = "radBtn_reducingBalance";
            this.radBtn_reducingBalance.Size = new System.Drawing.Size(144, 21);
            this.radBtn_reducingBalance.TabIndex = 12;
            this.radBtn_reducingBalance.TabStop = true;
            this.radBtn_reducingBalance.Text = "Reducing Balance";
            this.radBtn_reducingBalance.UseVisualStyleBackColor = true;
            // 
            // radBtn_straightLine
            // 
            this.radBtn_straightLine.AutoSize = true;
            this.radBtn_straightLine.Location = new System.Drawing.Point(8, 32);
            this.radBtn_straightLine.Name = "radBtn_straightLine";
            this.radBtn_straightLine.Size = new System.Drawing.Size(110, 21);
            this.radBtn_straightLine.TabIndex = 11;
            this.radBtn_straightLine.TabStop = true;
            this.radBtn_straightLine.Text = "Straight-Line";
            this.radBtn_straightLine.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 1;
            // 
            // checkboxFullyDepreciated
            // 
            this.checkboxFullyDepreciated.AutoSize = true;
            this.checkboxFullyDepreciated.Location = new System.Drawing.Point(498, 337);
            this.checkboxFullyDepreciated.Name = "checkboxFullyDepreciated";
            this.checkboxFullyDepreciated.Size = new System.Drawing.Size(140, 21);
            this.checkboxFullyDepreciated.TabIndex = 10;
            this.checkboxFullyDepreciated.Text = "Fully Depreciated";
            this.checkboxFullyDepreciated.UseVisualStyleBackColor = true;
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
            // dateDepreciationStart
            // 
            this.dateDepreciationStart.Location = new System.Drawing.Point(498, 192);
            this.dateDepreciationStart.MaxDate = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            this.dateDepreciationStart.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dateDepreciationStart.Name = "dateDepreciationStart";
            this.dateDepreciationStart.Size = new System.Drawing.Size(406, 22);
            this.dateDepreciationStart.TabIndex = 6;
            this.dateDepreciationStart.Value = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            // 
            // dateDisposal
            // 
            this.dateDisposal.Location = new System.Drawing.Point(498, 122);
            this.dateDisposal.MaxDate = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            this.dateDisposal.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dateDisposal.Name = "dateDisposal";
            this.dateDisposal.Size = new System.Drawing.Size(406, 22);
            this.dateDisposal.TabIndex = 4;
            this.dateDisposal.Value = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Location = new System.Drawing.Point(498, 54);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(406, 22);
            this.txtInvoiceNumber.TabIndex = 2;
            // 
            // txtDepreciationRate
            // 
            this.txtDepreciationRate.Location = new System.Drawing.Point(39, 335);
            this.txtDepreciationRate.Mask = "99.099";
            this.txtDepreciationRate.Name = "txtDepreciationRate";
            this.txtDepreciationRate.Size = new System.Drawing.Size(406, 22);
            this.txtDepreciationRate.TabIndex = 9;
            // 
            // txtYearsOfLife
            // 
            this.txtYearsOfLife.Location = new System.Drawing.Point(39, 192);
            this.txtYearsOfLife.Mask = "999.099";
            this.txtYearsOfLife.Name = "txtYearsOfLife";
            this.txtYearsOfLife.Size = new System.Drawing.Size(406, 22);
            this.txtYearsOfLife.TabIndex = 5;
            // 
            // txtCurrentVal
            // 
            this.txtCurrentVal.Location = new System.Drawing.Point(39, 122);
            this.txtCurrentVal.Mask = "99999999990.99";
            this.txtCurrentVal.Name = "txtCurrentVal";
            this.txtCurrentVal.Size = new System.Drawing.Size(406, 22);
            this.txtCurrentVal.TabIndex = 3;
            // 
            // txtPurchasedPrice
            // 
            this.txtPurchasedPrice.Location = new System.Drawing.Point(39, 54);
            this.txtPurchasedPrice.Mask = "99999999990.99";
            this.txtPurchasedPrice.Name = "txtPurchasedPrice";
            this.txtPurchasedPrice.Size = new System.Drawing.Size(406, 22);
            this.txtPurchasedPrice.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Invoice number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(495, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Disposal Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(495, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Depreciation Start";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Depreciation Rate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Depreciation End";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Years of life";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "Current value";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(40, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Purchase Price";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboType);
            this.groupBox3.Controls.Add(this.dateStart);
            this.groupBox3.Controls.Add(this.dateEnd);
            this.groupBox3.Controls.Add(this.txtWarrantyCode);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Location = new System.Drawing.Point(11, 627);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(941, 165);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Warranty";
            // 
            // comboType
            // 
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "On-site",
            "Limited",
            "Life-time"});
            this.comboType.Location = new System.Drawing.Point(498, 54);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(406, 24);
            this.comboType.TabIndex = 2;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(39, 122);
            this.dateStart.MaxDate = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            this.dateStart.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(406, 22);
            this.dateStart.TabIndex = 3;
            this.dateStart.Value = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(498, 122);
            this.dateEnd.MaxDate = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            this.dateEnd.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(406, 22);
            this.dateEnd.TabIndex = 4;
            this.dateEnd.Value = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            // 
            // txtWarrantyCode
            // 
            this.txtWarrantyCode.Location = new System.Drawing.Point(39, 54);
            this.txtWarrantyCode.MaxLength = 100;
            this.txtWarrantyCode.Name = "txtWarrantyCode";
            this.txtWarrantyCode.Size = new System.Drawing.Size(406, 22);
            this.txtWarrantyCode.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(495, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Warranty Type";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(495, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "Warranty End";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(40, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 17);
            this.label18.TabIndex = 1;
            this.label18.Text = "Warranty Start";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(40, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 17);
            this.label19.TabIndex = 1;
            this.label19.Text = "Warranty Code";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboPlant);
            this.groupBox4.Controls.Add(this.dateInstallation);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.dateAcceptance);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(11, 798);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(941, 163);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Installation Information";
            // 
            // comboPlant
            // 
            this.comboPlant.FormattingEnabled = true;
            this.comboPlant.Items.AddRange(new object[] {
            "Minuwangoda"});
            this.comboPlant.Location = new System.Drawing.Point(35, 115);
            this.comboPlant.Name = "comboPlant";
            this.comboPlant.Size = new System.Drawing.Size(406, 28);
            this.comboPlant.TabIndex = 3;
            // 
            // dateInstallation
            // 
            this.dateInstallation.Location = new System.Drawing.Point(35, 50);
            this.dateInstallation.MaxDate = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            this.dateInstallation.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dateInstallation.Name = "dateInstallation";
            this.dateInstallation.Size = new System.Drawing.Size(406, 27);
            this.dateInstallation.TabIndex = 1;
            this.dateInstallation.Value = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(30, 93);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 20);
            this.label20.TabIndex = 1;
            this.label20.Text = "Plant";
            // 
            // dateAcceptance
            // 
            this.dateAcceptance.Location = new System.Drawing.Point(494, 50);
            this.dateAcceptance.MaxDate = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            this.dateAcceptance.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dateAcceptance.Name = "dateAcceptance";
            this.dateAcceptance.Size = new System.Drawing.Size(406, 27);
            this.dateAcceptance.TabIndex = 2;
            this.dateAcceptance.Value = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(489, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(122, 20);
            this.label21.TabIndex = 1;
            this.label21.Text = "Acceptance Date";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(34, 29);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(118, 20);
            this.label22.TabIndex = 1;
            this.label22.Text = "Installation Date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 980);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(965, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(18, 1055);
            this.vScrollBar1.TabIndex = 9;
            // 
            // recordItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(983, 1055);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "recordItem";
            this.Text = "recordItem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupDepreciationMethod.ResumeLayout(false);
            this.groupDepreciationMethod.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txt_general_code;
        protected System.Windows.Forms.ComboBox combo_general_supplier;
        protected System.Windows.Forms.ComboBox combo_general_state;
        protected System.Windows.Forms.ComboBox combo_general_manu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox txt_general_name;
        protected System.Windows.Forms.TextBox txt_general_serial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupDepreciationMethod;
        private System.Windows.Forms.RadioButton radBtn_reducingBalance;
        private System.Windows.Forms.RadioButton radBtn_straightLine;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkboxFullyDepreciated;
        private System.Windows.Forms.DateTimePicker dateDepreciationEnd;
        private System.Windows.Forms.DateTimePicker dateDepreciationStart;
        private System.Windows.Forms.DateTimePicker dateDisposal;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.MaskedTextBox txtDepreciationRate;
        private System.Windows.Forms.MaskedTextBox txtYearsOfLife;
        private System.Windows.Forms.MaskedTextBox txtCurrentVal;
        private System.Windows.Forms.MaskedTextBox txtPurchasedPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.TextBox txtWarrantyCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboPlant;
        private System.Windows.Forms.DateTimePicker dateInstallation;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dateAcceptance;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}