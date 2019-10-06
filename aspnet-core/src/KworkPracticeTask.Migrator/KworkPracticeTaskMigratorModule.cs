using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using KworkPracticeTask.Configuration;
using KworkPracticeTask.EntityFrameworkCore;
using KworkPracticeTask.Migrator.DependencyInjection;

namespace KworkPracticeTask.Migrator
{
    [DependsOn(typeof(KworkPracticeTaskEntityFrameworkModule))]
    public class KworkPracticeTaskMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public KworkPracticeTaskMigratorModule(KworkPracticeTaskEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(KworkPracticeTaskMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                KworkPracticeTaskConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(KworkPracticeTaskMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
