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
    
    public partial class Customers1
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCategoryName { get; set; }
        public string PrimaryContact { get; set; }
        public string AlternateContact { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string BuyingGroupName { get; set; }
        public string WebsiteURL { get; set; }
        public string DeliveryMethod { get; set; }
        public string CityName { get; set; }
        public System.Data.Entity.Spatial.DbGeography DeliveryLocation { get; set; }
        public string DeliveryRun { get; set; }
        public string RunPosition { get; set; }
    }
}
