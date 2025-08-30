using FinCore.Core.Application.DTOs.Transaction;
using FinCore.Core.Application.DTOs.Transfer;

namespace FinCore.Core.Application.Interfaces
{
    public interface ITransactionService
    {
        Task<List<DisplayTransactionDTO>> GetClientServiceTransactionsAsync(string clientId);
        Task ExecuteExpressTransactionAsync(ExpressTransactionDTO dto);
        Task ProcessTransferAsync(TransferDTO dto);
        Task ExecutePayCreditCardTransactionAsync(PayCreditCardDTO dto);
        Task ExecutePayBeneficiaryTransactionAsync(PayBeneficiaryDTO dto);
        Task PerformTransactionAsync(TransactionRequestDto request);
        Task PayCreditCardAsync(DTOs.Transaction.CreditCardPaymentDto paymentDto);
        Task PayLoanAsync(DTOs.Transaction.LoanPaymentDto paymentDto);
        Task<List<TransactionDTO>> GetAllTransactionsAsync();
    }
}