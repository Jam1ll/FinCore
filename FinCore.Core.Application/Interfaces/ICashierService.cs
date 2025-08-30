using FinCore.Core.Application.DTOs.Loan;
using FinCore.Core.Application.ViewModels.Cashier;
using FinCore.Core.Domain.Entities;

namespace FinCore.Core.Application.Interfaces
{
    public interface ICashierService
    {
        Task<bool> MakeDepositAsync(string accountNumber, decimal amount, string cashierId);
        Task<bool> MakeWithdrawAsync(string accountNumber, decimal amount, string cashierId);
        Task<bool> MakeThirdPartyTransferAsync(string sourceAccountNumber, string destinationAccountNumber, decimal amount, string cashierId);

        Task<bool> MakeCreditCardPaymentAsync(string accountNumber, string cardNumber, decimal amount, string cashierId);
        Task<bool> MakeLoanPaymentAsync(DTOs.Cashier.LoanPaymentByCashierDto paymentDto);


        Task<SavingsAccount?> GetSavingsAccountByNumber(string accountNumber);
        Task<(SavingsAccount? account, CreditCard? card, string? clientFullName)> GetAccountCardAndClientNameAsync(string accountNumber, string cardNumber);
        Task<(SavingsAccount? account, string? clientFullName)> GetAccountWithClientNameAsync(string accountNumber);
        Task<(LoanDTO? loan, string clientFullName, decimal remainingDebt)> GetLoanInfoAsync(string loanIdentifier);
        Task<CashierDashboardViewModel> GetTodaySummaryAsync(string cashierId);



        Task<List<SavingsAccount>> GetAllSavingsAccountsOfClients(string clientId);


    }
}
