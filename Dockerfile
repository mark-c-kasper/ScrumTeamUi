FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ScrumTeamUi/ScrumTeamUi.csproj", "ScrumTeamUi/"]
RUN dotnet restore "ScrumTeamUi/ScrumTeamUi.csproj"
COPY . .
WORKDIR "/src/ScrumTeamUi"
RUN dotnet build "ScrumTeamUi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ScrumTeamUi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ScrumTeamUi.dll"]
