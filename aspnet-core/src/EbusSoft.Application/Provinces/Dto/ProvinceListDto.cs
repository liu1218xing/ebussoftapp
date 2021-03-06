﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using EbusSoft.Cities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbusSoft.Provinces.Dto
{
    [AutoMapFrom(typeof(Province))]
   public class ProvinceListDto : EntityDto<long>, IHasCreationTime
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; }
        
        public DateTime CreationTime { get; set; }
        
    }
}
