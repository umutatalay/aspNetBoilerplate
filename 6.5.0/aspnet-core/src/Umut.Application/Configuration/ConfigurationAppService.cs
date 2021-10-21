using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Umut.Configuration.Dto;

namespace Umut.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : UmutAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
