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
    
    public partial class Disposal
    {
        public int Id { get; set; }
        public string asset_id { get; set; }
        public System.DateTime disposedDate { get; set; }
        public Nullable<decimal> disposedValue { get; set; }
    
        public virtual NonCurrentAsset NonCurrentAsset { get; set; }
    }
}
