using EqtrApp.Services.Abtractions;
using EqtrApp.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EqtrApp.Api.DependencyInjection
{
    public static class DomainServiceExtensions
    {
     
            public static void AddServices(this IServiceCollection services)
            {
                services.AddTransient<ICitizenService, CitizensServices>();
            }
       
    }
}
