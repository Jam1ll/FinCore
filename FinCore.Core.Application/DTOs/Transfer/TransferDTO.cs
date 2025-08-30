namespace FinCore.Core.Application.DTOs.Transfer
{
    public class TransferDTO
    {
        public int SourceAccountId { get; set; }
        public int DestinationAccountId { get; set; }
        public decimal Amount { get; set; }
    }
}