using Autoware.Recall.Api.Application.Interfaces;
using Autoware.Recall.Api.Application.Services;
using Autoware.Recall.Domain;
using Autoware.Recall.Domain.AggregatesModel.RecallAggregate.Interfaces;
using Autoware.Recall.Infrastructure.Repositories;
using Autoware.Recall.Infrastructure.Services;

namespace Autoware.Recall.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddScoped<IChassiRepository, ChassiRepository>();
            services.AddScoped<IRecallRepository, RecallRepository>();
            services.AddScoped<IChassiRecallRepository, ChassiRecallRepository>();
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient(typeof(IGenericApplicationService<>), typeof(GenericApplicationService<>));
            services.AddScoped<IChassiApplicationService, ChassiApplicationService>();
            services.AddScoped<IRecallApplicationService, RecallApplicationService>();
            services.AddScoped<IChassiRecallApplicationService, ChassiRecallApplicationService>();
        }
    }
}
