using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using KworkPracticeTask.Configuration;

namespace KworkPracticeTask.Web.Host.Startup
{
    [DependsOn(
       typeof(KworkPracticeTaskWebCoreModule))]
    public class KworkPracticeTaskWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public KworkPracticeTaskWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(KworkPracticeTaskWebHostModule).GetAssembly());
        }
    }
}
