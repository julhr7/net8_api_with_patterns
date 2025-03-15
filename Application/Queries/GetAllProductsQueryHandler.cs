using MediatR;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Interfaces;
using System.Threading.Tasks;
using System.Threading;

namespace Application.Queries
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.Products.GetAllAsync();
        }
    }
}
