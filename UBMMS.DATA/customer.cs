//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UBMMS.DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class customer
    {
        public customer()
        {
            this.project_codes = new HashSet<project_codes>();
        }
    
        public int id { get; set; }
        public string customer_name { get; set; }
        public string sstem_code { get; set; }
        public bool enabled { get; set; }
    
        public virtual ICollection<project_codes> project_codes { get; set; }
    }
}
