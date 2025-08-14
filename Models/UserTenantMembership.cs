namespace SecurityApi.Models;

internal sealed class UserTenantMembership
{
    public required Guid Id { get; init; }
    public required Guid UserId { get; init; }
    public required Guid TenantId { get; init; }
    
    public required ApplicationUser User { get; init; }
    public required Tenant Tenant { get; init; }
    
    public ICollection<UserClaim> TenantClaims { get; internal set; } = new HashSet<UserClaim>();
}