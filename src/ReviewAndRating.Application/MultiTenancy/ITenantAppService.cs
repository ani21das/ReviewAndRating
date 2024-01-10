using Abp.Application.Services;
using ReviewAndRating.MultiTenancy.Dto;

namespace ReviewAndRating.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

