﻿using MediatR;
using System; // Agregar esta línea para usar ArgumentException
using Domain.Entities;
using Domain.Interfaces;
using System.Threading.Tasks;
using System.Threading;

namespace Application.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateProductCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(request.ProductName) || string.IsNullOrWhiteSpace(request.ProductTypeName))
            {
                throw new ArgumentException("El nombre del producto y el tipo de producto son obligatorios.");
            }

            var product = new Product
            {
                ProductName = request.ProductName,
                ProductTypeName = request.ProductTypeName,
                NumeracioTerminal = request.NumeracioTerminal,
                SoldAt = request.SoldAt,
                CustomerId = request.CustomerId
            };

            await _unitOfWork.Products.AddAsync(product);
            await _unitOfWork.CommitAsync();
            return product.Id;
        }
    }
}
