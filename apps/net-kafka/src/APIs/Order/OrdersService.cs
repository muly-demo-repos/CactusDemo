using NetKafka.Infrastructure;

namespace NetKafka.APIs;

public class OrdersService : OrdersServiceBase
{
    public OrdersService(NetKafkaDbContext context)
        : base(context) { }
}
