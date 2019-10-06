using Abp.Authorization;
using KworkPracticeTask.Authorization.Roles;
using KworkPracticeTask.Authorization.Users;

namespace KworkPracticeTask.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
