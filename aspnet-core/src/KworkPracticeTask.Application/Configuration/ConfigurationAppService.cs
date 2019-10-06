using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using KworkPracticeTask.Configuration.Dto;

namespace KworkPracticeTask.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : KworkPracticeTaskAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
