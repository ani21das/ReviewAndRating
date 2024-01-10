using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ReviewAndRating.Authorization.Roles;
using ReviewAndRating.Authorization.Users;
using ReviewAndRating.MultiTenancy;
using ReviewAndRating.Models.Movies;

namespace ReviewAndRating.EntityFrameworkCore
{
    public class ReviewAndRatingDbContext : AbpZeroDbContext<Tenant, Role, User, ReviewAndRatingDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Movie> Movies { get; set; }
        public ReviewAndRatingDbContext(DbContextOptions<ReviewAndRatingDbContext> options)
            : base(options)
        {
        }
    }
}
