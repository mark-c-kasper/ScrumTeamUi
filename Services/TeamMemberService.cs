using ScrumTeamUi.Models;

namespace ScrumTeamUi.Services;

public sealed class TeamMemberService
{
    public async Task<IReadOnlyCollection<TeamMember>> GetTeamMembers()
    {
        return await Task.FromResult(new List<TeamMember>());
    }
}