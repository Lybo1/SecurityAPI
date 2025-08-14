namespace SecurityApi.Models;

internal sealed class Team
{
    public required Guid Id { get; init; }
    public required Guid OrganizationId { get; init; }

    public required Organization Organization { get; init; }
    
    public required string Name { get; init; } = string.Empty;
}