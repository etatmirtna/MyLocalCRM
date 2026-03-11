using System;
using Microsoft.Extensions.DependencyInjection;
using DataService.Repositories;

namespace DataService
{
    public static class DataServiceExtensions
    {
        public static IServiceCollection AddCrmDataServices(this IServiceCollection services, string sqlConnectionString)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            if (string.IsNullOrWhiteSpace(sqlConnectionString)) throw new ArgumentException("Connection string is required", nameof(sqlConnectionString));

            services.AddSingleton<IDbConnectionFactory>(sp => new SqlConnectionFactory(sqlConnectionString));
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IActionRepository, ActionRepository>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<ILeadRepository, LeadRepository>();
            services.AddTransient<ICalendarRepository, CalendarRepository>();
            services.AddTransient<IEmailRepository, EmailRepository>();
            services.AddTransient<IPhoneCallRepository, PhoneCallRepository>();
            services.AddTransient<IChatRepository, ChatRepository>();
            services.AddTransient<IUserRepository, UserRepository>();

            return services;
        }
    }
}
