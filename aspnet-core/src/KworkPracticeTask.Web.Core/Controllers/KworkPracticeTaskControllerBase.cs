using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace KworkPracticeTask.Controllers
{
    public abstract class KworkPracticeTaskControllerBase: AbpController
    {
        protected KworkPracticeTaskControllerBase()
        {
            LocalizationSourceName = KworkPracticeTaskConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
