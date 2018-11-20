using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using EbusSoft.Lines;
using EbusSoft.Stations;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbusSoft.LineStations
{
    public class LineStation : FullAuditedEntity
    {
        public int LineId { get; set; }
        public Line Line { get; set; }
        public int StationId { get; set; }
        public Station Station { get; set; }
    }
}
