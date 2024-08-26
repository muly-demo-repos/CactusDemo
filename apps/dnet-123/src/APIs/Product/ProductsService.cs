using Dnet123.Infrastructure;

namespace Dnet123.APIs;

public class ProductsService : ProductsServiceBase
{
    public ProductsService(Dnet123DbContext context)
        : base(context) { }
}
