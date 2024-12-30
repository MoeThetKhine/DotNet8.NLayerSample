namespace PresentationLayer.Services;

public static class ModularService
{
    #region AddServices

    public static IServiceCollection AddServices(this IServiceCollection services, WebApplicationBuilder builder)
    {
        services.AddDbContextService(builder);
        services.AddBusinessLogicServices();
        services.AddDataAccessServices();
        services.AddJsonServices();
        return services;
    }

    #endregion

    #region AddDbContextService

    private static IServiceCollection AddDbContextService(this IServiceCollection services, WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<AppDbContext>(opt =>
        {
            opt.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
        }, ServiceLifetime.Transient);
        return services;
    }

    #endregion

    private static IServiceCollection AddBusinessLogicServices(this IServiceCollection services)
    {
        services.AddScoped<BL_Blog>();
        return services;
    }
    private static IServiceCollection AddDataAccessServices(this IServiceCollection services)
    {
        services.AddScoped<DA_Blog>();
        return services;
    }
    private static IServiceCollection AddJsonServices(this IServiceCollection services)
    {
        services.AddControllers().AddJsonOptions(opt =>
        {
            opt.JsonSerializerOptions.PropertyNamingPolicy = null;
        });
        return services;
    }
}