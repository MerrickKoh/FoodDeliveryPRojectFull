﻿using FoodDeliveryPRojectFull.Server.Models;
using FoodDeliveryPRojectFull.Shared.Domains;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryPRojectFull.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Catergory> Catergory { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<payment> payment { get; set; }

    }
}
