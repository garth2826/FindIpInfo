//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SQLFindInTables
{
    using System;
    using System.Collections.Generic;
    
    public partial class GarthLog
    {
        public int ID { get; set; }
        public Nullable<int> device_ID { get; set; }
        public System.DateTime logDate { get; set; }
        public string DeviceLog { get; set; }
        public string DeviceConfig { get; set; }
    
        public virtual GarthDevice GarthDevice { get; set; }
    }
}
