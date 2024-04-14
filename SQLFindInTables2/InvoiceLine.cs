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
    
    public partial class InvoiceLine
    {
        public int InvoiceLineID { get; set; }
        public int InvoiceID { get; set; }
        public int StockItemID { get; set; }
        public string Description { get; set; }
        public int PackageTypeID { get; set; }
        public int Quantity { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal LineProfit { get; set; }
        public decimal ExtendedPrice { get; set; }
        public int LastEditedBy { get; set; }
        public System.DateTime LastEditedWhen { get; set; }
    
        public virtual Person Person { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual PackageType PackageType { get; set; }
        public virtual StockItem StockItem { get; set; }
    }
}