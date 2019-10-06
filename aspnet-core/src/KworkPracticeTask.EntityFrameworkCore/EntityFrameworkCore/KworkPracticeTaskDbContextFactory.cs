using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using KworkPracticeTask.Configuration;
using KworkPracticeTask.Web;

namespace KworkPracticeTask.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class KworkPracticeTaskDbContextFactory : IDesignTimeDbContextFactory<KworkPracticeTaskDbContext>
    {
        public KworkPracticeTaskDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<KworkPracticeTaskDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            KworkPracticeTaskDbContextConfigurer.Configure(builder, configuration.GetConnectionString(KworkPracticeTaskConsts.ConnectionStringName));

            return new KworkPracticeTaskDbContext(builder.Options);
        }
    }
}
