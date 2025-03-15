using Domain.Entities;
using Domain.Repositories;
using Domain.Interfaces;
using System;

namespace Infrastructure.Factories
{
    public class ProductFactory : IProductFactory
    {
        public Product CreateProduct(
        string productName,
        string productTypeName,
        long numeracioTerminal,
        DateTime soldAt,
        string customerId)
        {
            return new Product
            {
                ProductName = productName,
                ProductTypeName = productTypeName,
                NumeracioTerminal = numeracioTerminal,
                SoldAt = soldAt,
                CustomerId = customerId
            };
        }
    }
}
