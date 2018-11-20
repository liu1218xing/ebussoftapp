using Abp.Runtime.Validation;
using EbusSoft.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbusSoft.Provinces.Dto
{
    public class GetProvincesInput : PagedAndSortedInputDto, IShouldNormalize
    {
        public string Filter { get; set; }

        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "id";
            }
        }
    }
}
