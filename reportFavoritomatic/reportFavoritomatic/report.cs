//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace reportFavoritomatic
{
    using System;
    using System.Collections.Generic;
    
    public partial class report
    {
        public report()
        {
            this.favorites = new HashSet<favorite>();
        }
    
        public string report_id { get; set; }
        public string report_name { get; set; }
        public Nullable<System.DateTime> creation_date { get; set; }
        public Nullable<System.DateTime> last_updated_date { get; set; }
    
        public virtual ICollection<favorite> favorites { get; set; }
    }
}
