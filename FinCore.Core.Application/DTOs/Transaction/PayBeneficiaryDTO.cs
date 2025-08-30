using FinCore.Core.Application.DTOs.Beneficiary;
using FinCore.Core.Application.DTOs.SavingsAccount;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FinCore.Core.Application.DTOs.Transaction
{
    public class PayBeneficiaryDTO
    {
        [Required(ErrorMessage = "El beneficiario es obligatorio.")]
        [DisplayName("Seleccionar Beneficiario")]
        public int BeneficiaryId { get; set; }

        [Required(ErrorMessage = "La cuenta de origen es obligatoria.")]
        [DisplayName("Cuenta de Origen")]
        public string SourceAccountNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "El monto es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El monto debe ser mayor que cero.")]
        [DisplayName("Monto")]
        public decimal Amount { get; set; }

        [DisplayName("Descripción")]
        [StringLength(500, ErrorMessage = "La descripción no puede exceder los 500 caracteres.")]
        public string? Description { get; set; }

        public List<SavingsAccountDTO> AvailableAccounts { get; set; } = new List<SavingsAccountDTO>();
        public List<BeneficiaryDTO> AvailableBeneficiaries { get; set; } = new List<BeneficiaryDTO>();
    }
}