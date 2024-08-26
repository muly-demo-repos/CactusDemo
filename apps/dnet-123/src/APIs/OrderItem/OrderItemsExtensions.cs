using Dnet123.APIs.Dtos;
using Dnet123.Infrastructure.Models;

namespace Dnet123.APIs.Extensions;

public static class OrderItemsExtensions
{
    public static OrderItem ToDto(this OrderItemDbModel model)
    {
        return new OrderItem
        {
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            Order = model.OrderId,
            Product = model.ProductId,
            Quantity = model.Quantity,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static OrderItemDbModel ToModel(
        this OrderItemUpdateInput updateDto,
        OrderItemWhereUniqueInput uniqueId
    )
    {
        var orderItem = new OrderItemDbModel { Id = uniqueId.Id, Quantity = updateDto.Quantity };

        if (updateDto.CreatedAt != null)
        {
            orderItem.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.Order != null)
        {
            orderItem.OrderId = updateDto.Order;
        }
        if (updateDto.Product != null)
        {
            orderItem.ProductId = updateDto.Product;
        }
        if (updateDto.UpdatedAt != null)
        {
            orderItem.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return orderItem;
    }
}
