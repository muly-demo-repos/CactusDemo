using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Adad.Infrastructure;

public class AdadDbContext : IdentityDbContext<IdentityUser>
{
    public AdadDbContext(DbContextOptions<AdadDbContext> options)
        : base(options) { }
}
