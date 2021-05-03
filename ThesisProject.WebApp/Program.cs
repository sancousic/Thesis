using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.Data;

namespace ThesisProject.WebApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            try
            {
                var host = CreateHostBuilder(args).Build();

                using var serviceScope = host.Services.CreateScope();
                try
                {
                    var services = serviceScope.ServiceProvider;
                    var dbContecxt = services.GetRequiredService<AppDbContext>();
                    await dbContecxt.Database.MigrateAsync();
                    await InitDb.Initialize(services);
                }
                catch(Exception ex)
                {
                    logger.Error(ex,  "An error occurred while seeding the database.");
                    throw;
                }

                await host.RunAsync();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Stopped program because of exception");
                throw;
            }
            finally
            {
                NLog.LogManager.Shutdown();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.SetMinimumLevel(LogLevel.Trace);
                })
                
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .UseNLog();
               
            
        
            
    }
}
