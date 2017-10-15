using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pluto.Models;

namespace Pluto.Data
{
    public class PlutoContext : IdentityDbContext<PlutoUser, IdentityRole<Guid>, Guid>
    {
        public PlutoContext(DbContextOptions<PlutoContext> options) : base(options)
        {

        }        
    }
}
