namespace NetKafka.APIs.Dtos;

public class OrderCreateInput
{
    public DateTime CreatedAt { get; set; }

    public Customer? Customer { get; set; }

    public string? Id { get; set; }

    public Customer? UpcomingCustomer { get; set; }

    public DateTime UpdatedAt { get; set; }
}