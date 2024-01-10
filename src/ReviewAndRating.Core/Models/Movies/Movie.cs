using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewAndRating.Models.Movies
{
    public class Movie : FullAuditedEntity<Guid>, IMustHaveTenant
    {
        public int TenantId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ReleaseYear { get; set; }
        public double Rating { get; set; }
        public string Genre { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }

    }
}
