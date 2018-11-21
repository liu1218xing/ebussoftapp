using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbusSoft.Base.BusCompanies
{
    public class BusCompany:FullAuditedEntity<long>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }
}
