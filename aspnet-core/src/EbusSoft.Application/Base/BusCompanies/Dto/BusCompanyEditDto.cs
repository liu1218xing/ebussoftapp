using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EbusSoft.Base.BusCompanies.Dto
{
    public class BusCompanyEditDto
    {
        public long? Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }
}
