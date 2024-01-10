using Abp.Application.Services.Dto;

namespace ReviewAndRating.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

