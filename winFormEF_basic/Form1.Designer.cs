﻿namespace winFormEF_basic
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchString = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.garthDeviceInfo2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageAddRecord = new System.Windows.Forms.TabPage();
            this.labelAddHint = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPositionOfDevicee = new System.Windows.Forms.TextBox();
            this.labelExisting = new System.Windows.Forms.Label();
            this.buttonFindCompany = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxDevice = new System.Windows.Forms.TextBox();
            this.textBoxModule = new System.Windows.Forms.TextBox();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.textBoxIpAddress = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.buttonAddRecord = new System.Windows.Forms.Button();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.columnNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garthDeviceInfo2BindingSource)).BeginInit();
            this.tabPageAddRecord.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSearch.Location = new System.Drawing.Point(239, 40);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(111, 30);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearchString
            // 
            this.textBoxSearchString.Location = new System.Drawing.Point(6, 46);
            this.textBoxSearchString.Name = "textBoxSearchString";
            this.textBoxSearchString.Size = new System.Drawing.Size(227, 22);
            this.textBoxSearchString.TabIndex = 1;
            this.textBoxSearchString.Text = "15000";
            this.textBoxSearchString.TextChanged += new System.EventHandler(this.textBoxSearchString_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageSearch);
            this.tabControl1.Controls.Add(this.tabPageAddRecord);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(986, 454);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.AutoScroll = true;
            this.tabPageSearch.Controls.Add(this.dataGridView2);
            this.tabPageSearch.Controls.Add(this.dataGridView1);
            this.tabPageSearch.Controls.Add(this.buttonSearch);
            this.tabPageSearch.Controls.Add(this.textBoxSearchString);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(978, 428);
            this.tabPageSearch.TabIndex = 0;
            this.tabPageSearch.Text = "search";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            this.tabPageSearch.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNameDataGridViewTextBoxColumn,
            this.columnValueDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.gridViewBindingSource3;
            this.dataGridView2.Location = new System.Drawing.Point(6, 76);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(344, 316);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.deviceDataGridViewTextBoxColumn,
            this.moduleDataGridViewTextBoxColumn,
            this.serialNumberDataGridViewTextBoxColumn,
            this.iPAddressDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.garthDeviceInfo2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(893, 377);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(60, 45);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            // 
            // deviceDataGridViewTextBoxColumn
            // 
            this.deviceDataGridViewTextBoxColumn.DataPropertyName = "device";
            this.deviceDataGridViewTextBoxColumn.HeaderText = "device";
            this.deviceDataGridViewTextBoxColumn.Name = "deviceDataGridViewTextBoxColumn";
            // 
            // moduleDataGridViewTextBoxColumn
            // 
            this.moduleDataGridViewTextBoxColumn.DataPropertyName = "module";
            this.moduleDataGridViewTextBoxColumn.HeaderText = "module";
            this.moduleDataGridViewTextBoxColumn.Name = "moduleDataGridViewTextBoxColumn";
            // 
            // serialNumberDataGridViewTextBoxColumn
            // 
            this.serialNumberDataGridViewTextBoxColumn.DataPropertyName = "serialNumber";
            this.serialNumberDataGridViewTextBoxColumn.HeaderText = "serialNumber";
            this.serialNumberDataGridViewTextBoxColumn.Name = "serialNumberDataGridViewTextBoxColumn";
            // 
            // iPAddressDataGridViewTextBoxColumn
            // 
            this.iPAddressDataGridViewTextBoxColumn.DataPropertyName = "IPAddress";
            this.iPAddressDataGridViewTextBoxColumn.HeaderText = "IPAddress";
            this.iPAddressDataGridViewTextBoxColumn.Name = "iPAddressDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // garthDeviceInfo2BindingSource
            // 
            this.garthDeviceInfo2BindingSource.DataSource = typeof(SQLFindInTables2.GarthDeviceInfo2);
            // 
            // tabPageAddRecord
            // 
            this.tabPageAddRecord.Controls.Add(this.labelAddHint);
            this.tabPageAddRecord.Controls.Add(this.label8);
            this.tabPageAddRecord.Controls.Add(this.textBoxPositionOfDevicee);
            this.tabPageAddRecord.Controls.Add(this.labelExisting);
            this.tabPageAddRecord.Controls.Add(this.buttonFindCompany);
            this.tabPageAddRecord.Controls.Add(this.label7);
            this.tabPageAddRecord.Controls.Add(this.label6);
            this.tabPageAddRecord.Controls.Add(this.label5);
            this.tabPageAddRecord.Controls.Add(this.label4);
            this.tabPageAddRecord.Controls.Add(this.label3);
            this.tabPageAddRecord.Controls.Add(this.label2);
            this.tabPageAddRecord.Controls.Add(this.label1);
            this.tabPageAddRecord.Controls.Add(this.textBoxPassword);
            this.tabPageAddRecord.Controls.Add(this.textBoxDevice);
            this.tabPageAddRecord.Controls.Add(this.textBoxModule);
            this.tabPageAddRecord.Controls.Add(this.textBoxSerialNumber);
            this.tabPageAddRecord.Controls.Add(this.textBoxIpAddress);
            this.tabPageAddRecord.Controls.Add(this.textBoxUserName);
            this.tabPageAddRecord.Controls.Add(this.buttonAddRecord);
            this.tabPageAddRecord.Controls.Add(this.textBoxCompanyName);
            this.tabPageAddRecord.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddRecord.Name = "tabPageAddRecord";
            this.tabPageAddRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddRecord.Size = new System.Drawing.Size(978, 428);
            this.tabPageAddRecord.TabIndex = 1;
            this.tabPageAddRecord.Text = "addRecord";
            this.tabPageAddRecord.UseVisualStyleBackColor = true;
            this.tabPageAddRecord.Click += new System.EventHandler(this.tabPageAddRecord_Click);
            // 
            // labelAddHint
            // 
            this.labelAddHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAddHint.AutoSize = true;
            this.labelAddHint.Location = new System.Drawing.Point(865, 334);
            this.labelAddHint.Name = "labelAddHint";
            this.labelAddHint.Size = new System.Drawing.Size(0, 12);
            this.labelAddHint.TabIndex = 19;
            this.labelAddHint.Click += new System.EventHandler(this.labelAddHint_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "position of device";
            // 
            // textBoxPositionOfDevicee
            // 
            this.textBoxPositionOfDevicee.Location = new System.Drawing.Point(200, 364);
            this.textBoxPositionOfDevicee.Name = "textBoxPositionOfDevicee";
            this.textBoxPositionOfDevicee.Size = new System.Drawing.Size(179, 22);
            this.textBoxPositionOfDevicee.TabIndex = 17;
            // 
            // labelExisting
            // 
            this.labelExisting.AutoSize = true;
            this.labelExisting.Location = new System.Drawing.Point(466, 27);
            this.labelExisting.Name = "labelExisting";
            this.labelExisting.Size = new System.Drawing.Size(0, 12);
            this.labelExisting.TabIndex = 16;
            // 
            // buttonFindCompany
            // 
            this.buttonFindCompany.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonFindCompany.Location = new System.Drawing.Point(385, 22);
            this.buttonFindCompany.Name = "buttonFindCompany";
            this.buttonFindCompany.Size = new System.Drawing.Size(75, 22);
            this.buttonFindCompany.TabIndex = 15;
            this.buttonFindCompany.Text = "find";
            this.buttonFindCompany.UseVisualStyleBackColor = true;
            this.buttonFindCompany.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "device";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "module";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "serial number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "IP addrss";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "company name";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(200, 324);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(179, 22);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxDevice
            // 
            this.textBoxDevice.Location = new System.Drawing.Point(200, 72);
            this.textBoxDevice.Name = "textBoxDevice";
            this.textBoxDevice.Size = new System.Drawing.Size(179, 22);
            this.textBoxDevice.TabIndex = 6;
            // 
            // textBoxModule
            // 
            this.textBoxModule.Location = new System.Drawing.Point(200, 124);
            this.textBoxModule.Name = "textBoxModule";
            this.textBoxModule.Size = new System.Drawing.Size(179, 22);
            this.textBoxModule.TabIndex = 5;
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Location = new System.Drawing.Point(200, 178);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(179, 22);
            this.textBoxSerialNumber.TabIndex = 4;
            // 
            // textBoxIpAddress
            // 
            this.textBoxIpAddress.Location = new System.Drawing.Point(200, 225);
            this.textBoxIpAddress.Name = "textBoxIpAddress";
            this.textBoxIpAddress.Size = new System.Drawing.Size(179, 22);
            this.textBoxIpAddress.TabIndex = 3;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(200, 276);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(179, 22);
            this.textBoxUserName.TabIndex = 2;
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddRecord.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAddRecord.Location = new System.Drawing.Point(813, 368);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(136, 42);
            this.buttonAddRecord.TabIndex = 1;
            this.buttonAddRecord.Text = "add or update record";
            this.buttonAddRecord.UseVisualStyleBackColor = true;
            this.buttonAddRecord.Click += new System.EventHandler(this.buttonAddRecord_Click);
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(200, 24);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(179, 22);
            this.textBoxCompanyName.TabIndex = 0;
            this.textBoxCompanyName.TextChanged += new System.EventHandler(this.textBoxCompanyName_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(978, 428);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridView3.DataSource = this.garthDeviceInfo2BindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(6, 76);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(939, 334);
            this.dataGridView3.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "company";
            this.dataGridViewTextBoxColumn2.HeaderText = "company";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "device";
            this.dataGridViewTextBoxColumn3.HeaderText = "device";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "module";
            this.dataGridViewTextBoxColumn4.HeaderText = "module";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "serialNumber";
            this.dataGridViewTextBoxColumn5.HeaderText = "serialNumber";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IPAddress";
            this.dataGridViewTextBoxColumn6.HeaderText = "IPAddress";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn7.HeaderText = "username";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn8.HeaderText = "password";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "position";
            this.dataGridViewTextBoxColumn9.HeaderText = "position";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // gridViewBindingSource1
            // 
            this.gridViewBindingSource1.DataSource = typeof(SQLFindInTables2.IPSearch.GridView);
            // 
            // gridViewBindingSource
            // 
            this.gridViewBindingSource.DataSource = typeof(FindIpInfo.GridView);
            // 
            // gridViewBindingSource2
            // 
            this.gridViewBindingSource2.DataSource = typeof(FindIpInfo.GridView);
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(SQLFindInTables2.City);
            // 
            // gridViewBindingSource3
            // 
            this.gridViewBindingSource3.DataSource = typeof(SQLFindInTables2.IPSearch.GridView);
            // 
            // columnNameDataGridViewTextBoxColumn
            // 
            this.columnNameDataGridViewTextBoxColumn.DataPropertyName = "columnName";
            this.columnNameDataGridViewTextBoxColumn.HeaderText = "columnName";
            this.columnNameDataGridViewTextBoxColumn.Name = "columnNameDataGridViewTextBoxColumn";
            // 
            // columnValueDataGridViewTextBoxColumn
            // 
            this.columnValueDataGridViewTextBoxColumn.DataPropertyName = "columnValue";
            this.columnValueDataGridViewTextBoxColumn.HeaderText = "columnValue";
            this.columnValueDataGridViewTextBoxColumn.Name = "columnValueDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 471);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garthDeviceInfo2BindingSource)).EndInit();
            this.tabPageAddRecord.ResumeLayout(false);
            this.tabPageAddRecord.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchString;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.TabPage tabPageAddRecord;
        private System.Windows.Forms.Button buttonAddRecord;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxDevice;
        private System.Windows.Forms.TextBox textBoxModule;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.TextBox textBoxIpAddress;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelExisting;
        private System.Windows.Forms.Button buttonFindCompany;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPositionOfDevicee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource garthDeviceInfo2BindingSource;
        private System.Windows.Forms.Label labelAddHint;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource gridViewBindingSource;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.BindingSource gridViewBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gridViewBindingSource3;
        private System.Windows.Forms.BindingSource gridViewBindingSource2;
        private System.Windows.Forms.BindingSource cityBindingSource;
    }
}

