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
using FindIpInfo;
namespace winFormEF_basic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GridView gridView=new GridView();

        
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            

          

            IPSearch tt = new IPSearch();

            var list = tt.FingInTables(textBoxSearchString.Text);

            foreach (var item in list)
            {

                Debug.WriteLine(item);


            }
            //dataGridView1.DataSource = list;
            //Context db = new Context();
            // var data = (from d in db.tablename select d);
            dataGridView2.DataSource = list;


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
            var store1 = data.company;
            if (store1 == textBoxCompanyName.Text)
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

        private void labelAddHint_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
               
            }
            else 
            {
                e.Cancel = true;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
