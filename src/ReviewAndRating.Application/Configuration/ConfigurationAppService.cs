using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ReviewAndRating.Configuration.Dto;

namespace ReviewAndRating.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ReviewAndRatingAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
