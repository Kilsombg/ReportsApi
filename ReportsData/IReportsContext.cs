using Microsoft.EntityFrameworkCore;
using ReportsDomain;

namespace ReportsData
{
    public interface IReportsContext
    {
        DbSet<Client> CLients { get;}
        DbSet<ClientConfig> ClientsConfig { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}