﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataGridViewEntitiyFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GorselDBEntitiesEntities : DbContext
    {
        public GorselDBEntitiesEntities()
            : base("name=GorselDBEntitiesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ilce> Ilce { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<Kisi> Kisi { get; set; }
        public virtual DbSet<Kitap> Kitap { get; set; }
        public virtual DbSet<Sehir> Sehir { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
