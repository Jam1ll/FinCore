using FinCore.Core.Domain.Interfaces;
using FinCore.Core.Domain.Entities;
using FinCore.Infrastructure.Persistence.Contexts;

namespace FinCore.Infrastructure.Persistence.Repositories
{
    public class AmortizationInstallmentRepository : GenericRepository<AmortizationInstallment>, IAmortizationInstallmentRepository
    {
        private readonly FinCoreContext _context;

        public AmortizationInstallmentRepository(FinCoreContext context) : base(context)
        {
            _context = context;
        }

        // Implementación de métodos adicionales para manejar cuotas de amortización, si es necesario
    }
}
