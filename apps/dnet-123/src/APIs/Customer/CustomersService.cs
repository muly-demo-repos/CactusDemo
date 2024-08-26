using Dnet123.Infrastructure;

namespace Dnet123.APIs;

public class CustomersService : CustomersServiceBase
{
    public CustomersService(Dnet123DbContext context)
        : base(context) { }
}
