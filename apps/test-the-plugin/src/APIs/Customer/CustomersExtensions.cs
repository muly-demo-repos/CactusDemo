using TestThePlugin.APIs.Dtos;
using TestThePlugin.Infrastructure.Models;

namespace TestThePlugin.APIs.Extensions;

public static class CustomersExtensions
{
    public static Customer ToDto(this CustomerDbModel model)
    {
        return new Customer
        {
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            Name = model.Name,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static CustomerDbModel ToModel(
        this CustomerUpdateInput updateDto,
        CustomerWhereUniqueInput uniqueId
    )
    {
        var customer = new CustomerDbModel { Id = uniqueId.Id, Name = updateDto.Name };

        // map required fields
        if (updateDto.CreatedAt != null)
        {
            customer.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            customer.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return customer;
    }
}
