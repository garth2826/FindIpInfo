using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SQLFindInTables
{
    public partial class GarthDevice
    {
        public string ToMyString()
        {
            
            string data = $"ID:{ID} , company_ID:{company_ID} , module:{module} , serialNumber:{serialNumber} , ipAddress:{ipAddress} , username:{username} , password:{password} , positionOfDevice:{positionOfDevice}\r\n";
            return data ;
        }

    }
    public partial class GarthCompany
    {
        public string ToMyString()
        {

            string data = $"ID:{ID} , company:{company}\r\n";
            return data;
        }
    }
    public partial class GarthLog 
    {
        public string ToMyString()
        {

            string data = $"ID:{ID} , device_ID:{device_ID} , logDate:{logDate} , DeviceLog:{DeviceLog} , DeviceConfig:{DeviceConfig}\r\n";
            return data;
        }
    }
}
