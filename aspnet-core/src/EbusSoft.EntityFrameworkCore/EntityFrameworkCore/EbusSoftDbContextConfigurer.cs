using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace EbusSoft.EntityFrameworkCore
{
    public static class EbusSoftDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<EbusSoftDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<EbusSoftDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
