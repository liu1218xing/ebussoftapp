using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using EbusSoft.Configuration;
using EbusSoft.Web;

namespace EbusSoft.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class EbusSoftDbContextFactory : IDesignTimeDbContextFactory<EbusSoftDbContext>
    {
        public EbusSoftDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EbusSoftDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            EbusSoftDbContextConfigurer.Configure(builder, configuration.GetConnectionString(EbusSoftConsts.ConnectionStringName));

            return new EbusSoftDbContext(builder.Options);
        }
    }
}
