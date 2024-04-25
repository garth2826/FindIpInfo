using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLFindInTables
{
    public class IPSearch
    {
        WideWorldImportersEntities MyModel = new WideWorldImportersEntities();
        
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
        public string FindAllData(string columnName,string columnValue)
        {
            var columnInfo = columnName.Split('.');
            string sql = $"select CityID  from  {columnInfo[0]}.{columnInfo[1]} where {columnInfo[2]} = {columnValue} ";
            /*if($"{ columnInfo[0]}.{ columnInfo[1]}"== "Customers")
            {
                return MyModel.DatabaseCustomers;
            }*/
            var list = MyModel.Database.SqlQuery<int>(sql);
            foreach (var item in list)
            {
              
            }
            return "";

        }

    }
}
