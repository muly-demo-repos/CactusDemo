using Microsoft.AspNetCore.Mvc;

namespace NetKafka.APIs;

[ApiController()]
public class CustomersController : CustomersControllerBase
{
    public CustomersController(ICustomersService service)
        : base(service) { }
}
