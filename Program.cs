using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ScrumTeamUi;
using ScrumTeamUi.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});

builder.Services.AddSingleton<ScrumOrganizationService>();
builder.Services.AddSingleton<TeamMemberService>();
builder.Services.AddSingleton<DepartmentService>();
builder.Services.AddSingleton<ScrumTeamService>();

await builder.Build().RunAsync();