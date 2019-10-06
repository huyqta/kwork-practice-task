using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace KworkPracticeTask.Web.Views
{
    public abstract class KworkPracticeTaskRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected KworkPracticeTaskRazorPage()
        {
            LocalizationSourceName = KworkPracticeTaskConsts.LocalizationSourceName;
        }
    }
}
