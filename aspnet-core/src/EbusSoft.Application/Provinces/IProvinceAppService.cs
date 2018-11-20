using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EbusSoft.Dto;
using EbusSoft.Provinces.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EbusSoft.Provinces
{
    public interface IProvinceAppService : IApplicationService
    {
        /// <summary>
        /// 获取省份信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<ProvinceListDto>> GetProvince(GetProvincesInput input);
        Task<ProvinceListDto> GetProvinceById(EntityDto<long> input);
        Task<FileDto> GetProvincesToExcel();
        Task DeleteProvince(EntityDto<long> input);

        Task CreateOrUpdateProvince(CreateOrUpdateProvinceInput input);

    }
}
