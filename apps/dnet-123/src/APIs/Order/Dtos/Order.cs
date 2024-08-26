namespace Dnet123.APIs.Dtos;

public class Order
{
    public DateTime CreatedAt { get; set; }

    public string? Customer { get; set; }

    public string Id { get; set; }

    public DateTime? OrderDate { get; set; }

    public List<string>? OrderItems { get; set; }

    public DateTime UpdatedAt { get; set; }
}