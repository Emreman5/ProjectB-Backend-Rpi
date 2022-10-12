using Microsoft.EntityFrameworkCore;
using RpiServerAPI.DataAccess;

namespace RpiServerAPI.Extensions;

public static class DatabaseRegistration
{
    public static IServiceCollection AddMySqlService(this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<DataContext>(builder => builder.UseMySql(connectionString, 
            ServerVersion.AutoDetect(connectionString)));
        return services;
    }
}