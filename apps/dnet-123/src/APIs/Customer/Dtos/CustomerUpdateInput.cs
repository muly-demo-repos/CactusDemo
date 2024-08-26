namespace Dnet123.APIs.Dtos;

public class CustomerUpdateInput
{
    public DateTime? CreatedAt { get; set; }

    public string? Email { get; set; }

    public string? FirstName { get; set; }

    public string? Id { get; set; }

    public string? LastName { get; set; }

    public List<string>? Orders { get; set; }

    public string? Phone { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
