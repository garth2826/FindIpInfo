namespace winFormEF_basic
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchString = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.tabPageAddRecord = new System.Windows.Forms.TabPage();
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
            this.tabControl1.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            this.tabPageAddRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(651, 310);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(111, 84);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearchString
            // 
            this.textBoxSearchString.Location = new System.Drawing.Point(535, 240);
            this.textBoxSearchString.Name = "textBoxSearchString";
            this.textBoxSearchString.Size = new System.Drawing.Size(227, 22);
            this.textBoxSearchString.TabIndex = 1;
            this.textBoxSearchString.Text = "15000";
            this.textBoxSearchString.TextChanged += new System.EventHandler(this.textBoxSearchString_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSearch);
            this.tabControl1.Controls.Add(this.tabPageAddRecord);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.buttonSearch);
            this.tabPageSearch.Controls.Add(this.textBoxSearchString);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(768, 400);
            this.tabPageSearch.TabIndex = 0;
            this.tabPageSearch.Text = "search";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            this.tabPageSearch.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPageAddRecord
            // 
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
            this.tabPageAddRecord.Size = new System.Drawing.Size(768, 400);
            this.tabPageAddRecord.TabIndex = 1;
            this.tabPageAddRecord.Text = "addRecord";
            this.tabPageAddRecord.UseVisualStyleBackColor = true;
            this.tabPageAddRecord.Click += new System.EventHandler(this.tabPageAddRecord_Click);
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
            this.buttonFindCompany.Location = new System.Drawing.Point(385, 22);
            this.buttonFindCompany.Name = "buttonFindCompany";
            this.buttonFindCompany.Size = new System.Drawing.Size(75, 22);
            this.buttonFindCompany.TabIndex = 15;
            this.buttonFindCompany.Text = "find";
            this.buttonFindCompany.UseVisualStyleBackColor = true;
            this.buttonFindCompany.Click += new System.EventHandler(this.button3_Click);
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
            this.buttonAddRecord.Location = new System.Drawing.Point(626, 352);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 448);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            this.tabPageAddRecord.ResumeLayout(false);
            this.tabPageAddRecord.PerformLayout();
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
    }
}

