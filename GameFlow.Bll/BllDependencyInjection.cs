using GameFlow.Bll.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GameFlow.Bll;

public static class BllDependencyInjection
{
    public static IServiceCollection AddBllServices(this IServiceCollection services)
    {
        services.AddScoped<IGameService, GameService>();
        services.AddScoped<IPlatformService, PlatformService>();
        services.AddScoped<IGenreService, GenreService>();

        return services;
    }
}
