//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyMission.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class payment
    {
        public payment()
        {
            this.services = new HashSet<service>();
        }
    
        public int idPayment { get; set; }
        public Nullable<System.DateTime> datePayment { get; set; }
        public Nullable<float> valeur { get; set; }
        public Nullable<int> user_idUser { get; set; }
    
        public virtual ICollection<service> services { get; set; }
        public virtual user user { get; set; }
    }
}
