namespace Domain.Entities;

public sealed class Products
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public string ProductName { get; set; } = default!;
    public DateOnly Added { get; set; }
    public byte[] Image { get; set; } = default!;

}