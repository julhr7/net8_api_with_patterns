using Domain.Entities;
using Domain.Repositories;
using System;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Product> Products { get; }
        Task<int> CommitAsync();
        void Dispose();
    }
}
