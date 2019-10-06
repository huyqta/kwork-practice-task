using Abp.Application.Services.Dto;

namespace KworkPracticeTask.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

