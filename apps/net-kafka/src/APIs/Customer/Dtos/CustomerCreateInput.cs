namespace NetKafka.APIs.Dtos;

public class CustomerCreateInput
{
    public DateTime CreatedAt { get; set; }

    public string? Id { get; set; }

    public List<Order>? PastOrders { get; set; }

    public List<Order>? UpcomingOrders { get; set; }

    public DateTime UpdatedAt { get; set; }
}
