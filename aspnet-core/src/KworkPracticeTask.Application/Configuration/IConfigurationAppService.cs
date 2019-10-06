using System.Threading.Tasks;
using KworkPracticeTask.Configuration.Dto;

namespace KworkPracticeTask.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
