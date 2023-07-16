using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReportsApi.Commands.CreateClient;
using ReportsApi.Queries;
using ReportsDomain;

namespace ReportsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IMediator mediator;

        public ClientController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{Id}")]
        public async Task<Client> GetClient([FromRoute] GetClientQuery query)
        {
            return await mediator.Send(query);
        }

        [HttpPost()]
        public async Task<int> CreateClient([FromBody] CreateClientCommand command)
        {
            return await mediator.Send(command);
        }
    }
}
