using GameFlow.Repository.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GameFlow.Repository;

public static class RepositoryDependencyInjection
{
    public static IServiceCollection AddRepositoryServices(this IServiceCollection services)
    {
        services.AddScoped<IGameRepository, GameRepository>();
        services.AddScoped<IGenreRepository,GenreRepository>();
        services.AddScoped<IPlatformRepository, PlatformRepository>();

        return services;
    }
}
