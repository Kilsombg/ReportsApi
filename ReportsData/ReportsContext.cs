using Microsoft.EntityFrameworkCore;
using ReportsDomain;

namespace ReportsData
{
    public class ReportsContext : DbContext, IReportsContext
    {
        public DbSet<Client> CLients { get; set; }
        public DbSet<ClientConfig> ClientsConfig { get; set; }

        public ReportsContext(DbContextOptions<ReportsContext> options) : base(options) { }
    }
}