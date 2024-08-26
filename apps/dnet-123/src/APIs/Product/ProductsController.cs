using Microsoft.AspNetCore.Mvc;

namespace Dnet123.APIs;

[ApiController()]
public class ProductsController : ProductsControllerBase
{
    public ProductsController(IProductsService service)
        : base(service) { }
}
