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
        public ICollection<Line> Lines { get; set; }
        public int StationIdG { get; set; }
        public ICollection<Station> Stations { get; set; }
    }
}
