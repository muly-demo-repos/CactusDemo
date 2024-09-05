namespace NetKafka.APIs.Dtos;

public class Customer
{
    public DateTime CreatedAt { get; set; }

    public string Id { get; set; }

    public List<string>? PastOrders { get; set; }

    public List<string>? UpcomingOrders { get; set; }

    public DateTime UpdatedAt { get; set; }
}
