using FastForwardSC.API.Settings;
using FastForwardSC.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ManagerAPI.Startup
{
    public static class ConfigureOtherAssemblies
    {
        public static void ConfigureMicroservices(this IServiceCollection services, WebApplicationBuilder builder)
        {

            #region  Register Database

            //Registering a normal SQLServer (PostegreSQL in this case) database
            var serviceCollection = services.BuildServiceProvider();

            var databaseSettings = serviceCollection
               .GetRequiredService<IOptions<DatabaseSettings>>();

            builder.Services.AddDbContext<ShoppingContext>(options =>
                options.UseSqlServer(databaseSettings.Value.ConnectionString));

            #endregion  Register Database

            // Register All AutoMapper Profiles
            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfiles(EventMicroservice.Mapping.MappingConfiguration.GetMappingProfile());
                cfg.AddProfiles(ProductMicroservice.Mapping.MappingConfiguration.GetMappingProfile());
                cfg.AddProfiles(PromotionMicroservice.Mapping.MappingConfiguration.GetMappingProfile());
                cfg.AddProfiles(RatingMicroservice.Mapping.MappingConfiguration.GetMappingProfile());
                cfg.AddProfiles(StoreMicroservice.Mapping.MappingConfiguration.GetMappingProfile());
                cfg.AddProfiles(UserMicroservice.Mapping.MappingConfiguration.GetMappingProfile());
            });



            #region Authorization Configuration
            //Add Authorization
            //services.AddAuthorization();
            #endregion Authorization Configuration


        }
    }
}
