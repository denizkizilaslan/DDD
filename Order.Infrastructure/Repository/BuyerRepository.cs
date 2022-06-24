using Order.Application.Repository;
using System.Threading.Tasks;

namespace Order.Infrastructure.Repository
{
    public class BuyerRepository : IBuyerRepository
    {
        public Task<int> SaveChanges()
        {
            return Task.FromResult(1);
        }
    }
}
