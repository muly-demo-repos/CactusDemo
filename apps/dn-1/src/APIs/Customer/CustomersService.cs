using Dn1.Infrastructure;

namespace Dn1.APIs;

public class CustomersService : CustomersServiceBase
{
    public CustomersService(Dn1DbContext context)
        : base(context) { }
}
