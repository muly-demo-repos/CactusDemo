using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NetKafka.Infrastructure;

public class NetKafkaDbContext : IdentityDbContext<IdentityUser>
{
    public NetKafkaDbContext(DbContextOptions<NetKafkaDbContext> options)
        : base(options) { }
}
