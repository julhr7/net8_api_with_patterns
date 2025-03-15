using Domain.Entities;
using System.Threading.Tasks;

namespace Observers
{
    public class ProductNotifier : IProductObserver
    {
        public Task Update(Product product)
        {
            // Lógica para notificar sobre cambios en el producto
            return Task.CompletedTask;
        }
    }
}
