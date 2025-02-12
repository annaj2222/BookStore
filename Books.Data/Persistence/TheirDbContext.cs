using Books.Domain.Entities;
using Books.Domain.Entities.Friends;
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

        public DbSet<Book> Books { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Domain.Entities.Friends.Author> Authors{ get; set; }
        public DbSet<Publisher> Publishers{ get; set; }
    }
}
