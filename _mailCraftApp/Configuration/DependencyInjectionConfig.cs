namespace _mailCraftApp.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
                                                                  IConfiguration configuration)
        {
            services.AddSingleton(configuration);


            return services;
        }
    }
}
