using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pluto.Models;

namespace Pluto.Data
{
    public class PlutoContext : IdentityDbContext<PlutoUser, PlutoRole, Guid>
    {
        public PlutoContext(DbContextOptions<PlutoContext> options) : base(options)
        {

        }

        public DbSet<Society> Society {get;set;}
        public DbSet<FormType> FormType {get;set;}
        public DbSet<FormStatus> FormStatus {get;set;}


        public DbSet <SocietyForm> SocietyForm {get;set;}

        public DbSet<UserFormTypeMapping> UserFormTypeMapping{get;set;}
        public DbSet<FormTypeRolePrivilege> FormTypeRolePrivilege{get;set;}

        public DbSet<FeatureType> FeatureType {get;set;}
        public DbSet<SocietyFeature> SocietyFeature {get;set;}
        public DbSet<UserFeatureTypeMapping> UserFeatureTypeMapping{get;set;}

        public DbSet<FormInstance> FormInstance {get;set;}
        public DbSet<FormInstanceApprover> FormInstanceApprover {get;set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Change the PlutoUser entity to point to the Users Table instead of the default
            builder.Entity<PlutoUser>().ToTable("Users");

            builder.Entity<PlutoRole>().ToTable("Roles");           

        }
    }
}
