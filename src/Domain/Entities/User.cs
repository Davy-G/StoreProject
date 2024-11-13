namespace Domain.Entities;

public sealed record User
{
    public int Id { get; init; }
    public string Name { get; init; } = default!;
    public string Surname { get; init; } = default!;
    public string UserName { get; init; } = default!;
    public string HashedPassword { get; init; } = default!;
    public string RegisterDate { get; init; } = default!;
    public byte[]? Image { get; init; }
}