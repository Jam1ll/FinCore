using System.ComponentModel.DataAnnotations;

namespace FinCore.Core.Application.DTOs.User
{
    public class ForgotPasswordWithTokenDto
    {
        [Required]
        public string UserName { get; set; } = null!;
    }

}
