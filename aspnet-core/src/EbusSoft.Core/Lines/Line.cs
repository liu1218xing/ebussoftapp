﻿using Abp.Domain.Entities.Auditing;
using EbusSoft.LineStations;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbusSoft.Lines
{
    public class Line: FullAuditedEntity<long>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string DhoneticAlphabet { get; set; }

        public string StartStationCode { get; set; }
        public string EndStationCode { get; set; }
        public ICollection<LineStation> LineStations { get; set; }
    }
}
