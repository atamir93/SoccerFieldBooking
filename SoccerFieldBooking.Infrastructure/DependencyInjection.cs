using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SoccerFieldBooking.Domain.Repositories;
using SoccerFieldBooking.Infrastructure.Repositories;

namespace SoccerFieldBooking.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastrucutre(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<IFieldRepository, FieldRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IContactPersonRepository, ContactPersonRepository>();
        }
    }
}
