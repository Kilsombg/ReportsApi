using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReportsApi.Commands.CreateClient;
using ReportsApi.Queries;
using ReportsDomain;

namespace ReportsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientConfigController : ControllerBase
    {
        private readonly IMediator mediator;

        public ClientConfigController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost()]
        public async Task<int> CreateClientConfig([FromBody] CreateClientConfigCommand command)
        {
            return await mediator.Send(command);
        }
    }
}
