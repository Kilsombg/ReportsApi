using MediatR;
using ReportsDomain;

namespace ReportsApi.Commands.CreateClient
{
    public class CreateClientConfigCommand : IRequest<int>
    {
        public string? permittedReport { get; set; }
    }
}
