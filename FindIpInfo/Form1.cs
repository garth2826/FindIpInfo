using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLFindInTables;
using static System.Net.Mime.MediaTypeNames;
namespace FindIpInfo
{
    public partial class Form1 : Form
    {
        IPSearch test = new IPSearch();
        public List<FindMyDevice_Result> deviceInfo
        { get; set; }
        public Form1()
        {
            InitializeComponent();
            comboBoxCompanyName.DataSource = test.ComboBoxCompany();
            comboBoxChooseCompany.DataSource = test.ComboBoxCompany();
            comboBoxDevice.DataSource = test.ComboBoxDevice(comboBoxChooseCompany.Text);
        }

       
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {


            var list = test.FingInTables(textBoxSearchString.Text);

            /* foreach (var item in list)
             {

                 Debug.WriteLine(item);


             }*/
            //dataGridView1.DataSource = list;
            //Context db = new Context();
            // var data = (from d in db.tablename select d);
            dataGridView2.DataSource = list;
            StringBuilder searchedDevice = new System.Text.StringBuilder();
            //go through list to retrieve  more detailed information
            foreach (var item in list)
            {
                //var columnInfo = item.ColumnName.Split('.');
                //FormattableString message = $"The speed of light is {speedOfLight:N3} km/s.";
                
                searchedDevice.Append(test.FindAllData(item.ColumnName, item.ColumnValue));
                //string sql = $"select * from  { columnInfo[0]}.{columnInfo[1]} where {columnInfo[2]} = {item.ColumnValue} ";


            }
            string fileName = @".\\searchedDevice\\" + DateTime.Now.ToString("yyyyMMdd-HHmm", new System.Globalization.CultureInfo("en-US")) + ".txt";
            File.WriteAllText(fileName, searchedDevice.ToString());
            textBoxDetailedSearchResult.Text = searchedDevice.ToString();
            //richTextBoxSearchDetailedData.Text = searchedDevice.ToString();
            //Process.Start(@".\\searchedDevice\\");
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
            GarthDeviceInfo2 data = new GarthDeviceInfo2();
            data.company = textBoxCompanyName.Text;
            data.device = textBoxDevice.Text;
            data.module = textBoxModule.Text;
            data.serialNumber = textBoxSerialNumber.Text;
            data.IPAddress = textBoxIpAddress.Text;
            data.username = textBoxUserName.Text;
            data.password = textBoxPassword.Text;
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

        private void buttonFindCompany_Click(object sender, EventArgs e)
        {
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void buttonFindDevice_Click(object sender, EventArgs e)
        {
            //string pattern = ("["+textBoxFindCompany.Text+"]");
            //Regex rg = new Regex(pattern);
            var list = test.FindMyDevice(textBoxFindCompany.Text);
            if (list.Count() == 0)
            {
                labelSearchState.Text = "Not Found!";
            }
            else
            {
                labelSearchState.Text = "Found "+list.Count()+" device";
            }
            /* foreach (var item in list)
             {

                 Debug.WriteLine(item);


             }*/
            //dataGridView1.DataSource = list;
            //Context db = new Context();
            // var data = (from d in db.tablename select d);
            dataGridView3.DataSource = list;
            
            deviceInfo = list;
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            string fileName = @".\\deviceInfo\\" + DateTime.Now.ToString("yyyyMMdd-HHmm", new System.Globalization.CultureInfo("en-US")) + ".txt";
            //string store1="";
            System.Text.StringBuilder numbers = new System.Text.StringBuilder();
            foreach (var item in deviceInfo)
            {
                //store1 = string.Concat("company: ", item.company)+"\n"+string.Concat("moudle: ", item.moudle);
                numbers.Append(item.company+" ,"+item.module+"\n");


            }
            File.WriteAllText(fileName, numbers.ToString());


            Process.Start(@".\\deviceInfo\\");
            //The text input is done
            Console.WriteLine("Text input completed.");

            //File.WriteAllText(".\\deviceInfo\\" + DateTime.Now.ToString("dd/MM/yyyy", new System.Globalization.CultureInfo("en-US")) + ".txt", deviceInfo);
            //File.WriteAllText(".\\deviceInfo\\1.txt", deviceInfo);


        }

        private void textBoxDetailedSearchResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddCompany_Click(object sender, EventArgs e)
        {
            if (textBoxCompany.Text == "")
            {
                buttonAddRecord.Enabled = false;
            }
            else
            {
                buttonAddRecord.Enabled = true;
            }
            GarthCompany data = new GarthCompany();
            data.company = textBoxCompany.Text;
            
            test.AddCompany(data);

        }

        private void buttonAddDevice_Click(object sender, EventArgs e)
        {
            if (textBoxDeviceModule.Text == "")
            {
                buttonAddRecord.Enabled = false;
            }
            else
            {
                buttonAddRecord.Enabled = true;
            }
            GarthDevice data = new GarthDevice();
            data.company_ID= test.getCompany_ID(comboBoxCompanyName.Text);
            //need to fix
            data.module = textBoxDeviceModule.Text;
            data.ipAddress = textBoxDeviceIpAddress.Text;
            data.serialNumber = textBoxDeviceSerialNumber.Text;
            data.username = textBoxDeviceUsername.Text;
            data.password = textBoxDevicePassword.Text;
            data.positionOfDevice = textBoxDevicePositionOfDevice.Text;
            
         
            test.AddDevice(data);
            labelDeviceStatus.Text = "saved";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxCompanyName.DataSource = test.ComboBoxCompany();
        }

        private void comboBoxCompanyName_MouseClick(object sender, MouseEventArgs e)
        {
            //comboBoxCompanyName.DataSource = test.ComboBoxCompany();
        }

        private void tabPageAddDeviceInfo_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxCompanyName.DataSource = test.ComboBoxCompany();
        }

        private void textBoxDeviceIpAddress_TextChanged(object sender, EventArgs e)
        {
            labelDeviceStatus.Text = "";
        }

        private void buttonAddLog_Click(object sender, EventArgs e)
        {
            if (textBoxDeviceModule.Text == "")
            {
                buttonAddRecord.Enabled = false;
            }
            else
            {
                buttonAddRecord.Enabled = true;
            }
            GarthLog data = new GarthLog();

            data.device_ID = test.getDevice_ID(comboBoxDevice.Text);
            //need to fix
            data.logDate = DateTime.Now;
            data.DeviceLog = textBoxDeviceLog.Text;
            data.DeviceConfig = textBoxDeviceConfig.Text;
           

            test.AddLog(data);
            labelAddLogStatus.Text = "saved";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxDevicePassword.UseSystemPasswordChar==true)
            {
                textBoxDevicePassword.UseSystemPasswordChar=false;
            }
            else
            {
                textBoxDevicePassword.UseSystemPasswordChar = true;
            }
        }

        private void comboBoxChooseCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDevice.DataSource = test.ComboBoxDevice(comboBoxChooseCompany.Text);
        }
    }
}
