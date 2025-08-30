using FinCore.Core.Domain.Entities;

namespace FinCore.Core.Domain.Interfaces
{
    public interface ICreditCardRepository : IGenericRepository<CreditCard>
    {
        Task<CreditCard?> GetByCardNumberAsync(string cardNumber);


    }
}
