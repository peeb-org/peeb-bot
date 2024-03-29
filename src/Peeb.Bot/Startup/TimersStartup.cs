using Microsoft.Extensions.DependencyInjection;
using Peeb.Bot.Timers;

namespace Peeb.Bot.Startup
{
    public static class TimersStartup
    {
        public static IServiceCollection AddTimers(this IServiceCollection services)
        {
            return services
                .AddTransient<IAsyncTimer, AsyncTimer>()
                .AddTransient<ITimer, TimerWrapper>();
        }
    }
}
