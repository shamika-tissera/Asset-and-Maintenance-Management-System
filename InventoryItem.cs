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
    
    public partial class InventoryItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InventoryItem()
        {
            this.InventoryOrders = new HashSet<InventoryOrder>();
        }
    
        public string inventoryCode { get; set; }
        public string inventoryName { get; set; }
        public string inventoryType { get; set; }
        public int threshold { get; set; }
        public int currentQuantity { get; set; }
        public Nullable<decimal> CurrentCost { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryOrder> InventoryOrders { get; set; }
    }
}