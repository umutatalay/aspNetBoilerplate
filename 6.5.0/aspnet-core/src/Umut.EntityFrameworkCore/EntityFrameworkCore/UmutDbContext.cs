using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Umut.Authorization.Roles;
using Umut.Authorization.Users;
using Umut.MultiTenancy;

namespace Umut.EntityFrameworkCore
{
    public class UmutDbContext : AbpZeroDbContext<Tenant, Role, User, UmutDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public UmutDbContext(DbContextOptions<UmutDbContext> options)
            : base(options)
        {
        }
    }
}
