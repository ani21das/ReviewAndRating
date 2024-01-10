using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ReviewAndRating.EntityFrameworkCore
{
    public static class ReviewAndRatingDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ReviewAndRatingDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ReviewAndRatingDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
