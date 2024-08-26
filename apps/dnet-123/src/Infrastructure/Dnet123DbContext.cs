using Dnet123.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dnet123.Infrastructure;

public class Dnet123DbContext : IdentityDbContext<IdentityUser>
{
    public Dnet123DbContext(DbContextOptions<Dnet123DbContext> options)
        : base(options) { }

    public DbSet<ProductDbModel> Products { get; set; }

    public DbSet<OrderDbModel> Orders { get; set; }

    public DbSet<CustomerDbModel> Customers { get; set; }

    public DbSet<OrderItemDbModel> OrderItems { get; set; }

    public DbSet<CategoryDbModel> Categories { get; set; }
}
