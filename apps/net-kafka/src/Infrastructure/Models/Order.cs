using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetKafka.Infrastructure.Models;

[Table("Orders")]
public class OrderDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    public string? CustomerId { get; set; }

    [ForeignKey(nameof(CustomerId))]
    public CustomerDbModel? Customer { get; set; } = null;

    [Key()]
    [Required()]
    public string Id { get; set; }

    public string? UpcomingCustomerId { get; set; }

    [ForeignKey(nameof(UpcomingCustomerId))]
    public CustomerDbModel? UpcomingCustomer { get; set; } = null;

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
