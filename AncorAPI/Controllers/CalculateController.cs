using Microsoft.AspNetCore.Mvc;
using AncorAPI.Models;
using AncorAPI.Repository;

namespace AncorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        private readonly ITransferRepository _transferRepository;

        public CalculateController(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }
        [HttpGet]
        public async Task<CalculationResult> Get()
        {
            decimal salary = 1000000;

            var resCollection = await _transferRepository.Get();
            var creditAmount = resCollection.Sum(o => o.CreditAmount);
            var debtAmount = resCollection.Sum(d => d.DebtAmount);

            var amount = creditAmount - debtAmount;

            
            CalculationResult obj = new CalculationResult();
            obj.Amount = amount;

            if (amount > salary) 
            {
                obj.Status = "yellow";
                
            }

            return obj;
        }
    }
}
