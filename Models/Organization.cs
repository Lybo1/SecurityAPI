namespace SecurityApi.Models;

internal sealed class Organization
{
    public required Guid Id { get; init; }
    public required Guid TenantId { get; init; }
    
    public required string Name { get; init; } = string.Empty;
    
    public required ICollection<Tenant> Tenants { get; set; } = new HashSet<Tenant>();
    public ICollection<Team> Teams { get; set; } = new HashSet<Team>();
}