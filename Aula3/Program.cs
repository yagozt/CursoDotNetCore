using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Aula3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // var host = new WebHostBuilder()
            // .UseKestrel()
            // .UseStartup<Startup>()
            // .Build();
            // host.Run();
            BuildWebHost(args).Run();
        }
        public static IWebHost BuildWebHost(string[] args) => 
                                                    WebHost.CreateDefaultBuilder(args)
                                                    .UseStartup<Startup>()
                                                    .Build();
    }
    // internal class Startup
    // {
    //     public void Configure(IApplicationBuilder app)
    //     {
    //         app.Use(async (context, next) => {
    //             await context.Response.WriteAsync("Trabalhando com classe Startup");
    //         });
    //     }
    // }
}
