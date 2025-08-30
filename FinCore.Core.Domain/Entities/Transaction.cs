using FinCore.Core.Domain.Common.Enums;

namespace FinCore.Core.Domain.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public string? SavingsAccountId { get; set; } 
        public decimal Amount { get; set; }
        public string? Type { get; set; }
        public string? Origin { get; set; }
        public string? Beneficiary { get; set; }
        public DateTime? Date { get; set; }
        public string? CashierId { get; set; }
        public string? SourceAccountId { get; set; }
        public string? DestinationAccountId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public int? DestinationLoanId { get; set; }
        public TransactionType? TransactionType { get; set; }
        public string? Description { get; set; }
        public string? DestinationCardId { get; set; }
        public Status? Status { get; set; }
        public string? CreditCardId { get; set; }
        public int? CommerceId { get; set; }
        public Transaction() { }
    }
}