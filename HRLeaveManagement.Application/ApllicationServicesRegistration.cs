using HRLeaveManagement.Application.Profiles;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace HRLeaveManagement.Application
{
    public static class ApllicationServicesRegistration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {
            // it will traverse to every mapping profile that has inheritance 
            services.AddAutoMapper(cfg =>
            {
                //cfg.AddProfile(new MyAutoMapperProfile());
                cfg.AddMaps(typeof(MappingProfile).Assembly);
            });

            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
            });

            return services;
        }
    }
}

/// to permote losse coupling to our application 

// Mediatr pattern allow us to define how object interact with each other

// Cqrs(command and query responsibility seggregation) seprate read and write operation from any data store

// command is something which will agument the data write operation update operation
// query is reading the data 


// query or command is handled by handlers 
// handler is going to be either a command to agument the data 
// or something to return data