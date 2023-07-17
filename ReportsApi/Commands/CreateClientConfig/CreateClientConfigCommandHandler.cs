using MediatR;
using ReportsData;
using ReportsDomain;
using ReportsDomain.Events;

namespace ReportsApi.Commands.CreateClient
{
    public class CreateClientConfigCommandHandler : IRequestHandler<CreateClientConfigCommand, int>
    {
        private readonly IReportsContext reportContext;

        public CreateClientConfigCommandHandler(IReportsContext reportContext)
        {
            this.reportContext = reportContext;
        }

        public async Task<int> Handle(CreateClientConfigCommand request, CancellationToken cancellationToken)
        {
            var entity = new ClientConfig
            {
                permittedReport = request.permittedReport,
            };

            entity.AddDomainEvent(new ClientConfigEvent(entity));

            reportContext.ClientsConfig.Add(entity);
            await reportContext.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
