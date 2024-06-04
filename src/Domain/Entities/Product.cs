namespace Domain.Entities;

public sealed class Product
{
    public int Id { get; set; }
    public string ProductName { get; set; } = default!;
    public DateOnly Added { get; set; }
    public bool Sale { get; set; }
    public byte[]? Image { get; set; } = default!;

}