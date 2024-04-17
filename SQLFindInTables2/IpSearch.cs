using SQLFindInTables2;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SQLFindInTables2.IPSearch;

namespace SQLFindInTables2
{
    
    public class IPSearch
    {


        WideWorldImportersEntities MyModel = new WideWorldImportersEntities();

        public class GridView
        {

            public string columnName { get; set; }
            public string columnValue { get; set; }
        }
        public partial class FindMyDevice
        {
            public int ID { get; set; }
            public string company { get; set; }
            public string moudle { get; set; }
            public string serialNumber { get; set; }
            public string ipAddress { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string positionOfDevice { get; set; }
        }
        public List<FindMyDevice_Result> FingMyDevice(string searchCompany)
        {
            var SearchMyDeviceInfo = MyModel.FindMyDevice(searchCompany).ToList();
            return SearchMyDeviceInfo;
        }

        public List<SearchAllTables_Result> FingInTables(string searchString )
        {
            //List<String> list = new List<String>();
            //Dictionary<String, String> Dictionary = new Dictionary<String, String>();

            //GridView gridview = new GridView();
            var SearchAllTables = MyModel.SearchAllTables(searchString);
            var gridview= SearchAllTables.ToList();
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
            if ( FindCompanyName(data.company)  )
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
        

    }

}
