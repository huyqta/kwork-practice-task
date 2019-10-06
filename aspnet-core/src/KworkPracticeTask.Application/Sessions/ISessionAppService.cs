using System.Threading.Tasks;
using Abp.Application.Services;
using KworkPracticeTask.Sessions.Dto;

namespace KworkPracticeTask.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
