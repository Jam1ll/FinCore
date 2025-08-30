using FinCore.Infrastructure.Persistence.Contexts;
using FinCore.Core.Domain.Entities;
using FinCore.Core.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FinCore.Infrastructure.Persistence.Repositories
{
    public class CommerceRepository : ICommerceRepository
    {
        private readonly FinCoreContext _context;

        public CommerceRepository(FinCoreContext context)
        {
            _context = context;
        }

        // Obtener todos los comercios
        public async Task<List<Commerce>> GetAllCommercesAsync()
        {
            return await _context.Commerces.ToListAsync();
        }

        // Obtener un comercio por su ID
        public async Task<Commerce> GetCommerceByIdAsync(int commerceId)
        {
            return await _context.Commerces.FindAsync(commerceId);
        }

        // Crear un nuevo comercio
        public async Task AddCommerceAsync(Commerce commerce)
        {
            await _context.Commerces.AddAsync(commerce);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCommerceAsync(Commerce commerce)
        {
            var existingCommerce = await _context.Commerces
                .FirstOrDefaultAsync(c => c.Id == commerce.Id);
            if (existingCommerce != null)
            {
                existingCommerce.Name = commerce.Name;
                existingCommerce.Address = commerce.Address;
                existingCommerce.Phone = commerce.Phone;
                existingCommerce.Email = commerce.Email;
                existingCommerce.IsActive = commerce.IsActive;
                existingCommerce.UserId = commerce.UserId;  // Asegúrate de que UserId se actualice correctamente

                _context.Commerces.Update(existingCommerce);
                await _context.SaveChangesAsync();
            }
        }

        // Eliminar un comercio
        public async Task DeleteCommerceAsync(Commerce commerce)
        {
            _context.Commerces.Remove(commerce);
            await _context.SaveChangesAsync();
        }

        // Obtener comercios por condiciones específicas
        public async Task<List<Commerce>> GetCommercesByConditionAsync(Expression<Func<Commerce, bool>> expression)
        {
            return await _context.Commerces.Where(expression).ToListAsync();
        }

        // Obtener un comercio por su nombre y UserId
        public async Task<Commerce> GetCommerceByNameAndUserIdAsync(string name, string userId)
        {
            return await _context.Commerces
                                 .FirstOrDefaultAsync(c => c.Name == name && c.UserId == userId);
        }

        // Obtener un comercio por su UserId
        public async Task<Commerce> GetByUserIdAsync(string userId)
        {
            return await _context.Commerces.FirstOrDefaultAsync(c => c.UserId == userId);
        }

    }
}
