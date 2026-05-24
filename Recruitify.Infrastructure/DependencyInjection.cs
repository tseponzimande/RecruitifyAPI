namespace Recruitify.Infrastructure;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<RecruitifyDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("Database"),
                b => b.MigrationsAssembly(typeof(RecruitifyDbContext).Assembly.FullName)
            ));

        services.AddScoped<IApplicationDbContext>(provider =>
            provider.GetRequiredService<RecruitifyDbContext>());

        return services;
    }
}