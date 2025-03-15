using MediatR;
using Domain.Entities;
using System.Collections.Generic;

namespace Application.Queries
{
    public class GetAllProductsQuery : IRequest<IEnumerable<Product>> { }
}
