namespace Domain.Entities;

public sealed record Product
{
    public int Id { get; init; }
    public string ProductName { get; init; } = default!;
    public decimal Price { get; init; }
    public DateOnly Added { get; init; }
    public bool Sale { get; init; }
    public byte[]? Image { get; init; }
}