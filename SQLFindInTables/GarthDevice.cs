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
    
    public partial class GarthDevice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GarthDevice()
        {
            this.GarthLogs = new HashSet<GarthLog>();
        }
    
        public int ID { get; set; }
        public Nullable<int> company_ID { get; set; }
        public string module { get; set; }
        public string serialNumber { get; set; }
        public string ipAddress { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string positionOfDevice { get; set; }
    
        public virtual GarthCompany GarthCompany { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GarthLog> GarthLogs { get; set; }
    }
}
