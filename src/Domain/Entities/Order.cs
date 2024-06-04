namespace Domain.Entities;

public class Order
{
    public int Id { get; set; }
    public User User { get; set; } = default!;
    public List<Product> Product { get; set; } = default!;
    public DateOnly Date { get; set; }
    
}