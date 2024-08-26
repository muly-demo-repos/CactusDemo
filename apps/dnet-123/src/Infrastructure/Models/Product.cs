using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dnet123.Infrastructure.Models;

[Table("Products")]
public class ProductDbModel
{
    public string? CategoryId { get; set; }

    [ForeignKey(nameof(CategoryId))]
    public CategoryDbModel? Category { get; set; } = null;

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? Description { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? Name { get; set; }

    public List<OrderItemDbModel>? OrderItems { get; set; } = new List<OrderItemDbModel>();

    [Range(-999999999, 999999999)]
    public double? Price { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
