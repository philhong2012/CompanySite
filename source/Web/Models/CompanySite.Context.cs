﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace CompanySite.Models
{
    public partial class CompanyEntities : DbContext
    {
        public CompanyEntities()
            : base("name=CompanyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Introduction> Introductions { get; set; }
        public DbSet<LoginLog> LoginLogs { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsClass> NewsClasses { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductClass> ProductClasses { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectClass> ProjectClasses { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
