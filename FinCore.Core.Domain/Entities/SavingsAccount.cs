using FinCore.Core.Domain.Common.Enums;

namespace FinCore.Core.Domain.Entities
{
    public class SavingsAccount
    {
        //main info
        public int Id { get; set; }
        public required string AccountNumber { get; set; }
        public required decimal Balance { get; set; }
        public required AccountType AccountType { get; set; }
        public required bool IsActive { get; set; }

        //additional info
        public required DateTime CreatedAt { get; set; }
        public required string ClientId { get; set; }
        public required string ClientFullName { get; set; }

        //only for secondary accounts info
        public string? CreatedByAdminId { get; set; }
        public string? AdminFullName { get; set; }
    }
}
