using MediatR;
using Microsoft.EntityFrameworkCore;
using ReportsApi.Queries;
using ReportsData;
using ReportsDomain;

namespace ReportsApi.Commands.CreateClient
{
    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, int>
    {
        private readonly IReportsContext reportContext;

        public CreateClientCommandHandler(IReportsContext reportContext)
        {
            this.reportContext = reportContext;
        }

        public async Task<int> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            var entity = new Client
            {
                ConfigId = request.ConfigId,
                DDS = request.DDS,
                Name = request.Name,
            };
            await reportContext.CLients.AddAsync(entity);

            return entity.Id;
        }
    }
}
