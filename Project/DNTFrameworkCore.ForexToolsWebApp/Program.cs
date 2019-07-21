using DNTFrameworkCore.ForexToolsWebApp.Infrastructure.Context;
using DNTFrameworkCore.Web.EFCore;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace DNTFrameworkCore.ForexToolsWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build()
                .MigrateDbContext<ProjectDbContext>()
                .Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}