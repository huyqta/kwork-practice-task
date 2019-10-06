using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using KworkPracticeTask.MultiTenancy;

namespace KworkPracticeTask.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
