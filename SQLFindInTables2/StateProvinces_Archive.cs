//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SQLFindInTables2
{
    using System;
    using System.Collections.Generic;
    
    public partial class StateProvinces_Archive
    {
        public int StateProvinceID { get; set; }
        public string StateProvinceCode { get; set; }
        public string StateProvinceName { get; set; }
        public int CountryID { get; set; }
        public string SalesTerritory { get; set; }
        public System.Data.Entity.Spatial.DbGeography Border { get; set; }
        public Nullable<long> LatestRecordedPopulation { get; set; }
        public int LastEditedBy { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public System.DateTime ValidTo { get; set; }
    }
}
