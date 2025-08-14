using SecurityApi.Shared.Enums;

namespace SecurityApi.Models;

internal sealed class Tenant
{
    public Guid Id { get; init; }
    
    public required string Name { get; init; } = string.Empty;
    
    public required TenantType Type { get; init; }

    public ICollection<Organization> Organizations = new HashSet<Organization>();
    public ICollection<UserTenantMembership> Memberships = new HashSet<UserTenantMembership>();
}