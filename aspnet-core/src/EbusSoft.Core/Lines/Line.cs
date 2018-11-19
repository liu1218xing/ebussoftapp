using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbusSoft.Lines
{
    public class Line: FullAuditedEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string DhoneticAlphabet { get; set; }

        public string StartStationCode { get; set; }
        public string EndStationCode { get; set; }
    }
}
