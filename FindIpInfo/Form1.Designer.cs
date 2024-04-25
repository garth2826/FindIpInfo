namespace FindIpInfo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchString = new System.Windows.Forms.TextBox();
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
            this.tabPageFindDevice = new System.Windows.Forms.TabPage();
            this.labelSearchState = new System.Windows.Forms.Label();
            this.textBoxFindCompany = new System.Windows.Forms.TextBox();
            this.buttonFindDevice = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.columnNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchAllTablesResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moudleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionOfDeviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findMyDeviceResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageAddDeviceInfo = new System.Windows.Forms.TabPage();
            this.tabPageReadSearchFile = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageAddRecord.SuspendLayout();
            this.tabPageFindDevice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchAllTablesResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findMyDeviceResultBindingSource)).BeginInit();
            this.tabPageReadSearchFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageSearch);
            this.tabControl1.Controls.Add(this.tabPageAddRecord);
            this.tabControl1.Controls.Add(this.tabPageFindDevice);
            this.tabControl1.Controls.Add(this.tabPageAddDeviceInfo);
            this.tabControl1.Controls.Add(this.tabPageReadSearchFile);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(861, 441);
            this.tabControl1.TabIndex = 3;
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
            this.tabPageSearch.Size = new System.Drawing.Size(853, 415);
            this.tabPageSearch.TabIndex = 0;
            this.tabPageSearch.Text = "search";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNameDataGridViewTextBoxColumn,
            this.columnValueDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.searchAllTablesResultBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 76);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(397, 316);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(893, 377);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(448, 200);
            this.dataGridView1.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSearch.Location = new System.Drawing.Point(265, 25);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(111, 30);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearchString
            // 
            this.textBoxSearchString.Location = new System.Drawing.Point(6, 31);
            this.textBoxSearchString.Name = "textBoxSearchString";
            this.textBoxSearchString.Size = new System.Drawing.Size(227, 22);
            this.textBoxSearchString.TabIndex = 1;
            this.textBoxSearchString.Text = "15000";
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
            this.tabPageAddRecord.Size = new System.Drawing.Size(853, 415);
            this.tabPageAddRecord.TabIndex = 1;
            this.tabPageAddRecord.Text = "addRecord";
            this.tabPageAddRecord.UseVisualStyleBackColor = true;
            this.tabPageAddRecord.Click += new System.EventHandler(this.tabPageAddRecord_Click);
            // 
            // labelAddHint
            // 
            this.labelAddHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAddHint.AutoSize = true;
            this.labelAddHint.Location = new System.Drawing.Point(740, 321);
            this.labelAddHint.Name = "labelAddHint";
            this.labelAddHint.Size = new System.Drawing.Size(0, 12);
            this.labelAddHint.TabIndex = 19;
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
            this.buttonFindCompany.Click += new System.EventHandler(this.buttonFindCompany_Click);
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
            this.buttonAddRecord.Location = new System.Drawing.Point(688, 355);
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
            // 
            // tabPageFindDevice
            // 
            this.tabPageFindDevice.Controls.Add(this.buttonSaveToFile);
            this.tabPageFindDevice.Controls.Add(this.labelSearchState);
            this.tabPageFindDevice.Controls.Add(this.textBoxFindCompany);
            this.tabPageFindDevice.Controls.Add(this.buttonFindDevice);
            this.tabPageFindDevice.Controls.Add(this.dataGridView3);
            this.tabPageFindDevice.Location = new System.Drawing.Point(4, 22);
            this.tabPageFindDevice.Name = "tabPageFindDevice";
            this.tabPageFindDevice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFindDevice.Size = new System.Drawing.Size(853, 415);
            this.tabPageFindDevice.TabIndex = 2;
            this.tabPageFindDevice.Text = "findDevice";
            this.tabPageFindDevice.UseVisualStyleBackColor = true;
            // 
            // labelSearchState
            // 
            this.labelSearchState.AutoSize = true;
            this.labelSearchState.Location = new System.Drawing.Point(324, 47);
            this.labelSearchState.Name = "labelSearchState";
            this.labelSearchState.Size = new System.Drawing.Size(0, 12);
            this.labelSearchState.TabIndex = 6;
            // 
            // textBoxFindCompany
            // 
            this.textBoxFindCompany.Location = new System.Drawing.Point(6, 38);
            this.textBoxFindCompany.Name = "textBoxFindCompany";
            this.textBoxFindCompany.Size = new System.Drawing.Size(214, 22);
            this.textBoxFindCompany.TabIndex = 5;
            // 
            // buttonFindDevice
            // 
            this.buttonFindDevice.Location = new System.Drawing.Point(242, 38);
            this.buttonFindDevice.Name = "buttonFindDevice";
            this.buttonFindDevice.Size = new System.Drawing.Size(75, 23);
            this.buttonFindDevice.TabIndex = 4;
            this.buttonFindDevice.Text = "find device";
            this.buttonFindDevice.UseVisualStyleBackColor = true;
            this.buttonFindDevice.Click += new System.EventHandler(this.buttonFindDevice_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.moudleDataGridViewTextBoxColumn,
            this.serialNumberDataGridViewTextBoxColumn,
            this.ipAddressDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.positionOfDeviceDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.findMyDeviceResultBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(6, 94);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(841, 315);
            this.dataGridView3.TabIndex = 3;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(760, 38);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveToFile.TabIndex = 7;
            this.buttonSaveToFile.Text = "Save To File";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // columnNameDataGridViewTextBoxColumn
            // 
            this.columnNameDataGridViewTextBoxColumn.DataPropertyName = "ColumnName";
            this.columnNameDataGridViewTextBoxColumn.FillWeight = 200F;
            this.columnNameDataGridViewTextBoxColumn.HeaderText = "ColumnName";
            this.columnNameDataGridViewTextBoxColumn.Name = "columnNameDataGridViewTextBoxColumn";
            this.columnNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // columnValueDataGridViewTextBoxColumn
            // 
            this.columnValueDataGridViewTextBoxColumn.DataPropertyName = "ColumnValue";
            this.columnValueDataGridViewTextBoxColumn.FillWeight = 150F;
            this.columnValueDataGridViewTextBoxColumn.HeaderText = "ColumnValue";
            this.columnValueDataGridViewTextBoxColumn.Name = "columnValueDataGridViewTextBoxColumn";
            this.columnValueDataGridViewTextBoxColumn.Width = 150;
            // 
            // searchAllTablesResultBindingSource
            // 
            this.searchAllTablesResultBindingSource.DataSource = typeof(SQLFindInTables.SearchAllTables_Result);
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
            // moudleDataGridViewTextBoxColumn
            // 
            this.moudleDataGridViewTextBoxColumn.DataPropertyName = "moudle";
            this.moudleDataGridViewTextBoxColumn.HeaderText = "moudle";
            this.moudleDataGridViewTextBoxColumn.Name = "moudleDataGridViewTextBoxColumn";
            // 
            // serialNumberDataGridViewTextBoxColumn
            // 
            this.serialNumberDataGridViewTextBoxColumn.DataPropertyName = "serialNumber";
            this.serialNumberDataGridViewTextBoxColumn.HeaderText = "serialNumber";
            this.serialNumberDataGridViewTextBoxColumn.Name = "serialNumberDataGridViewTextBoxColumn";
            // 
            // ipAddressDataGridViewTextBoxColumn
            // 
            this.ipAddressDataGridViewTextBoxColumn.DataPropertyName = "ipAddress";
            this.ipAddressDataGridViewTextBoxColumn.HeaderText = "ipAddress";
            this.ipAddressDataGridViewTextBoxColumn.Name = "ipAddressDataGridViewTextBoxColumn";
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
            // positionOfDeviceDataGridViewTextBoxColumn
            // 
            this.positionOfDeviceDataGridViewTextBoxColumn.DataPropertyName = "positionOfDevice";
            this.positionOfDeviceDataGridViewTextBoxColumn.HeaderText = "positionOfDevice";
            this.positionOfDeviceDataGridViewTextBoxColumn.Name = "positionOfDeviceDataGridViewTextBoxColumn";
            // 
            // findMyDeviceResultBindingSource
            // 
            this.findMyDeviceResultBindingSource.DataSource = typeof(SQLFindInTables.FindMyDevice_Result);
            // 
            // tabPageAddDeviceInfo
            // 
            this.tabPageAddDeviceInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddDeviceInfo.Name = "tabPageAddDeviceInfo";
            this.tabPageAddDeviceInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddDeviceInfo.Size = new System.Drawing.Size(853, 415);
            this.tabPageAddDeviceInfo.TabIndex = 3;
            this.tabPageAddDeviceInfo.Text = "addDeviceInfo";
            this.tabPageAddDeviceInfo.UseVisualStyleBackColor = true;
            // 
            // tabPageReadSearchFile
            // 
            this.tabPageReadSearchFile.Controls.Add(this.listBox1);
            this.tabPageReadSearchFile.Controls.Add(this.comboBox1);
            this.tabPageReadSearchFile.Location = new System.Drawing.Point(4, 22);
            this.tabPageReadSearchFile.Name = "tabPageReadSearchFile";
            this.tabPageReadSearchFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReadSearchFile.Size = new System.Drawing.Size(853, 415);
            this.tabPageReadSearchFile.TabIndex = 4;
            this.tabPageReadSearchFile.Text = "ReadSearchFile";
            this.tabPageReadSearchFile.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(16, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(831, 340);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 465);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageAddRecord.ResumeLayout(false);
            this.tabPageAddRecord.PerformLayout();
            this.tabPageFindDevice.ResumeLayout(false);
            this.tabPageFindDevice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchAllTablesResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findMyDeviceResultBindingSource)).EndInit();
            this.tabPageReadSearchFile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchString;
        private System.Windows.Forms.TabPage tabPageAddRecord;
        private System.Windows.Forms.Label labelAddHint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPositionOfDevicee;
        private System.Windows.Forms.Label labelExisting;
        private System.Windows.Forms.Button buttonFindCompany;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxDevice;
        private System.Windows.Forms.TextBox textBoxModule;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.TextBox textBoxIpAddress;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button buttonAddRecord;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.TabPage tabPageFindDevice;
        private System.Windows.Forms.TextBox textBoxFindCompany;
        private System.Windows.Forms.Button buttonFindDevice;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moudleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionOfDeviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource findMyDeviceResultBindingSource;
        private System.Windows.Forms.BindingSource searchAllTablesResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelSearchState;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.TabPage tabPageAddDeviceInfo;
        private System.Windows.Forms.TabPage tabPageReadSearchFile;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

