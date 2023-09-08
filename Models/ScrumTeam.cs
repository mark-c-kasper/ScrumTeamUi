namespace ScrumTeamUi.Models;

public class ScrumTeam
{
    public Guid Id { get; init; }

    public string Name { get; init; }

    public Guid OrganizationId { get; set; }
}