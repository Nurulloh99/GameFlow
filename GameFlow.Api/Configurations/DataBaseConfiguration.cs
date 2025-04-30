using GameFlow.Dal;
using Microsoft.EntityFrameworkCore;

namespace Instagram.Server.Configurations;

public static class DataBaseConfiguration
{
    public static void ConfigureDatabase(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("DataBaseConnection");
        builder.Services.AddDbContext<MainContext>(options =>
                 options.UseSqlServer(connectionString));
    }
}
