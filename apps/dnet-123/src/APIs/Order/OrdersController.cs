using Microsoft.AspNetCore.Mvc;

namespace Dnet123.APIs;

[ApiController()]
public class OrdersController : OrdersControllerBase
{
    public OrdersController(IOrdersService service)
        : base(service) { }
}
