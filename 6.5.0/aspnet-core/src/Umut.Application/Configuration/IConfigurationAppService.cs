using System.Threading.Tasks;
using Umut.Configuration.Dto;

namespace Umut.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
