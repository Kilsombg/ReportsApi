using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ReportsDomain;
using System.Reflection;

namespace ReportsData
{
    public class ReportsContext : DbContext, IReportsContext
    {
        public DbSet<Client> CLients { get; set; }
        public DbSet<ClientConfig> ClientsConfig { get; set; }

        public ReportsContext() {}

        public ReportsContext(DbContextOptions<ReportsContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server = (localdb)\\mssqllocaldb; Database = ReportsDB; Trusted_Connection = True;");
            }
        }
    }
}