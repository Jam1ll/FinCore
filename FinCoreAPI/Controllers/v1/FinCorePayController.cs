using FinCore.Core.Application.DTOs.HermesPay;
using FinCore.Core.Application.Interfaces;
using FinCore.Core.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Transactions;

namespace FinCoreAPI.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class FinCorePayController : ControllerBase
    {
        private readonly IFinCorePayService _finCorePayService;
        private readonly ITransactionRepository _transactionRepository;

        public FinCorePayController(IFinCorePayService finCorePayService, ITransactionRepository transactionRepository)
        {
            _finCorePayService = finCorePayService;
            _transactionRepository = transactionRepository;
        }

        [HttpGet("get-transactions/{commerceId}")]
        public async Task<IActionResult> GetTransactionsByCommerceAsync(int commerceId, int page = 1, int pageSize = 20)
        {
            var skip = (page - 1) * pageSize;

            var filtered = await _transactionRepository
                .GetByConditionAsync(t => t.CommerceId == commerceId);

            var paged = filtered
                .OrderByDescending(t => t.TransactionDate)
                .Skip(skip)
                .Take(pageSize)
                .ToList();

            return Ok(paged); // ✔️ ahora encaja con IActionResult
        }





        /// <summary>
        /// Endpoint para que un comercio realice un consumo con tarjeta.
        /// </summary>
        /// <param name="request">Contiene número de tarjeta, monto y comercioId</param>
        /// <returns>Resultado del procesamiento del pago</returns>
        [HttpPost("consume")]
        public async Task<IActionResult> Consume([FromBody] HermesPayRequest request)
        {
            var resultado = await _finCorePayService.ProccesFinCorePay(request, User);

            if (!resultado.Exitoso)
            {
                return BadRequest(new
                {
                    Exito = false,
                    Mensaje = resultado.Mensaje
                });
            }

            return Ok(new
            {
                Exito = true,
                Mensaje = resultado.Mensaje
            });
        }
    }
}
