using NetKafka.Infrastructure;

namespace NetKafka.APIs;

public class CustomersService : CustomersServiceBase
{
    public CustomersService(NetKafkaDbContext context)
        : base(context) { }
}
