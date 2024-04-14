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

namespace SQLFindInTables2
{
    
    public class IPSearch
    {

        WideWorldImportersEntities MyModel = new WideWorldImportersEntities();

        public List<String>  FingInTables(string searchString )
        {
            List<String> list = new List<String>();
            //Dictionary<String, String> Dictionary = new Dictionary<String, String>();


            var SearchAllTables = MyModel.SearchAllTables(searchString);
            foreach (var item in SearchAllTables)
            {

                //Debug.WriteLine(item.ColumnValue);
                list.Add(item.ColumnName+":"+ item.ColumnValue);
                //Dictionary(item.ColumnName, list);
            }



            //garth todo , make it work,return in any type
            //var testlist=SearchAllTables.ToList<string>();
            //search all  column  and  store in list
            //var testValue = MyModel.GarthDeviceInfoes.Where(a => a.ID > 1);
            //var testValue = MyModel.GarthDeviceInfoes.Where(a => a.company = textBoxCompanyName.);
            return list;
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
