using EbusSoft.Cities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EbusSoft.Provinces.Dto
{
    public class CreateOrUpdateProvinceInput
    {
        public ProvinceEditDto Province { get; set; }
    }
}
