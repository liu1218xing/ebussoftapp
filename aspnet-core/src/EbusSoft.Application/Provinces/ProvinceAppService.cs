using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using EbusSoft.Dto;
using EbusSoft.Provinces.Dto;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using Abp.Linq.Extensions;

namespace EbusSoft.Provinces
{
    public class ProvinceAppService : EbusSoftAppServiceBase, IProvinceAppService
    {
        private readonly IRepository<Province,long> _provinceRepository;
        
        public ProvinceAppService(IRepository<Province,long> provinceRepository)
        {
            _provinceRepository = provinceRepository;
        }

        public async Task CreateOrUpdateProvince(CreateOrUpdateProvinceInput input)
        {
            if (!input.Province.Id.HasValue)
            {
                 await CreateProvinceAsync(input);
            }
            else
            {
                 await UpdateProvinceAsync(input);
            }
        }

        private  async Task UpdateProvinceAsync(CreateOrUpdateProvinceInput input)
        {
           
                var entity = await _provinceRepository.GetAsync(input.Province.Id.Value);
                //var updatingProvince = ObjectMapper.Map<Province>(input.Province);

                ObjectMapper.Map(input.Province, entity);
                //var updatingProvince = ObjectMapper.Map<Province>(input.Province);
                await _provinceRepository.UpdateAsync(entity);
            
           
        }

        private async Task CreateProvinceAsync(CreateOrUpdateProvinceInput input)
        {
            var province = ObjectMapper.Map<Province>(input.Province);
            await _provinceRepository.InsertAndGetIdAsync(province);
        }

        public async Task DeleteProvince(EntityDto<long> input)
        {
            
            await _provinceRepository.DeleteAsync(input.Id);
        }

        public async Task<PagedResultDto<ProvinceListDto>> GetProvince(GetProvincesInput input)
        {
            var query = _provinceRepository.GetAll();
            var privinceCount = await query.CountAsync();
            var provinces = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();

            var provinceListDto = ObjectMapper.Map<List<ProvinceListDto>>(provinces);
            return new PagedResultDto<ProvinceListDto>(
                privinceCount,
                provinceListDto
                );

            
        }

        public async Task<ProvinceListDto> GetProvinceById(EntityDto<long> input)
        {
            var query = await _provinceRepository.GetAsync(input.Id);
            

            return ObjectMapper.Map<ProvinceListDto>(query);
        }

        public Task<FileDto> GetProvincesToExcel()
        {
            throw new NotImplementedException();
        }

       
    }
}
