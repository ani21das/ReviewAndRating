using Abp.AutoMapper;
using ReviewAndRating.Models.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewAndRating.Movies.Dtos
{
    [AutoMapFrom(typeof(Movie))] // Map FROM Movie entity
    public class MovieDto
    {
        public Guid Id { get; set; }
        public int TenantId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ReleaseYear { get; set; }
        public double Rating { get; set; }
        public string Genre { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }

        // Other properties...
    }
}
