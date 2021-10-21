using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Umut.EntityFrameworkCore
{
    public static class UmutDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<UmutDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<UmutDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
