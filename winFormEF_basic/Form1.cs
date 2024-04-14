using Microsoft.SqlServer.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLFindInTables2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace winFormEF_basic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            

          

            IPSearch tt = new IPSearch();

            var list = tt.FingInTables(textBoxSearchString.Text);

            foreach (var item in list)
            {

                Debug.WriteLine(item);

            }




        }

        private void textBoxSearchString_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            if (textBoxCompanyName.Text == "")
            {
                buttonAddRecord.Enabled = false;
            }
            else
            {
                buttonAddRecord.Enabled = true;
            }
            IPSearch test = new IPSearch();
            GarthDeviceInfo2 data= new GarthDeviceInfo2();
            data.company = textBoxCompanyName.Text;
            data.device = textBoxDevice.Text;
            data.module = textBoxModule.Text;
            data.serialNumber = textBoxSerialNumber.Text;
            data.IPAddress=textBoxIpAddress.Text;
            data.username=textBoxUserName.Text;
            data.password=textBoxPassword.Text;
            data.position = textBoxPositionOfDevicee.Text;
            test.AddOrUpdataData(data);
            labelAddHint.Text = "success";
           

            if (test.FindCompanyName(textBoxCompanyName.Text) == true)
            {
                labelExisting.Text = "Existing";
                
            }
            else
            {
                labelExisting.Text = "New";
            }

            if (textBoxCompanyName.Text == "")
            {
                buttonAddRecord.Enabled = false;
            }
            else
            {
                buttonAddRecord.Enabled = true;
            }
        }

        private void textBoxCompanyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            IPSearch test = new IPSearch();
            if (test.FindCompanyName(textBoxCompanyName.Text) == true)
            {
                labelExisting.Text = "Existing";
            }
            else
            {
                labelExisting.Text = "New";
            }
            
        }

        private void tabPageAddRecord_Click(object sender, EventArgs e)
        {
            if (textBoxCompanyName.Text == "")
            {
                buttonAddRecord.Enabled = false;
            }
            else
            {
                buttonAddRecord.Enabled = true;
            }
            labelAddHint.Text = "";

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
