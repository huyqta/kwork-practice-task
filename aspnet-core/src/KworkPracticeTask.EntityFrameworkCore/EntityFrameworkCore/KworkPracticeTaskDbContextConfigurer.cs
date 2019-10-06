using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace KworkPracticeTask.EntityFrameworkCore
{
    public static class KworkPracticeTaskDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<KworkPracticeTaskDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<KworkPracticeTaskDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
