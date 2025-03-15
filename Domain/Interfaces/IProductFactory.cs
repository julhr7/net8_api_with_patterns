using Domain.Entities;
using System;

namespace Domain.Interfaces
{
    public interface IProductFactory
    {
        Product CreateProduct(
            string productName,
            string productTypeName,
            long numeracioTerminal,
            DateTime soldAt,
            string customerId);
    }
}
