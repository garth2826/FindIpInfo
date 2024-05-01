using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SQLFindInTables
{
    public class IPSearch
    {
        WideWorldImportersEntities4 MyModel = new WideWorldImportersEntities4();
        
        public List<FindMyDevice_Result> FindMyDevice(string searchCompany)
        {
            var SearchMyDeviceInfo = MyModel.FindMyDevice(searchCompany).ToList();
            return SearchMyDeviceInfo;
        }
        public List<SearchAllTables_Result> FingInTables(string searchString)
        {
            //List<String> list = new List<String>();
            //Dictionary<String, String> Dictionary = new Dictionary<String, String>();

            //GridView gridview = new GridView();
            var SearchAllTables = MyModel.SearchAllTables(searchString);
            var gridview = SearchAllTables.ToList();
            /*foreach (var item in SearchAllTables)
            {

                //Debug.WriteLine(item.ColumnValue);
                gridview.columnName = item.ColumnName;
                gridview.columnValue = item.ColumnValue;
                //Dictionary(item.ColumnName, list);
            }*/



            //garth todo , make it work,return in any type
            //var testlist=SearchAllTables.ToList<string>();
            //search all  column  and  store in list
            //var testValue = MyModel.GarthDeviceInfoes.Where(a => a.ID > 1);
            //var testValue = MyModel.GarthDeviceInfoes.Where(a => a.company = textBoxCompanyName.);
            //var stored=SearchAllTables.ToList();
            //return stored;
            return gridview;
        }
        public bool FindCompanyName(string CompanyName)
        {
            var testValue = MyModel.GarthDeviceInfo2.Where(a => a.company == CompanyName).Count();
            if (testValue > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            //garth  another way to bool
            //return testValue > 0;
        }
        public void AddCompany(GarthCompany data)
        {
            
            MyModel.GarthCompanies.Add(data);

            MyModel.SaveChanges();
            //MyModel.SaveChangesAsync().;    
            //int StateStored=MyModel.SaveChanges();
            //return StateStored;
        }
        public void AddDevice(GarthDevice data)
        {

            MyModel.GarthDevices.Add(data);

            MyModel.SaveChanges();
            //MyModel.SaveChangesAsync().;    
            //int StateStored=MyModel.SaveChanges();
            //return StateStored;
        }
        public void AddLog(GarthLog data)
        {

            MyModel.GarthLogs.Add(data);

            MyModel.SaveChanges();
            //MyModel.SaveChangesAsync().;    
            //int StateStored=MyModel.SaveChanges();
            //return StateStored;
        }
        //combobox companyname data source
        Dictionary<string, int> deviceDictionary = new Dictionary<string, int>();
        public int getDevice_ID(string deviceName)
        {
            int ID = -1;
            if (!deviceDictionary.TryGetValue(deviceName, out ID))
            {
                ID = -1;
            }
            return ID;
        }
        public List<string> ComboBoxDevice(string chooseCompany)
        {
            deviceDictionary.Clear();
            var company_ID = getCompany_ID(chooseCompany);
            List<string> deviceList = new List<string>();
            var list = from s in MyModel.GarthDevices
                       where s.company_ID == company_ID
                       select new { s.ID,s.ipAddress,s.module };
                       
            /* var studentNames = studentList.Where(s => s.Age > 18)
                               .Select(s => s)
                               .Where(st => st.StandardID > 0)
                               .Select(s => s.StudentName);
            */
            //string sql = $"select company  from  [dbo].[GarthCompany]  ";
            //var list = MyModel.GarthCompanies.SqlQuery(sql);
            foreach (var item in list)
            {
                deviceList.Add($"{item.module}:{item.ipAddress}");
                deviceDictionary.Add($"{ item.module}:{item.ipAddress}", item.ID);
            }
            return deviceList;
        }
        Dictionary<string, int> companyDictionary = new Dictionary<string, int>();
        public int getCompany_ID(string companyName)
        {
            int ID = -1;
            if (!companyDictionary.TryGetValue(companyName, out ID))
            {
                ID = -1;
            }
            return ID;
        }
        public List<string> ComboBoxCompany()
        {
            companyDictionary.Clear();
            List<string> companyList = new List<string>();
            var list = from s in MyModel.GarthCompanies
                       select new { s.ID, s.company};
           /* var studentNames = studentList.Where(s => s.Age > 18)
                              .Select(s => s)
                              .Where(st => st.StandardID > 0)
                              .Select(s => s.StudentName);
           */
            //string sql = $"select company  from  [dbo].[GarthCompany]  ";
            //var list = MyModel.GarthCompanies.SqlQuery(sql);
            foreach (var item in list)
            {
                companyList.Add(item.company);
                companyDictionary.Add(item.company,item.ID);
            }
            return companyList;
        }
       /* public int convertCompanyToCompany_ID()
        {
            var list = from s in MyModel.GarthCompanies
                       select s.ID,;
             var studentNames = studentList.Where(s => s.Age > 18)
                               .Select(s => s)
                               .Where(st => st.StandardID > 0)
                               .Select(s => s.StudentName);
            
            //string sql = $"select company  from  [dbo].[GarthCompany]  ";
            //var list = MyModel.GarthCompanies.SqlQuery(sql);
            foreach (var item in list)
            {
                companyList.Add(item);
            }
            return companyList;
        }*/
        public void AddOrUpdataData(GarthDeviceInfo2 data)
        {
            if (FindCompanyName(data.company))
            {
                var targetEntry = MyModel.GarthDeviceInfo2.Where(a => a.company == data.company).FirstOrDefault();
                targetEntry.device = data.device;


            }
            else
            {
                MyModel.GarthDeviceInfo2.Add(data);

            }
            MyModel.SaveChanges();
            //MyModel.SaveChangesAsync().;    
            //int StateStored=MyModel.SaveChanges();
            //return StateStored;
        }
        List<string> existingID = new List<string>();
        public string FindAllData(string columnName,string columnValue)
        {
            var columnInfo = columnName.Split('.');
            //string sql = $"select *  from  {columnInfo[0]}.{columnInfo[1]} where {columnInfo[2]} = {columnValue} ";
            /*if($"{ columnInfo[0]}.{ columnInfo[1]}"== "Customers")
            {
                return MyModel.DatabaseCustomers;
            }*/
            //var list = MyModel.Database.SqlQuery<IEnumerable<Tuple<int, string>>>(sql);
            //string sql2 = $"select *  from  [Application].[Cities] where [CityID] = 15000 ";
            //string sql3 = $"select CityID,LastEditedBy  from  [Application].[Cities] where [CityID] = 15000 ";
            
            StringBuilder test = new System.Text.StringBuilder();
            
            if (columnInfo[1]=="[GarthDevice]")
            {
                string sql = $"select *  from  {columnInfo[0]}.{columnInfo[1]} where {columnInfo[2]} = '{columnValue}' ";
                var list = MyModel.Database.SqlQuery<GarthDevice>(sql);
                foreach (var item in list)
                {
                    if(existingID.Exists(x => x ==$"{columnInfo[1]}:{item.ID}"))
                    {
                        break;
                    }
                    else
                    {
                        test.Append(item.ToMyString());
                        existingID.Add($"{columnInfo[1]}:{item.ID}");
                    }
                    //test.Append(item.ToMyString());
                }
            }
            else if(columnInfo[1] == "[GarthCompany]")
            {
                string sql = $"select *  from  {columnInfo[0]}.{columnInfo[1]} where {columnInfo[2]} = '{columnValue}' ";
                var list = MyModel.Database.SqlQuery<GarthCompany>(sql);
                foreach (var item in list)
                {

                    if (existingID.Exists(x => x == $"{columnInfo[1]}:{item.ID}"))
                    {
                        break;
                    }
                    else
                    {
                        test.Append(item.ToMyString());
                        existingID.Add($"{columnInfo[1]}:{item.ID}");
                    }
                }
            }
            else if (columnInfo[1] == "[GarthLog]")
            {
                string sql = $"select *  from  {columnInfo[0]}.{columnInfo[1]} where {columnInfo[2]} = ' {columnValue} ' ";
                var list = MyModel.Database.SqlQuery<GarthLog>(sql);
                foreach (var item in list)
                {

                    if (existingID.Exists(x => x == $"{columnInfo[1]}:{item.ID}"))
                    {
                        break;
                    }
                    else
                    {
                        test.Append(item.ToMyString());
                        existingID.Add($"{columnInfo[1]}:{item.ID}");
                    }
                }
            }
            else
            {
                //Do nothing here!!        
            }
            //var list2 = MyModel.Database.SqlQuery<City>(sql2);
            //var list3= MyModel.Database.SqlQuery<int>(sql3);
            //var list = MyModel.Database.SqlQuery<string>(sql);
          
            return test.ToString();

        }

    }
}
