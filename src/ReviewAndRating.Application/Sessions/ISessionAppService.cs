using System.Threading.Tasks;
using Abp.Application.Services;
using ReviewAndRating.Sessions.Dto;

namespace ReviewAndRating.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
