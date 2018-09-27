using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StoreOfBuild.Domain;
using StoreOfBuild.Data;
using StoreOfBuild.Domain.Products;
using StoreOfBuild.Data.Contexts;
using StoreOfBuild.Data.Repositores;

namespace StoreOfBuild.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(options => 
                options.UseSqlServer(connectionString));
            services.AddScoped(typeof(IRepository<Product>), typeof(ProductRepository));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(CategoryStorer));
            services.AddScoped(typeof(ProductStorer));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
        }
    }
}
