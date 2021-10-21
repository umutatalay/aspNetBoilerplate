using System.Threading.Tasks;
using Abp.Application.Services;
using Umut.Sessions.Dto;

namespace Umut.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
