namespace Dnet123.APIs.Dtos;

public class Product
{
    public string? Category { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? Description { get; set; }

    public string Id { get; set; }

    public string? Name { get; set; }

    public List<string>? OrderItems { get; set; }

    public double? Price { get; set; }

    public DateTime UpdatedAt { get; set; }
}
