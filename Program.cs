using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.IO;

namespace NETCoreWebJobs
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new HostBuilder();
            builder.ConfigureWebJobs(b =>
            {
                b.AddAzureStorageCoreServices();
                b.AddAzureStorage();
            });
            builder.ConfigureLogging((context, b) =>
            {
                b.AddConsole();
            });
            var host = builder.Build();
            using (host)
            {
                host.Run();
            }
        }

        //private static void SetupConfiguration(IConfigurationBuilder builder)
        //{
        //    Configuration = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        //        .AddEnvironmentVariables()
        //        .Build();
        //}

        //private static void ConfigureServices(IServiceCollection services)
        //{
        //    //services.AddDbContext<RaizenDBContext>(options =>
        //    //{
        //    //    options.UseSqlServer(Configuration.GetConnectionString("RaizenResgateFacilDB"));
        //    //});

        //    //services.Configure<JwtAuthenticationOptions>(Configuration.GetSection("Authentication:Jwt"));

        //    //services.AddSingleton(Configuration);
        //    //services.AddTransient<IEventNotificationRepository, EventNotificationRepository>();
        //    //services.AddTransient<IEventNotificationService, EventNotificationService>();
        //}
    }
}
