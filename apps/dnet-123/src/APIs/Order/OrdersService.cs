using Dnet123.Infrastructure;

namespace Dnet123.APIs;

public class OrdersService : OrdersServiceBase
{
    public OrdersService(Dnet123DbContext context)
        : base(context) { }
}
