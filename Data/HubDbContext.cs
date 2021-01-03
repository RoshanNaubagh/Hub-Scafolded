using Hub.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hub.Models.Organization;

namespace Hub.Data
{
    public class HubDbContext : IdentityDbContext<HubUser>
    {
        public HubDbContext(DbContextOptions<HubDbContext> options)
          : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Hub.Models.Organization.Module> Module { get; set; }
        public DbSet<Hub.Models.Organization.ModuleCategory> ModuleCategory { get; set; }
        public DbSet<Hub.Models.Organization.Org> Org { get; set; }
        public DbSet<Hub.Models.Organization.UserDetail> UserDetail { get; set; }

    }
   



 }
