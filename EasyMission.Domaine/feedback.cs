//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyMission.Domaine
{
    using System;
    using System.Collections.Generic;
    
    public partial class feedback
    {
        public int idFeedBack { get; set; }
        public string description { get; set; }
        public string idUser { get; set; }
        public Nullable<int> idService { get; set; }
    
        public virtual aspnetuser aspnetuser { get; set; }
        public virtual service service { get; set; }
    }
}
