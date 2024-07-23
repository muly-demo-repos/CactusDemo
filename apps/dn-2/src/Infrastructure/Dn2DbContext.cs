using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dn2.Infrastructure;

public class Dn2DbContext : IdentityDbContext<IdentityUser>
{
    public Dn2DbContext(DbContextOptions<Dn2DbContext> options)
        : base(options) { }
}
