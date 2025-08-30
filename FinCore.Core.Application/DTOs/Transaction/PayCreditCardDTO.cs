namespace FinCore.Core.Application.DTOs.Transaction
{
    public class PayCreditCardDTO
    {
        public string FromAccountNumber { get; set; }
        public string CreditCardNumber { get; set; }
        public decimal Amount { get; set; }
        public int? SavingsAccountId { get; set; }

    }
}
