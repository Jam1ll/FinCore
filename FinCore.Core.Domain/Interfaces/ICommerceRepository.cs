using FinCore.Core.Domain.Entities;
using System.Linq.Expressions;

namespace FinCore.Core.Domain.Interfaces
{
    public interface ICommerceRepository
    {
        Task<List<Commerce>> GetAllCommercesAsync();
        Task<Commerce> GetCommerceByIdAsync(int commerceId);
        Task AddCommerceAsync(Commerce commerce);
        Task UpdateCommerceAsync(Commerce commerce);
        Task DeleteCommerceAsync(Commerce commerce);
        Task<List<Commerce>> GetCommercesByConditionAsync(Expression<Func<Commerce, bool>> expression);

        Task<Commerce> GetCommerceByNameAndUserIdAsync(string name, string userId);

        Task<Commerce> GetByUserIdAsync(string userId);

    }
}
