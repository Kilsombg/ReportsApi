using MediatR;
using ReportsDomain;

namespace ReportsApi.Queries
{
    public class GetClientQuery : IRequest<Client>
    {
        public int Id { get; set; }
    }
}
