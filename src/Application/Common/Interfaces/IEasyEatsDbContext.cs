﻿using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using Entities = Domain.Entities;

namespace Application.Common.Interfaces
{
    public interface IEasyEatsDbContext
    {
        DbSet<Entities.Customer> Customers { get; set; }
        DbSet<Entities.Order> Orders { get; set; }
        DbSet<Entities.OrderDetails> OrderDetails { get; set; }
        DbSet<Entities.Product> Products { get; set; }
        DbSet<Entities.Bill> Bills { get; set; }
        DbSet<Entities.Reservation> Reservations { get; set; }
        DbSet<Entities.Table> Tables { get; set; }


        Task<int> SaveChangesAsync(CancellationToken cancelletion);

    }
}