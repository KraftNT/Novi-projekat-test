﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Novi_projekat_test
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BazaEntities : DbContext
    {
        public BazaEntities()
            : base("name=BazaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DOKUMENTI> DOKUMENTI { get; set; }
        public virtual DbSet<KOMITENTI> KOMITENTI { get; set; }
        public virtual DbSet<ARTIKLI> ARTIKLI { get; set; }
        public virtual DbSet<STAVKE> STAVKE { get; set; }
    }
}
