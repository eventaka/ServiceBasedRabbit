using Microsoft.EntityFrameworkCore;
using ServiceBasedRabbit.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceBasedRabbit.Api.Infrastructure.DbContexts
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        //public DbSet<User> Users { get; set; }
        //public DbSet<Item> Items { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=AKADESK;Database=RabbitMQ;Trusted_Connection=True;");
        //}
        public DbSet<User> User { get; set; }
        public DbSet<Item> Item { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public new async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}
