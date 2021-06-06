
using System;
using static Final.PhysicalPerson;

namespace Final
{
    partial class bankForm
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
            this.depositGroup = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.roleBox = new System.Windows.Forms.ComboBox();
            this.officeBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.passbox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.resBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.countryBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.birthBox = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.pnBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.userGrid = new System.Windows.Forms.DataGridView();
            this.loanGroup = new System.Windows.Forms.GroupBox();
            this.loanGrid = new System.Windows.Forms.DataGridView();
            this.resTypeBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.userListBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.depositAmount = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.percentBox = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.currencyBox = new System.Windows.Forms.ComboBox();
            this.openDepositButton = new System.Windows.Forms.Button();
            this.getLoanButton = new System.Windows.Forms.Button();
            this.loanCurrencyBox = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.loanPercentBox = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.loanAmountBox = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.loanGuid = new System.Windows.Forms.ComboBox();
            this.loanDueDateBox = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.loanRootBox = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.filterStart = new System.Windows.Forms.DateTimePicker();
            this.filterEnd = new System.Windows.Forms.DateTimePicker();
            this.dateFilterButton = new System.Windows.Forms.Button();
            this.topFilter = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.topFilterVal = new System.Windows.Forms.NumericUpDown();
            this.depositGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).BeginInit();
            this.loanGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depositAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanPercentBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanAmountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanRootBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topFilterVal)).BeginInit();
            this.SuspendLayout();
            // 
            // depositGroup
            // 
            this.depositGroup.Controls.Add(this.label15);
            this.depositGroup.Controls.Add(this.resTypeBox);
            this.depositGroup.Controls.Add(this.button1);
            this.depositGroup.Controls.Add(this.label14);
            this.depositGroup.Controls.Add(this.label13);
            this.depositGroup.Controls.Add(this.roleBox);
            this.depositGroup.Controls.Add(this.officeBox);
            this.depositGroup.Controls.Add(this.label12);
            this.depositGroup.Controls.Add(this.label11);
            this.depositGroup.Controls.Add(this.passbox);
            this.depositGroup.Controls.Add(this.usernameBox);
            this.depositGroup.Controls.Add(this.label10);
            this.depositGroup.Controls.Add(this.resBox);
            this.depositGroup.Controls.Add(this.label9);
            this.depositGroup.Controls.Add(this.label8);
            this.depositGroup.Controls.Add(this.phoneBox);
            this.depositGroup.Controls.Add(this.emailbox);
            this.depositGroup.Controls.Add(this.label7);
            this.depositGroup.Controls.Add(this.cityBox);
            this.depositGroup.Controls.Add(this.label6);
            this.depositGroup.Controls.Add(this.countryBox);
            this.depositGroup.Controls.Add(this.label5);
            this.depositGroup.Controls.Add(this.birthBox);
            this.depositGroup.Controls.Add(this.label4);
            this.depositGroup.Controls.Add(this.pnBox);
            this.depositGroup.Controls.Add(this.label3);
            this.depositGroup.Controls.Add(this.label2);
            this.depositGroup.Controls.Add(this.label1);
            this.depositGroup.Controls.Add(this.lnameBox);
            this.depositGroup.Controls.Add(this.fnameBox);
            this.depositGroup.Controls.Add(this.genderBox);
            this.depositGroup.Controls.Add(this.userGrid);
            this.depositGroup.Location = new System.Drawing.Point(12, 12);
            this.depositGroup.Name = "depositGroup";
            this.depositGroup.Size = new System.Drawing.Size(475, 490);
            this.depositGroup.TabIndex = 0;
            this.depositGroup.TabStop = false;
            this.depositGroup.Text = "User Control";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(460, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Make User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.openDepositButton);
            this.groupBox1.Controls.Add(this.currencyBox);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.percentBox);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.depositAmount);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.userListBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 100);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deposit Control";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(335, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Role";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(99, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Office";
            // 
            // roleBox
            // 
            this.roleBox.FormattingEnabled = true;
            this.roleBox.Location = new System.Drawing.Point(218, 213);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(248, 21);
            this.roleBox.TabIndex = 26;
            // 
            // officeBox
            // 
            this.officeBox.FormattingEnabled = true;
            this.officeBox.Location = new System.Drawing.Point(6, 213);
            this.officeBox.Name = "officeBox";
            this.officeBox.Size = new System.Drawing.Size(206, 21);
            this.officeBox.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(256, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "User name";
            // 
            // passbox
            // 
            this.passbox.Location = new System.Drawing.Point(218, 174);
            this.passbox.Name = "passbox";
            this.passbox.PasswordChar = '*';
            this.passbox.Size = new System.Drawing.Size(121, 20);
            this.passbox.TabIndex = 22;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(6, 174);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(206, 20);
            this.usernameBox.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(375, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Res GUID";
            // 
            // resBox
            // 
            this.resBox.Location = new System.Drawing.Point(345, 133);
            this.resBox.Name = "resBox";
            this.resBox.Size = new System.Drawing.Size(121, 20);
            this.resBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Phone Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Email";
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(218, 133);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(121, 20);
            this.phoneBox.TabIndex = 16;
            // 
            // emailbox
            // 
            this.emailbox.Location = new System.Drawing.Point(6, 133);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(206, 20);
            this.emailbox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "City";
            // 
            // cityBox
            // 
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Location = new System.Drawing.Point(345, 86);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(121, 21);
            this.cityBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Country";
            // 
            // countryBox
            // 
            this.countryBox.FormattingEnabled = true;
            this.countryBox.Location = new System.Drawing.Point(218, 86);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(121, 21);
            this.countryBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Birth Date";
            // 
            // birthBox
            // 
            this.birthBox.Location = new System.Drawing.Point(6, 87);
            this.birthBox.Name = "birthBox";
            this.birthBox.Size = new System.Drawing.Size(206, 20);
            this.birthBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Private Number";
            // 
            // pnBox
            // 
            this.pnBox.Location = new System.Drawing.Point(285, 44);
            this.pnBox.Name = "pnBox";
            this.pnBox.Size = new System.Drawing.Size(184, 20);
            this.pnBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            // 
            // lnameBox
            // 
            this.lnameBox.Location = new System.Drawing.Point(112, 43);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(100, 20);
            this.lnameBox.TabIndex = 3;
            // 
            // fnameBox
            // 
            this.fnameBox.Location = new System.Drawing.Point(6, 43);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(100, 20);
            this.fnameBox.TabIndex = 2;
            // 
            // genderBox
            // 
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Location = new System.Drawing.Point(218, 43);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(61, 21);
            this.genderBox.TabIndex = 1;
            // 
            // userGrid
            // 
            this.userGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userGrid.Location = new System.Drawing.Point(3, 293);
            this.userGrid.Name = "userGrid";
            this.userGrid.Size = new System.Drawing.Size(469, 194);
            this.userGrid.TabIndex = 0;
            // 
            // loanGroup
            // 
            this.loanGroup.Controls.Add(this.topFilterVal);
            this.loanGroup.Controls.Add(this.reportButton);
            this.loanGroup.Controls.Add(this.topFilter);
            this.loanGroup.Controls.Add(this.dateFilterButton);
            this.loanGroup.Controls.Add(this.filterEnd);
            this.loanGroup.Controls.Add(this.filterStart);
            this.loanGroup.Controls.Add(this.groupBox2);
            this.loanGroup.Controls.Add(this.loanGrid);
            this.loanGroup.Controls.Add(this.groupBox1);
            this.loanGroup.Location = new System.Drawing.Point(514, 12);
            this.loanGroup.Name = "loanGroup";
            this.loanGroup.Size = new System.Drawing.Size(479, 490);
            this.loanGroup.TabIndex = 1;
            this.loanGroup.TabStop = false;
            this.loanGroup.Text = "Bank Control";
            // 
            // loanGrid
            // 
            this.loanGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loanGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loanGrid.Location = new System.Drawing.Point(3, 338);
            this.loanGrid.Name = "loanGrid";
            this.loanGrid.Size = new System.Drawing.Size(473, 149);
            this.loanGrid.TabIndex = 0;
            // 
            // resTypeBox
            // 
            this.resTypeBox.FormattingEnabled = true;
            this.resTypeBox.Location = new System.Drawing.Point(345, 174);
            this.resTypeBox.Name = "resTypeBox";
            this.resTypeBox.Size = new System.Drawing.Size(121, 21);
            this.resTypeBox.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(375, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Responsible";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.loanRootBox);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.loanDueDateBox);
            this.groupBox2.Controls.Add(this.getLoanButton);
            this.groupBox2.Controls.Add(this.loanCurrencyBox);
            this.groupBox2.Controls.Add(this.loanGuid);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.loanPercentBox);
            this.groupBox2.Controls.Add(this.loanAmountBox);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Location = new System.Drawing.Point(6, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 152);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loan Control";
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.Location = new System.Drawing.Point(6, 35);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(237, 21);
            this.userListBox.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(52, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "User";
            // 
            // depositAmount
            // 
            this.depositAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.depositAmount.Location = new System.Drawing.Point(250, 35);
            this.depositAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.depositAmount.Name = "depositAmount";
            this.depositAmount.Size = new System.Drawing.Size(120, 20);
            this.depositAmount.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(284, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Amount";
            // 
            // percentBox
            // 
            this.percentBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.percentBox.Location = new System.Drawing.Point(376, 35);
            this.percentBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.percentBox.Name = "percentBox";
            this.percentBox.Size = new System.Drawing.Size(85, 20);
            this.percentBox.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(395, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Percent";
            // 
            // currencyBox
            // 
            this.currencyBox.FormattingEnabled = true;
            this.currencyBox.Location = new System.Drawing.Point(376, 67);
            this.currencyBox.Name = "currencyBox";
            this.currencyBox.Size = new System.Drawing.Size(85, 21);
            this.currencyBox.TabIndex = 6;
            // 
            // openDepositButton
            // 
            this.openDepositButton.Location = new System.Drawing.Point(6, 65);
            this.openDepositButton.Name = "openDepositButton";
            this.openDepositButton.Size = new System.Drawing.Size(364, 23);
            this.openDepositButton.TabIndex = 7;
            this.openDepositButton.Text = "Open Deposit";
            this.openDepositButton.UseVisualStyleBackColor = true;
            this.openDepositButton.Click += new System.EventHandler(this.openDepositButton_Click);
            // 
            // getLoanButton
            // 
            this.getLoanButton.Location = new System.Drawing.Point(6, 115);
            this.getLoanButton.Name = "getLoanButton";
            this.getLoanButton.Size = new System.Drawing.Size(455, 22);
            this.getLoanButton.TabIndex = 15;
            this.getLoanButton.Text = "Get Loan";
            this.getLoanButton.UseVisualStyleBackColor = true;
            this.getLoanButton.Click += new System.EventHandler(this.getLoanButton_Click);
            // 
            // loanCurrencyBox
            // 
            this.loanCurrencyBox.FormattingEnabled = true;
            this.loanCurrencyBox.Location = new System.Drawing.Point(376, 84);
            this.loanCurrencyBox.Name = "loanCurrencyBox";
            this.loanCurrencyBox.Size = new System.Drawing.Size(85, 21);
            this.loanCurrencyBox.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(395, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Percent";
            // 
            // loanPercentBox
            // 
            this.loanPercentBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.loanPercentBox.Location = new System.Drawing.Point(376, 37);
            this.loanPercentBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.loanPercentBox.Name = "loanPercentBox";
            this.loanPercentBox.Size = new System.Drawing.Size(85, 20);
            this.loanPercentBox.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(284, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 13);
            this.label20.TabIndex = 11;
            this.label20.Text = "Amount";
            // 
            // loanAmountBox
            // 
            this.loanAmountBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.loanAmountBox.Location = new System.Drawing.Point(250, 37);
            this.loanAmountBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.loanAmountBox.Name = "loanAmountBox";
            this.loanAmountBox.Size = new System.Drawing.Size(120, 20);
            this.loanAmountBox.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(52, 21);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 13);
            this.label21.TabIndex = 9;
            this.label21.Text = "User";
            // 
            // loanGuid
            // 
            this.loanGuid.FormattingEnabled = true;
            this.loanGuid.Location = new System.Drawing.Point(6, 37);
            this.loanGuid.Name = "loanGuid";
            this.loanGuid.Size = new System.Drawing.Size(237, 21);
            this.loanGuid.TabIndex = 8;
            // 
            // loanDueDateBox
            // 
            this.loanDueDateBox.Location = new System.Drawing.Point(6, 85);
            this.loanDueDateBox.Name = "loanDueDateBox";
            this.loanDueDateBox.Size = new System.Drawing.Size(237, 20);
            this.loanDueDateBox.TabIndex = 32;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(89, 69);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 13);
            this.label22.TabIndex = 33;
            this.label22.Text = "Due Date";
            // 
            // loanRootBox
            // 
            this.loanRootBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.loanRootBox.Location = new System.Drawing.Point(249, 85);
            this.loanRootBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.loanRootBox.Name = "loanRootBox";
            this.loanRootBox.Size = new System.Drawing.Size(120, 20);
            this.loanRootBox.TabIndex = 34;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(274, 68);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 13);
            this.label23.TabIndex = 35;
            this.label23.Text = "Loan Root";
            // 
            // filterStart
            // 
            this.filterStart.Location = new System.Drawing.Point(6, 283);
            this.filterStart.Name = "filterStart";
            this.filterStart.Size = new System.Drawing.Size(201, 20);
            this.filterStart.TabIndex = 31;
            // 
            // filterEnd
            // 
            this.filterEnd.Location = new System.Drawing.Point(213, 283);
            this.filterEnd.Name = "filterEnd";
            this.filterEnd.Size = new System.Drawing.Size(201, 20);
            this.filterEnd.TabIndex = 32;
            // 
            // dateFilterButton
            // 
            this.dateFilterButton.Location = new System.Drawing.Point(420, 283);
            this.dateFilterButton.Name = "dateFilterButton";
            this.dateFilterButton.Size = new System.Drawing.Size(55, 20);
            this.dateFilterButton.TabIndex = 33;
            this.dateFilterButton.Text = "Get";
            this.dateFilterButton.UseVisualStyleBackColor = true;
            this.dateFilterButton.Click += new System.EventHandler(this.dateFilterButton_Click);
            // 
            // topFilter
            // 
            this.topFilter.Location = new System.Drawing.Point(159, 308);
            this.topFilter.Name = "topFilter";
            this.topFilter.Size = new System.Drawing.Size(109, 23);
            this.topFilter.TabIndex = 34;
            this.topFilter.Text = "Top";
            this.topFilter.UseVisualStyleBackColor = true;
            this.topFilter.Click += new System.EventHandler(this.topFilter_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(274, 309);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(201, 23);
            this.reportButton.TabIndex = 35;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // topFilterVal
            // 
            this.topFilterVal.Location = new System.Drawing.Point(6, 309);
            this.topFilterVal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.topFilterVal.Name = "topFilterVal";
            this.topFilterVal.Size = new System.Drawing.Size(147, 20);
            this.topFilterVal.TabIndex = 36;
            // 
            // bankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 514);
            this.Controls.Add(this.loanGroup);
            this.Controls.Add(this.depositGroup);
            this.MaximumSize = new System.Drawing.Size(1021, 553);
            this.MinimumSize = new System.Drawing.Size(1021, 553);
            this.Name = "bankForm";
            this.Text = "My Little Bank";
            this.depositGroup.ResumeLayout(false);
            this.depositGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).EndInit();
            this.loanGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loanGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depositAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanPercentBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanAmountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanRootBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topFilterVal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox depositGroup;
        private System.Windows.Forms.GroupBox loanGroup;
        private System.Windows.Forms.DataGridView userGrid;
        private System.Windows.Forms.DataGridView loanGrid;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pnBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker birthBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox countryBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cityBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox resBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox roleBox;
        private System.Windows.Forms.ComboBox officeBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox resTypeBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox userListBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown depositAmount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown percentBox;
        private System.Windows.Forms.ComboBox currencyBox;
        private System.Windows.Forms.Button openDepositButton;
        private System.Windows.Forms.Button getLoanButton;
        private System.Windows.Forms.ComboBox loanCurrencyBox;
        private System.Windows.Forms.ComboBox loanGuid;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown loanPercentBox;
        private System.Windows.Forms.NumericUpDown loanAmountBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown loanRootBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker loanDueDateBox;
        private System.Windows.Forms.NumericUpDown topFilterVal;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button topFilter;
        private System.Windows.Forms.Button dateFilterButton;
        private System.Windows.Forms.DateTimePicker filterEnd;
        private System.Windows.Forms.DateTimePicker filterStart;
    }
}

