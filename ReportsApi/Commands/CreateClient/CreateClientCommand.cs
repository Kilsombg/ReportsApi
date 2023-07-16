using MediatR;
using ReportsDomain;

namespace ReportsApi.Commands.CreateClient
{
    public class CreateClientCommand : IRequest<int>
    {
        public int ConfigId { get; set; }
        public string? Name { get; set; }
        public string? DDS { get; set; }
    }
}
