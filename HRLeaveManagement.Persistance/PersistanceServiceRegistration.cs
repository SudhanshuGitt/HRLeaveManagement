using HRLeaveManagement.Application.Contracts.Persistance;
using HRLeaveManagement.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLeaveManagement.Persistance
{
    public static class PersistanceServiceRegistration
    {

        public static IServiceCollection ConfigurePersistanceServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<HRLeaveManagementDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("LeaveManagementConnectionString"))
            );

            services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));

            services.AddScoped<ILeaveAllocationRepository, LeaveAllocationRepository>();
            services.AddScoped<ILeaveTypeRepository, LeaveTypeRepositoy>();
            services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();

            return services;
        }

    }
}
