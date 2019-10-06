using System.Collections.Generic;
using KworkPracticeTask.Roles.Dto;

namespace KworkPracticeTask.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
