using System.Collections.Generic;
using KworkPracticeTask.Roles.Dto;
using KworkPracticeTask.Users.Dto;

namespace KworkPracticeTask.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
