using Dnet123.APIs.Common;
using Dnet123.APIs.Dtos;

namespace Dnet123.APIs;

public interface IProductsService
{
    /// <summary>
    /// Create one Product
    /// </summary>
    public Task<Product> CreateProduct(ProductCreateInput product);

    /// <summary>
    /// Delete one Product
    /// </summary>
    public Task DeleteProduct(ProductWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Products
    /// </summary>
    public Task<List<Product>> Products(ProductFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Product records
    /// </summary>
    public Task<MetadataDto> ProductsMeta(ProductFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Product
    /// </summary>
    public Task<Product> Product(ProductWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Product
    /// </summary>
    public Task UpdateProduct(ProductWhereUniqueInput uniqueId, ProductUpdateInput updateDto);

    /// <summary>
    /// Get a Category record for Product
    /// </summary>
    public Task<Category> GetCategory(ProductWhereUniqueInput uniqueId);

    /// <summary>
    /// Connect multiple OrderItems records to Product
    /// </summary>
    public Task ConnectOrderItems(
        ProductWhereUniqueInput uniqueId,
        OrderItemWhereUniqueInput[] orderItemsId
    );

    /// <summary>
    /// Disconnect multiple OrderItems records from Product
    /// </summary>
    public Task DisconnectOrderItems(
        ProductWhereUniqueInput uniqueId,
        OrderItemWhereUniqueInput[] orderItemsId
    );

    /// <summary>
    /// Find multiple OrderItems records for Product
    /// </summary>
    public Task<List<OrderItem>> FindOrderItems(
        ProductWhereUniqueInput uniqueId,
        OrderItemFindManyArgs OrderItemFindManyArgs
    );

    /// <summary>
    /// Update multiple OrderItems records for Product
    /// </summary>
    public Task UpdateOrderItems(
        ProductWhereUniqueInput uniqueId,
        OrderItemWhereUniqueInput[] orderItemsId
    );
}
