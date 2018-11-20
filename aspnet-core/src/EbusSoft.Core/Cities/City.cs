using Abp.Domain.Entities.Auditing;
using EbusSoft.Provinces;
using EbusSoft.Stations;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbusSoft.Cities
{
    public class City: FullAuditedEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public long PrivinceId { get; set; }
        public Province Province { get; set; }
        public ICollection<Station> Stations { get; set; }
    }
}
