using Dnet123.Infrastructure;

namespace Dnet123.APIs;

public class CategoriesService : CategoriesServiceBase
{
    public CategoriesService(Dnet123DbContext context)
        : base(context) { }
}
