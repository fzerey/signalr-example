using System;

namespace SignalRServer
{
    public static class Module
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddSignalR();
            return services;
        }
    }
}
