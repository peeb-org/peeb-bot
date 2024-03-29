using Microsoft.Extensions.Hosting;
using Peeb.Bot.Startup;

namespace Peeb.Bot
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((c, s) => s
                    .AddAutoMapper()
                    .AddDatabase(c.Configuration)
                    .AddDiscord(c.Configuration)
                    .AddHostedServices()
                    .AddMediatR()
                    .AddServices()
                    .AddTimers()
                    .AddXivApi(c.Configuration));
    }
}
