//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Farm_Central.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class farm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public farm()
        {
            this.products = new HashSet<product>();
        }
    
        public int farm_id { get; set; }
        public int farmer_id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
    
        public virtual farmer farmer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<product> products { get; set; }
    }
}