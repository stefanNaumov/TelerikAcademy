//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _08.EntityClassInheritance
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerDemographics
    {
        public CustomerDemographics()
        {
            this.Customers = new HashSet<Customers>();
        }
    
        public string CustomerTypeID { get; set; }
        public string CustomerDesc { get; set; }
    
        public virtual ICollection<Customers> Customers { get; set; }
    }
}
