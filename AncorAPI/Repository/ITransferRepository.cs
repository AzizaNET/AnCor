using AncorAPI.Models;

namespace AncorAPI.Repository
{
    public interface ITransferRepository
    {
        Task<IEnumerable<Transfer>> Get();

    }
}
