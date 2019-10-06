using Abp.AutoMapper;
using KworkPracticeTask.Sessions.Dto;

namespace KworkPracticeTask.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
