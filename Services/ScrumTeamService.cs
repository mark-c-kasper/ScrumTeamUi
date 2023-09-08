using ScrumTeamUi.Models;

namespace ScrumTeamUi.Services;

public sealed class ScrumTeamService
{
    public async Task<IReadOnlyCollection<ScrumTeam>> GetScrumTeams()
    {
        return await Task.FromResult(new List<ScrumTeam>());
    }
}