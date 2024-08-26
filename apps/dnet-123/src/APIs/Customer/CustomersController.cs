using Microsoft.AspNetCore.Mvc;

namespace Dnet123.APIs;

[ApiController()]
public class CustomersController : CustomersControllerBase
{
    public CustomersController(ICustomersService service)
        : base(service) { }
}
