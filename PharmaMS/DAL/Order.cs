//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int id { get; set; }
        public int cart_id { get; set; }
        public int orderstatus_id { get; set; }
        public int delivery_by { get; set; }
        public Nullable<System.DateTime> appx_del_date { get; set; }
    
        public virtual Cart Cart { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Orderstatu Orderstatu { get; set; }
    }
}
