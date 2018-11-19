using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EbusSoft.Roles.Dto;
using EbusSoft.Users.Dto;

namespace EbusSoft.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
