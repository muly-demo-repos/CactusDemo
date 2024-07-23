using Dn1.APIs.Dtos;
using Dn1.Infrastructure.Models;

namespace Dn1.APIs.Extensions;

public static class CustomersExtensions
{
    public static Customer ToDto(this CustomerDbModel model)
    {
        return new Customer
        {
            Id = model.Id,
            CreatedAt = model.CreatedAt,
            UpdatedAt = model.UpdatedAt,
            Name = model.Name,
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
