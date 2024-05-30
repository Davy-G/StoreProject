namespace Domain.Entities;

public class Users
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Surname { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string HashedPassword { get; set; } = default!;
    public string RegisterDate { get; set; } = default!;
    public byte[] Image { get; set; } = default!;
    
}