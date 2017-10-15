﻿using System;
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Change the PlutoUser entity to point to the Users Table instead of the default
            builder.Entity<PlutoUser>().ToTable("Users");

            builder.Entity<PlutoRole>().ToTable("Roles");
            
        }
    }
}
