namespace NetKafka.APIs.Dtos;

public class OrderUpdateInput
{
    public DateTime? CreatedAt { get; set; }

    public string? Customer { get; set; }

    public string? Id { get; set; }

    public string? UpcomingCustomer { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
