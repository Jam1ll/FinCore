using FinCore.Infrastructure.Persistence.Contexts;
using FinCore.Core.Domain.Interfaces;
using FinCore.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FinCore.Core.Application.Interfaces;

namespace FinCore.Infrastructure.Persistence
{
    public static class ServicesRegistration
    {
        public static void AddPersistenceLayerIoc(this IServiceCollection services, IConfiguration config)
        {
            #region contexts
            if (config.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<FinCoreContext>(opt =>
                                              opt.UseInMemoryDatabase("AppDb"));
            }
            else
            {
                var connectionString = config.GetConnectionString("DefaultConnection");
                services.AddDbContext<FinCoreContext>(
                    (serviceProvider, opt) =>
                    {
                        opt.EnableSensitiveDataLogging();
                        opt.UseSqlServer(connectionString,
                        m => m.MigrationsAssembly(typeof(FinCoreContext).Assembly.FullName));
                    },
                    contextLifetime: ServiceLifetime.Scoped,
                    optionsLifetime: ServiceLifetime.Scoped
                    );
                #endregion

                #region repositories IOC
                services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
                services.AddScoped<ISavingsAccountRepository, SavingsAccountRepository>();
                services.AddScoped<ITransactionRepository, TransactionRepository>();
                services.AddScoped<ICreditCardRepository, CreditCardRepository>();
                services.AddScoped<ILoanRepository, LoanRepository>();
                services.AddScoped<IAmortizationInstallmentRepository, AmortizationLInstallmentRepository>();
                services.AddScoped<IBeneficiaryRepository, BeneficiaryRepository>();
                services.AddScoped<ICommerceRepository, CommerceRepository>();
                services.AddScoped<IUnitOfWork, UnitOfWork>();
                #endregion
            }
        }
    }
}