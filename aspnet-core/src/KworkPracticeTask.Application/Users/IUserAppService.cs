using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using KworkPracticeTask.Roles.Dto;
using KworkPracticeTask.Users.Dto;

namespace KworkPracticeTask.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
