using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

public class Startup
{
    private readonly IConfiguration _config;

    public Startup(IConfiguration configuration)
    {
        _config = configuration;
    }

    public void Configure(IApplicationBuilder app)
        {
            app.Use(async (context, next) => {
                await context.Response.WriteAsync("Trabalhando com classe Startup");
            });
        }
}