﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FieldsProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class fieldsEntities : DbContext
    {
        public fieldsEntities()
            : base("name=fieldsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<FieldEntity> FieldEntities { get; set; }
        public virtual DbSet<PersonEntity> PersonEntities { get; set; }
        public virtual DbSet<ReservationEntity> ReservationEntities { get; set; }
        public virtual DbSet<UserEntity> UserEntities { get; set; }
    }
}