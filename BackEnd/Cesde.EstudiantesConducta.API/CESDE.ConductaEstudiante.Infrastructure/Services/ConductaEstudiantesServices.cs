using CESDE.ConductaEstudiante.Application.Interfaces;
using CESDE.ConductaEstudiante.Infrastructure.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace CESDE.ConductaEstudiante.Infrastructure.Services
{
    public static class ConductaEstudiantesServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration) 
        {

            services.AddDbContext<RegistroConductaEstudiantesContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Estudiante"));
            });

            services.AddScoped<IApplicationDbcontexts, RegistroConductaEstudiantesContext>();

            return services;

        }
    }
}
