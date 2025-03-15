using Application.Commands;
using Domain.Interfaces;
using Application.Queries;
using Strategies;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Presentacion.Subjects;

namespace Presentacion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IProductFactory _productFactory;
        private readonly DiscountContext _discountContext;
        private readonly ProductSubject _productSubject;

        public ProductsController(IMediator mediator, IProductFactory productFactory, DiscountContext discountContext, ProductSubject productSubject)
        {
            _mediator = mediator;
            _productFactory = productFactory;
            _discountContext = discountContext;
            _productSubject = productSubject;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllProductsQuery();
            var products = await _mediator.Send(query);
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProductCommand command)
        {
            // Validar el estado del modelo
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Crear un nuevo producto utilizando la fábrica
            var product = _productFactory.CreateProduct(
                command.ProductName,
                command.ProductTypeName,
                command.NumeracioTerminal,
                command.SoldAt,
                command.CustomerId
            );
            await _productSubject.Notify(product); // Notificar a los observadores sobre el nuevo producto

            var productId = await _mediator.Send(command);
            return Ok(productId); // Devolver el ID del producto creado
        } // Cierre del método Post
    } // Cierre de la clase
}
