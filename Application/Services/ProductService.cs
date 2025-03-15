﻿﻿﻿using System.Collections.Generic;
using System; // Agregar esta línea para usar ArgumentException
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _unitOfWork.Products.GetAllAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _unitOfWork.Products.GetByIdAsync(id);
        }

        public async Task<int> CreateProductAsync(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.ProductName) || string.IsNullOrWhiteSpace(product.ProductTypeName))
            {
                throw new ArgumentException("El nombre del producto y el tipo de producto son obligatorios.");
            }

            await _unitOfWork.Products.AddAsync(product);
            await _unitOfWork.CommitAsync();
            return product.Id;
        }


        public async Task UpdateProductAsync(Product product)
        {
            _unitOfWork.Products.UpdateAsync(product);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _unitOfWork.Products.GetByIdAsync(id);
            if (product != null)
            {
                await _unitOfWork.Products.DeleteAsync(id);
                await _unitOfWork.CommitAsync();
            }
        }
    }
}
