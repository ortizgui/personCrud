using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Person.Domain.Commands;

namespace Person.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PersonPostCommand command)
        {
            var serviceResponse = await _mediator.Send(command);
            return Ok(serviceResponse);
        }

        [HttpGet("{DocId}")]
        public async Task<IActionResult> GetPersonByDocId([FromRoute] PersonGetByDocIdCommand command)
        {
            var serviceResponse = await _mediator.Send(command);
            return Ok(serviceResponse);
        }

        [HttpPut]
        public async Task<IActionResult> PutPerson([FromBody] PersonPutCommand command)
        {
            var serviceResponse = await _mediator.Send(command);
            return Ok(serviceResponse);
        }

        [HttpDelete("{DocId}")]
        public async Task<IActionResult> DeletePersonByDocId([FromRoute] PersonDeleteByDocIdCommand command)
        {
            var serviceResponse = await _mediator.Send(command);
            return Ok(serviceResponse);
        }
    }
}