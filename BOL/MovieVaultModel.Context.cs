﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BOL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MovieVaultEntities : DbContext
    {
        public MovieVaultEntities()
            : base("name=MovieVaultEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MovieReview> MovieReviews { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<RentalHistory> RentalHistories { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
