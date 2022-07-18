
using EqtrApp.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EqtrApp.Api.DependencyInjection
{
    public static class AddEntityFrameworkExtension
    {
        public static void AddEntitySqlServer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EqtrContext>(options =>
                        options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
