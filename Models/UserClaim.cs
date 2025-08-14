namespace SecurityApi.Models;

internal sealed class UserClaim
{
    public Guid Id { get; init; }
    public Guid UserId { get; init; }
    
    public string ClaimType { get; init; } = null!;
    public string ClaimValue { get; init; } = null!;

    public ApplicationUser? User { get; init; }
}