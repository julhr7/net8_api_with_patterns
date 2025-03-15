using Domain.Entities;
using System.Threading.Tasks;

namespace Observers
{
    public interface IProductObserver
    {
        Task Update(Product product);
    }
}
