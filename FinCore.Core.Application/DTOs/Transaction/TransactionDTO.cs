using FinCore.Core.Domain.Common.Enums;
using FinCore.Core.Application.DTOs.Commerce;

namespace FinCore.Core.Application.DTOs.Transaction
{
    public class TransactionDTO
    {
        public int Id { get; set; } // Must be present for mapping from entity
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; } // Matches entity
        public TransactionType? TransactionType { get; set; } // Matches entity
        public CommerceDTO? Commerce { get; set; }

        public string SourceAccountId { get; set; } = string.Empty;
        public string? DestinationAccountId { get; set; }
        public string? DestinationCardId { get; set; }
        public string? CreditCardId { get; set; }
        public int? DestinationLoanId { get; set; }
        public string? Description { get; set; } // Matches entity
        public int SavingsAccountId { get;set; }
        public string Type { get; set; }
        public string Origin { get;  set; }
        public string Beneficiary { get;  set; }
        public string CashierId { get;  set; }
        public DateTime Date { get;  set; }
        public Status? Status { get; set; }
    }
}