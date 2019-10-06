using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using KworkPracticeTask.Authorization;

namespace KworkPracticeTask
{
    [DependsOn(
        typeof(KworkPracticeTaskCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class KworkPracticeTaskApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<KworkPracticeTaskAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(KworkPracticeTaskApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
