using Microsoft.AspNetCore.Mvc;
using AncorAPI.Models;
using AncorAPI.Repository;

namespace AncorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferController: ControllerBase
    {
        private readonly ITransferRepository _transferRepository;
        public TransferController(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<Transfer>> Get() 
        {
            return await _transferRepository.Get();
        }
    }   
}
