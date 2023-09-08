using ScrumTeamUi.Models;

namespace ScrumTeamUi.Services;

public sealed class DepartmentService
{
    public async Task<IReadOnlyCollection<Department>> GetDepartments()
    {
        return new List<Department>();
    }
}