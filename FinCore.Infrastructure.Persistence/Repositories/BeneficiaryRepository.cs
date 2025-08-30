using FinCore.Core.Domain.Entities;
using FinCore.Core.Domain.Interfaces;
using FinCore.Infrastructure.Persistence.Contexts;

namespace FinCore.Infrastructure.Persistence.Repositories
{
    public class BeneficiaryRepository : GenericRepository<Beneficiary>, IBeneficiaryRepository
    {
        public BeneficiaryRepository(FinCoreContext context) : base(context)
        {
        }

        // Método que utiliza GetByConditionAsync para obtener beneficiarios por ClientId
        public async Task<List<Beneficiary>> GetBeneficiariesByClientIdAsync(string clientId)
        {
            return (List<Beneficiary>)await GetByConditionAsync(b => b.ClientId == clientId);
        }


    }
}
