using Abp.AspNetCore.Mvc.ViewComponents;

namespace KworkPracticeTask.Web.Views
{
    public abstract class KworkPracticeTaskViewComponent : AbpViewComponent
    {
        protected KworkPracticeTaskViewComponent()
        {
            LocalizationSourceName = KworkPracticeTaskConsts.LocalizationSourceName;
        }
    }
}
