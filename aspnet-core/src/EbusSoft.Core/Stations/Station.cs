using Abp.Domain.Entities.Auditing;
using EbusSoft.Cities;
using EbusSoft.LineStations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EbusSoft.Stations
{
    public class Station: FullAuditedEntity<long>
    {
        public const int MaxDescriptionLength = 5000;

        public string Code { get; set; }
        public string Name { get; set; }
        public string DhoneticAlphabet { get; set; }
        public string Address { get; set; }
        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; }
        public ICollection<LineStation> LineStations { get; set; }
        public long CityId { get; set; }
        public City City { get; set; }
    }
}
