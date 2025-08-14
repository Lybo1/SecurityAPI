namespace SecurityApi.Models;

internal sealed class UserPhoto
{
    public required Guid Id { get; init; }
    public required Guid UserId { get; init; }
    
    public required string StoragePath { get; init; } = string.Empty;
    public required string ContentType { get; init; } = string.Empty;
    
    public long Size { get; init; }
    
    public int Width { get; init; }
    public int Height { get; init; }
    
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;
    
    public ApplicationUser? User { get; init; }
}