using MediatR;
using MediatRDemo.Queries.GetAll;
using MediatRDemo.Queries.GetById;
using Microsoft.AspNetCore.Mvc;

namespace MediatRDemo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await mediator.Send(new GetAllProductsQuery()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            var result = await mediator.Send(new GetProductByIdQuery(id));
            return result == null ? NotFound() : Ok(result);
        }
    }
}
