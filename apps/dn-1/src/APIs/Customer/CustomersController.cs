using Microsoft.AspNetCore.Mvc;

namespace Dn1.APIs;

[ApiController()]
public class CustomersController : CustomersControllerBase
{
    public CustomersController(ICustomersService service)
        : base(service) { }
}
