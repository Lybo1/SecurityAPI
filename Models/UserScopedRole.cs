using Microsoft.AspNetCore.Identity;

namespace SecurityApi.Models;

internal sealed class UserScopedRole
{
    public required Guid Id { get; init; }
    public required Guid UserId { get; init; }
    public required Guid TenantId { get; init; }
    
    public Guid? OrganizationId { get; init; }
    public Guid? TeamId { get; init; }
    
    public required ApplicationUser User { get; init; }
    
    public required Tenant Tenant { get; init; }
    
    public Organization? Organization { get; init; }
    public Team? Team { get; init; }
    
    public required IdentityRole Role { get; init; }
}