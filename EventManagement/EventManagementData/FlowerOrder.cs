//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventManagementData
{
    using System;
    using System.Collections.Generic;
    
    public partial class FlowerOrder
    {
        public int flower_order_id { get; set; }
        public string flower_name { get; set; }
        public int flower_cost { get; set; }
        public Nullable<int> event_id { get; set; }
        public Nullable<int> user_id { get; set; }
    
        public virtual EventsTable EventsTable { get; set; }
        public virtual UsersTable UsersTable { get; set; }
    }
}
