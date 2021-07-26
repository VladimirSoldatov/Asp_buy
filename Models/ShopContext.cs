using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Begin.Models
{
    public class ShopContext:DbContext
    {
        public DbSet<Phone> Phones { set; get; }
        public DbSet<User> Users { set; get; }
        public DbSet<Order> Orders { set; get; }
        public ShopContext(DbContextOptions<ShopContext> options):base(options)
        {
            Database.EnsureCreated();

        }
    }
}
