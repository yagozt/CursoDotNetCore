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

                await next.Invoke();
                await context.Response.WriteAsync("Bem vindo 1");
            });

            app.Use(async (context, next) => {

                await next.Invoke();

                await context.Response.WriteAsync("Bem vindo 2");
            });

            // A ordem dos middlewares são importantes
        }
}