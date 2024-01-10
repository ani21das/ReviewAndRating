using System.Threading.Tasks;
using ReviewAndRating.Configuration.Dto;

namespace ReviewAndRating.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
