﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class easymissionEntities : DbContext
    {
        public easymissionEntities()
            : base("name=easymissionEntitiesContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<C__migrationhistory> C__migrationhistory { get; set; }
        public DbSet<aspnetrole> aspnetroles { get; set; }
        public DbSet<aspnetuserclaim> aspnetuserclaims { get; set; }
        public DbSet<aspnetuserlogin> aspnetuserlogins { get; set; }
        public DbSet<aspnetuser> aspnetusers { get; set; }
        public DbSet<candidature> candidatures { get; set; }
        public DbSet<commentaire> commentaires { get; set; }
        public DbSet<cv> cvs { get; set; }
        public DbSet<feedback> feedbacks { get; set; }
        public DbSet<offre> offres { get; set; }
        public DbSet<payment> payments { get; set; }
        public DbSet<promotion> promotions { get; set; }
        public DbSet<reclamation> reclamations { get; set; }
        public DbSet<service> services { get; set; }
        public DbSet<sujet> sujets { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<forum> fora { get; set; }
    }
}
