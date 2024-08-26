using Dnet123.Infrastructure;

namespace Dnet123.APIs;

public class OrderItemsService : OrderItemsServiceBase
{
    public OrderItemsService(Dnet123DbContext context)
        : base(context) { }
}
