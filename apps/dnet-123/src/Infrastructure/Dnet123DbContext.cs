using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dnet123.Infrastructure;

public class Dnet123DbContext : IdentityDbContext<IdentityUser>
{
    public Dnet123DbContext(DbContextOptions<Dnet123DbContext> options)
        : base(options) { }
}
