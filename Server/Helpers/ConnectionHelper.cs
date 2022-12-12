namespace DotnetDevs.Server.Helpers
{
    public static class ConnectionHelper
    {
        public static string GetConnectionString(WebApplicationBuilder builder)
        {
            return Environment.GetEnvironmentVariable("CONNECTION_STRING");
        }
    }
}
