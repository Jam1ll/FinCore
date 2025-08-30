using FinCore.Core.Domain.Entities;
using FinCore.Core.Domain.Interfaces;
using FinCore.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace FinCore.Infrastructure.Persistence.Repositories
{
    public class CreditCardRepository : GenericRepository<CreditCard>, ICreditCardRepository
    {
        public CreditCardRepository(FinCoreContext context) : base(context) { }

        public async Task<CreditCard?> GetByCardNumberAsync(string cardNumber)
        {
            return await _context.CreditCards
                .FirstOrDefaultAsync(card => card.CardId == cardNumber);  // Cambiar 'CardNumber' por 'CardId'
        }

      
    }
}
