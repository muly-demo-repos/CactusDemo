using Microsoft.AspNetCore.Mvc;

namespace NetKafka.APIs;

[ApiController()]
public class OrdersController : OrdersControllerBase
{
    public OrdersController(IOrdersService service)
        : base(service) { }
}
