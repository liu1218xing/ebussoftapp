using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using EbusSoft.Base.BusCompanies.Dto;

namespace EbusSoft.Base.BusCompanies
{
    public class BusCompanyAppService : EbusSoftAppServiceBase, IBusCompanyAppService
    {
        private readonly IRepository<BusCompany, long> _repository;
        public BusCompanyAppService(IRepository<BusCompany, long> repository)
        {
            _repository = repository;
        }

        public async Task CreateOrUpdateBusCompany(CreateOrUpdateBusCompanyInput input)
        {
            if (input.BusCompany.Id.HasValue)
            {
                await UpdateBusCompany(input);
            }
            else
            {
                await CreateBusCompany(input);
            }
        }

        protected async Task UpdateBusCompany(CreateOrUpdateBusCompanyInput input)
        {
            var entity = await _repository.GetAsync(input.BusCompany.Id.Value);
            ObjectMapper.Map(input.BusCompany, entity);
            //var updateEntity = ObjectMapper.Map<BusCompany>(input.BusCompany);
            await _repository.UpdateAsync(entity);
            //await CurrentUnitOfWork.SaveChangesAsync(); //It's done to get Id of the edition.
            //throw new NotImplementedException();
        }

        protected async Task CreateBusCompany(CreateOrUpdateBusCompanyInput input)
        {
            var entity = ObjectMapper.Map<BusCompany>(input.BusCompany);
            await _repository.InsertAndGetIdAsync(entity);
        }

        public Task DeleteBusCompany(EntityDto<long> input)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<BusCompanyListDto>> GetBusCompanies(GetBusCompanyInput input)
        {
            throw new NotImplementedException();
        }

        public Task<BusCompanyListDto> GetBusCompanyById(EntityDto<long> input)
        {
            throw new NotImplementedException();
        }
    }
}
