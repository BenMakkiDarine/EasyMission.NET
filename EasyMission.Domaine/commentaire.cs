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
    
    public partial class commentaire
    {
        public int commentaireId { get; set; }
        public int idForum { get; set; }
        public string idUser { get; set; }
        public string message { get; set; }
    
        public virtual aspnetuser aspnetuser { get; set; }
        public virtual forum forum { get; set; }
    }
}
