using Microsoft.EntityFrameworkCore;
using ServiceBasedRabbit.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceBasedRabbit.Api.Infrastructure.DbContexts
{
    public interface IAppDbContext
    {
        DbSet<User> User { get; set; }
        DbSet<Item> Item { get; set; }

        Task<int> SaveChanges();
    }
}
