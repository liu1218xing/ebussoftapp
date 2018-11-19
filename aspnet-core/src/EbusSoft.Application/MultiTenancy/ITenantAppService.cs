using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EbusSoft.MultiTenancy.Dto;

namespace EbusSoft.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
