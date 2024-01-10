using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ReviewAndRating.MultiTenancy;

namespace ReviewAndRating.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
