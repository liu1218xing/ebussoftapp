using System.Threading.Tasks;
using EbusSoft.Configuration.Dto;

namespace EbusSoft.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
