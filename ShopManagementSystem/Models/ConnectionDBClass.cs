using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ShopManagementSystem.Models
{
    public class ConnectionDBClass : DbContext
    {
        public ConnectionDBClass(DbContextOptions<ConnectionDBClass> options)
            : base(options)
        { }
        public DbSet<Register> Login { get; set; }

        public DbSet<Service> Service { get; set; }
    }
}
