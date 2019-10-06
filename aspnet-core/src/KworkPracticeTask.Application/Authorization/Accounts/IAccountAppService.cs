using System.Threading.Tasks;
using Abp.Application.Services;
using KworkPracticeTask.Authorization.Accounts.Dto;

namespace KworkPracticeTask.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
