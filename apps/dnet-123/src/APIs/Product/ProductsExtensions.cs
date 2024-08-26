using Dnet123.APIs.Dtos;
using Dnet123.Infrastructure.Models;

namespace Dnet123.APIs.Extensions;

public static class ProductsExtensions
{
    public static Product ToDto(this ProductDbModel model)
    {
        return new Product
        {
            Category = model.CategoryId,
            CreatedAt = model.CreatedAt,
            Description = model.Description,
            Id = model.Id,
            Name = model.Name,
            OrderItems = model.OrderItems?.Select(x => x.Id).ToList(),
            Price = model.Price,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ProductDbModel ToModel(
        this ProductUpdateInput updateDto,
        ProductWhereUniqueInput uniqueId
    )
    {
        var product = new ProductDbModel
        {
            Id = uniqueId.Id,
            Description = updateDto.Description,
            Name = updateDto.Name,
            Price = updateDto.Price
        };

        if (updateDto.Category != null)
        {
            product.CategoryId = updateDto.Category;
        }
        if (updateDto.CreatedAt != null)
        {
            product.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            product.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return product;
    }
}
