using ApiProject.Core.Repositories;
using ApiProject.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ApiProject.DAL;

public static class ServiceRegistration
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IAssignmentRepository, AssignmentRepository>();
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();

        return services;
    }
}
