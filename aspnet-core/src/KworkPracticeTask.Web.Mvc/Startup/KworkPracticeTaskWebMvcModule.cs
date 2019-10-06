using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using KworkPracticeTask.Configuration;

namespace KworkPracticeTask.Web.Startup
{
    [DependsOn(typeof(KworkPracticeTaskWebCoreModule))]
    public class KworkPracticeTaskWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public KworkPracticeTaskWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<KworkPracticeTaskNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(KworkPracticeTaskWebMvcModule).GetAssembly());
        }
    }
}
