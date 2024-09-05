using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NetKafka.Infrastructure.Models;

namespace NetKafka.Infrastructure;

public class NetKafkaDbContext : IdentityDbContext<IdentityUser>
{
    public NetKafkaDbContext(DbContextOptions<NetKafkaDbContext> options)
        : base(options) { }

    public DbSet<CustomerDbModel> Customers { get; set; }

    public DbSet<OrderDbModel> Orders { get; set; }
}
