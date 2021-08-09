//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Asset_and_Maintenance_Management_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class InventoryOrder
    {
        public System.DateTime orderTime { get; set; }
        public string inventoryCode { get; set; }
        public long orderedQuantity { get; set; }
        public Nullable<System.DateTime> dueDate { get; set; }
        public string supplierID { get; set; }
        public string plant { get; set; }
        public string responsiblePerson { get; set; }
        public bool received { get; set; }
    
        public virtual InventoryItem InventoryItem { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
