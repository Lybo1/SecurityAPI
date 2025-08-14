namespace SecurityApi.Models;

internal sealed class ApplicationUser
{
    public required Guid Id { get; init; }
    
    public required string UserName { get; init; } = string.Empty;
    public required string NormalizedUserName { get; init; } = string.Empty;
    
    public required string PasswordHash { get; internal set; }
    public required string PasswordSalt { get; internal set; }
    
    public required string Email { get; init; } = string.Empty;
    public required string NormalizedEmail { get; init; } = string.Empty;

    public bool EmailConfirmed { get; internal set; }
    
    public string? SecondaryEmail { get; set; } = string.Empty;
    
    public Guid SecurityStamp { get; internal set; }

    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? LastLoginAt { get; internal set; }
    
    public bool IsLockedOut { get; internal set; }
    public DateTimeOffset? LockoutEnd { get; internal set; }
    
    public bool RememberMe { get; internal set; } = false;
    
    public UserPhoto? UserPhoto { get; internal set; }
    
    public ICollection<UserClaim> Claims { get; internal set; } = new HashSet<UserClaim>();
    public ICollection<UserTenantMembership> TenantMemberships { get; internal set; } = new HashSet<UserTenantMembership>();

}