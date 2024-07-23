using Dn1.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dn1.Infrastructure;

public class Dn1DbContext : IdentityDbContext<IdentityUser>
{
    public Dn1DbContext(DbContextOptions<Dn1DbContext> options)
        : base(options) { }

    public DbSet<CustomerDbModel> Customers { get; set; }
}
