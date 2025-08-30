using Microsoft.AspNetCore.Identity;

namespace FinCore.Infrastructure.Identity.Entities
{
    public class AppUser : IdentityUser
    {
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public required string UserId { get; set; }
        public decimal? InitialAmount { get; set; }
        public required bool IsActive { get; set; }
        public string? CommerceId { get; set; }
    }
}
