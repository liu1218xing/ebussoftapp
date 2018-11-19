using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EbusSoft.Stations
{
    public class Station: FullAuditedEntity
    {
        public const int MaxDescriptionLength = 5000;

        public string Code { get; set; }
        public string Name { get; set; }
        public string DhoneticAlphabet { get; set; }
        public string Address { get; set; }
        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; }
    }
}
