﻿using Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.Data
{
    public class AppIdentityDbContext : IdentityDbContext<ApplicationUser>
    {

        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
            :base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
        }


    }
}
