using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ReviewAndRating.Authorization.Roles;
using ReviewAndRating.Authorization.Users;
using ReviewAndRating.MultiTenancy;

namespace ReviewAndRating.EntityFrameworkCore
{
    public class ReviewAndRatingDbContext : AbpZeroDbContext<Tenant, Role, User, ReviewAndRatingDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ReviewAndRatingDbContext(DbContextOptions<ReviewAndRatingDbContext> options)
            : base(options)
        {
        }
    }
}
