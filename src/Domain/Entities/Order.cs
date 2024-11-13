namespace Domain.Entities;

public sealed record Order
{
    public int Id { get; init; }
    public User User { get; init; }
    public DateTime DateCreated { get; init; }
    public DateTime DateFinished { get; set; }
    public List<Product> Product { get; init; } = default!;
}