using FinCore.Core.Application.DTOs.CreditCard;
using FinCore.Core.Application.DTOs.Loan;
using FinCore.Core.Application.DTOs.SavingsAccount;
using FinCore.Core.Application.DTOs.User;
using FinCore.Core.Application.ViewModels.Loan;
using FinCore.Core.Domain.Entities; // Make sure this is included for Loan entity

namespace FinCore.Core.Application.Interfaces
{
    public interface IAccountServiceForWebApp : IBaseAccountService
    {
        Task<List<SavingsAccountDTO>> GetSavingsAccountsByUserIdAsync(string userId);
        Task<List<CreditCardDTO>> GetCreditCardsByUserIdAsync(string userId);
        Task<List<LoanDTO>> GetLoansByUserIdAsync(string userId);
        Task<LoginResponseDto> AuthenticateAsync(LoginDto loginDto);
        Task SignOutAsync();
        Task<UserDto?> GetUserById(string userId);
        Task<string?> GetUserEmailAsync(string userId);
        Task<string> GetUserFullNameAsync(string userId);
        Task<List<ClientSelectionViewModel>> GetClientDetailsForLoanAssignment(string? cedula);
        Task UpdateSavingsAccountBalance(string clientId, decimal amount);
        Task<UserDto?> GetUserByIdentificationNumber(string identificationNumber);
        Task<string?> GetSavingsAccountHolderFullNameAsync(string accountNumber);
        Task<string?> GetSavingsAccountHolderEmailAsync(string accountNumber);
        Task<Loan?> GetLoanInfoAsync(string loanIdentifier);
        Task<IEnumerable<SavingsAccount>> GetActiveAccountsAsync(string clientId);
        Task<CreditCard?> GetCreditCardByNumberAsync(string cardNumber);
        Task<SavingsAccount?> GetSavingsAccountByNumberAsync(string accountNumber);
        Task<string> GetUserEmailByClientIdAsync(string clientId);
        Task UpdateAsync(SavingsAccount account);
    }
}