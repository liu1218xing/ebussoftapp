using Abp.Runtime.Validation;
using EbusSoft.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbusSoft.Base.BusCompanies.Dto
{
    public class GetBusCompanyInput : PagedAndSortedInputDto, IShouldNormalize
    {
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "id";
            }
        }

        public string Filter { get; set; }
    }
}
