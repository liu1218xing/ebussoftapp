using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbusSoft.Base.BusCompanies.Dto
{
    public class BusCompanyListDto : EntityDto<long>,  IHasCreationTime
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
