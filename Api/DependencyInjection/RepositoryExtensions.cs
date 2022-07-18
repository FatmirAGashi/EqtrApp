using EqtrApp.DataAccess.Repositories.Abstractions;
using EqtrApp.DataAccess.Repositories.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EqtrApp.Api.DependencyInjection
{
    public static class RepositoryExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<ICitizenRepository, CitizenRepository>();
        }
    }
}
