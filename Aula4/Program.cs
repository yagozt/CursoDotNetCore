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
            BuildWebHost(args).Run();
        }
        public static IWebHost BuildWebHost(string[] args) => 
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }

}
