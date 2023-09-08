using ScrumTeamUi.Models;

namespace ScrumTeamUi.Services;

public sealed class ScrumOrganizationService
{
    
    public async Task<IReadOnlyCollection<Organization>> GetOrganizations()
    {
        Organization organization = new Organization
        {
            Id = Guid.NewGuid(),
            Name = "Test Organization via hard-code"
        };
        return await Task.FromResult(new List<Organization>{organization});
    }
}