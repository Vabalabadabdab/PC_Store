using Domain_ComputerStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Core_ComputerStore.Context
{
    public class StoreContext : IdentityDbContext<User, Role, Guid>
    {
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<GroupReview> GroupsReview { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}
