﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Infrastructure.Data;
using AppCore.Interfaces;

namespace Infrastructure.Identity
{
    public static class IoC
    {
        public static void Config(IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<AppIdentityDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("IdentityConnection"), x =>x.MigrationsAssembly("Infrastructure")));

            services.AddDbContext<EasyEatsDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("EasyEatsConnection"), x => x.MigrationsAssembly("Infrastructure")));

            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<AppIdentityDbContext>();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password = new PasswordOptions
                {
                    RequiredLength = 6
                };
            });

            services.AddTransient<IEasyEatsDbContext, EasyEatsDbContext>();
            services.AddTransient<INotificationService, NotificationService>();
            services.AddScoped<IEasyEatsDbContext>(x => x.GetService<EasyEatsDbContext>());

        }
    }
}