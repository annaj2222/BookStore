using Books.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Data.Persistence
{
    public class TheirDbContext : DbContext
    {
        public TheirDbContext(DbContextOptions<TheirDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
