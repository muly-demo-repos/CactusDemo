using Microsoft.AspNetCore.Mvc;

namespace Dnet123.APIs;

[ApiController()]
public class CategoriesController : CategoriesControllerBase
{
    public CategoriesController(ICategoriesService service)
        : base(service) { }
}
