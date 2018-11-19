using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using EbusSoft.Authorization.Roles;
using EbusSoft.Authorization.Users;
using EbusSoft.MultiTenancy;

namespace EbusSoft.EntityFrameworkCore
{
    public class EbusSoftDbContext : AbpZeroDbContext<Tenant, Role, User, EbusSoftDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public EbusSoftDbContext(DbContextOptions<EbusSoftDbContext> options)
            : base(options)
        {
        }
    }
}
