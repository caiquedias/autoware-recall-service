using Autoware.Recall.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Autoware.Recall.UnitTest
{
    public class DbFixture
    {
        public DbFixture()
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", false, true)
                .Build();

            var serviceCollection = new ServiceCollection();
            serviceCollection
                .AddDbContext<RecallContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")),
                    ServiceLifetime.Transient);

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }

        public IConfiguration Configuration { get; }
        public ServiceProvider ServiceProvider { get; private set; }
    }
}
