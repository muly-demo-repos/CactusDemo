using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestThePlugin.Infrastructure.Models;

namespace TestThePlugin.Infrastructure;

public class TestThePluginDbContext : IdentityDbContext<IdentityUser>
{
    public TestThePluginDbContext(DbContextOptions<TestThePluginDbContext> options)
        : base(options) { }

    public DbSet<CustomerDbModel> Customers { get; set; }
}
