using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using KworkPracticeTask.Authorization.Roles;
using KworkPracticeTask.Authorization.Users;
using KworkPracticeTask.MultiTenancy;

namespace KworkPracticeTask.EntityFrameworkCore
{
    public class KworkPracticeTaskDbContext : AbpZeroDbContext<Tenant, Role, User, KworkPracticeTaskDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public KworkPracticeTaskDbContext(DbContextOptions<KworkPracticeTaskDbContext> options)
            : base(options)
        {
        }
    }
}
