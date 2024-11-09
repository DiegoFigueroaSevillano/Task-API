using System.Data.Common;
using Task_Project.DataBase;
using Task_Project.Repository;
using Task_Project.Service;
using Task = Task_Project.Domain.Task;

namespace Task_Project.DependencyInjection;

public static class DependencyInjection
{

    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        services.AddDatabase().AddRepositories().AddServices();
        return services;
    }

    private static IServiceCollection AddDatabase(this IServiceCollection services)
    {
        services.AddScoped<IDbConnection<List<Domain.Task>>, DbLocalConnection>();
        return services;
    }
    
    private static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<ITaskRepository, TaskRepository>();
        return services;
    }
    
    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<ITaskService, TaskService>();
        return services;
    }
}