using Domain.Entities;
using Observers;

namespace Presentacion.Subjects
{
    public class ProductSubject
    {
        private readonly List<IProductObserver> _observers = new();

        public void Attach(IProductObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IProductObserver observer)
        {
            _observers.Remove(observer);
        }

        public async Task Notify(Product product)
        {
            foreach (var observer in _observers)
            {
                await observer.Update(product);
            }
        }

        public void ClearObservers() // Método adicional para limpiar la lista de observadores
        {
            _observers.Clear();
        }
    }
}
