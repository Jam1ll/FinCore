using FinCore.Core.Application.DTOs.SavingsAccount;
using FinCore.Core.Application.DTOs.Transaction;
using FinCore.Core.Domain.Entities;

namespace FinCore.Core.Application.Interfaces
{
    public interface ISavingsAccountService : IGenericService<SavingsAccountDTO>
    {
        Task<List<SavingsAccountDTO>> GetAllSavingsAccountsOfClients();
        public Task<string> GenerateUniqueAccountNumberAsync();
        Task CancelAsync(int id);
        Task TransferBalanceAndCancelAsync(int accountId);
        Task<SavingsAccountDTO?> GetByAccountNumberAsync(string beneficiaryAccountNumber);
        Task<List<DisplayTransactionDTO>> GetSavingAccountTransactionsAsync(string savingAccountId);


    }
}
