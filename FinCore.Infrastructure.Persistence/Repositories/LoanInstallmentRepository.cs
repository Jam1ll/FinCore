using FinCore.Infrastructure.Persistence.Contexts;
using FinCore.Core.Domain.Entities;
using FinCore.Core.Domain.Interfaces;

namespace FinCore.Infrastructure.Persistence.Repositories
{
    public class AmortizationLInstallmentRepository : GenericRepository<AmortizationInstallment>, IAmortizationInstallmentRepository
    {
        public AmortizationLInstallmentRepository(FinCoreContext context) : base(context)
        {
        }
    }
}
