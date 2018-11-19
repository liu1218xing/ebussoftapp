using System.Threading.Tasks;
using Abp.Application.Services;
using EbusSoft.Authorization.Accounts.Dto;

namespace EbusSoft.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
