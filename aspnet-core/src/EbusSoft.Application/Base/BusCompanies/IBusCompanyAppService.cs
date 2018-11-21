using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EbusSoft.Base.BusCompanies.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EbusSoft.Base.BusCompanies
{
    public interface IBusCompanyAppService: IApplicationService
    {
        Task<PagedResultDto<BusCompanyListDto>> GetBusCompanies(GetBusCompanyInput input);
        Task<BusCompanyListDto> GetBusCompanyById(EntityDto<long> input);

        Task CreateOrUpdateBusCompany(CreateOrUpdateBusCompanyInput input);
        Task DeleteBusCompany(EntityDto<long> input);

    }
}
