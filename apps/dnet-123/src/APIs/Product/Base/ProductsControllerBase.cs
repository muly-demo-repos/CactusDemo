using Dnet123.APIs;
using Dnet123.APIs.Common;
using Dnet123.APIs.Dtos;
using Dnet123.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dnet123.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ProductsControllerBase : ControllerBase
{
    protected readonly IProductsService _service;

    public ProductsControllerBase(IProductsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Product
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Product>> CreateProduct(ProductCreateInput input)
    {
        var product = await _service.CreateProduct(input);

        return CreatedAtAction(nameof(Product), new { id = product.Id }, product);
    }

    /// <summary>
    /// Delete one Product
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteProduct([FromRoute()] ProductWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteProduct(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Products
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Product>>> Products(
        [FromQuery()] ProductFindManyArgs filter
    )
    {
        return Ok(await _service.Products(filter));
    }

    /// <summary>
    /// Meta data about Product records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ProductsMeta(
        [FromQuery()] ProductFindManyArgs filter
    )
    {
        return Ok(await _service.ProductsMeta(filter));
    }

    /// <summary>
    /// Get one Product
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Product>> Product([FromRoute()] ProductWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Product(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Product
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateProduct(
        [FromRoute()] ProductWhereUniqueInput uniqueId,
        [FromQuery()] ProductUpdateInput productUpdateDto
    )
    {
        try
        {
            await _service.UpdateProduct(uniqueId, productUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Category record for Product
    /// </summary>
    [HttpGet("{Id}/category")]
    public async Task<ActionResult<List<Category>>> GetCategory(
        [FromRoute()] ProductWhereUniqueInput uniqueId
    )
    {
        var category = await _service.GetCategory(uniqueId);
        return Ok(category);
    }

    /// <summary>
    /// Connect multiple OrderItems records to Product
    /// </summary>
    [HttpPost("{Id}/orderItems")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectOrderItems(
        [FromRoute()] ProductWhereUniqueInput uniqueId,
        [FromQuery()] OrderItemWhereUniqueInput[] orderItemsId
    )
    {
        try
        {
            await _service.ConnectOrderItems(uniqueId, orderItemsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple OrderItems records from Product
    /// </summary>
    [HttpDelete("{Id}/orderItems")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectOrderItems(
        [FromRoute()] ProductWhereUniqueInput uniqueId,
        [FromBody()] OrderItemWhereUniqueInput[] orderItemsId
    )
    {
        try
        {
            await _service.DisconnectOrderItems(uniqueId, orderItemsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple OrderItems records for Product
    /// </summary>
    [HttpGet("{Id}/orderItems")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<OrderItem>>> FindOrderItems(
        [FromRoute()] ProductWhereUniqueInput uniqueId,
        [FromQuery()] OrderItemFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindOrderItems(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple OrderItems records for Product
    /// </summary>
    [HttpPatch("{Id}/orderItems")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateOrderItems(
        [FromRoute()] ProductWhereUniqueInput uniqueId,
        [FromBody()] OrderItemWhereUniqueInput[] orderItemsId
    )
    {
        try
        {
            await _service.UpdateOrderItems(uniqueId, orderItemsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
