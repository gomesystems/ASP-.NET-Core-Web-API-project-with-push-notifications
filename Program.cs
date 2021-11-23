using APIpushnotifications.Web;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ASP_.NET_Core_Web_API_project_with_push_notifications
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
