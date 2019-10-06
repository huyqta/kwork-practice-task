using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using KworkPracticeTask.EntityFrameworkCore.Seed;

namespace KworkPracticeTask.EntityFrameworkCore
{
    [DependsOn(
        typeof(KworkPracticeTaskCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class KworkPracticeTaskEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<KworkPracticeTaskDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        KworkPracticeTaskDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        KworkPracticeTaskDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(KworkPracticeTaskEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
