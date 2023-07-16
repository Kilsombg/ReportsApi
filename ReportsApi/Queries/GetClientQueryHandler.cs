using MediatR;
using Microsoft.EntityFrameworkCore;
using ReportsData;
using ReportsDomain;

namespace ReportsApi.Queries
{
    public class GetClientQueryHandler : IRequestHandler<GetClientQuery, Client>
    {
        private readonly IReportsContext reportContext;

        public GetClientQueryHandler(IReportsContext reportContext)
        {
            this.reportContext = reportContext;
        }

        public async Task<Client> Handle(GetClientQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(reportContext.CLients.FirstOrDefault());
           // return await reportContext.CLients.Where(c => c.Id == request.Id).SingleOrDefaultAsync();
        }
    }
}
