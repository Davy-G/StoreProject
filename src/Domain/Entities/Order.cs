namespace Domain.Entities;

public sealed record Order
{
    public int Id { get; set; }
    public User User { get; set; } = default!;
    public List<Product> Product { get; set; } = default!;
    public DateOnly DateCreated { get; set; }
    public DateOnly DateFinished { get; set; }
}