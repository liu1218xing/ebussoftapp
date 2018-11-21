using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using EbusSoft.Lines;
using EbusSoft.Stations;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbusSoft.LineStations
{
    public class LineStation : FullAuditedEntity<long>
    {
        public long LineId { get; set; }
        public Line Line { get; set; }
        public long StationId { get; set; }
        public Station Station { get; set; }
    }
}
