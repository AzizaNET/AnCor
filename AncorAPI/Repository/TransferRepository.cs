using AncorAPI.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AncorAPI.Repository
{
    public class TransferRepository: ITransferRepository
    {
        private readonly TransferDbContext _context;
        public TransferRepository(TransferDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Transfer>> Get() 
        {
            return await _context.Transfers.ToListAsync();
        }
    }

}
