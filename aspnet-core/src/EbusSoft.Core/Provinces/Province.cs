using Abp.Domain.Entities.Auditing;
using EbusSoft.Cities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbusSoft.Provinces
{
    public class Province : FullAuditedEntity<long>
    {
        
        public string Code { get; set; }
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
