using TestThePlugin.Infrastructure;

namespace TestThePlugin.APIs;

public class CustomersService : CustomersServiceBase
{
    public CustomersService(TestThePluginDbContext context)
        : base(context) { }
}
