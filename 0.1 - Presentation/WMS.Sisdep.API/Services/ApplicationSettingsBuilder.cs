namespace WMS.Sisdep.API.Services
{
    public static class WebApplicationBuilder
    {
        public static IHostBuilder ConfigureAppSettings(this IHostBuilder host)
        {
            host.ConfigureAppConfiguration((ctx, builder) =>
            {
                builder.AddJsonFile("appsettings.LOCAL.json", false, true);
                builder.AddEnvironmentVariables();
            });
            return host;
        }
    }
}
