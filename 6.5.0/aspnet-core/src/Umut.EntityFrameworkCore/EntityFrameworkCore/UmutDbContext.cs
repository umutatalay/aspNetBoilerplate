using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Umut.Authorization.Roles;
using Umut.Authorization.Users;
using Umut.MultiTenancy;

using System.Reflection;
using Umut.News;

namespace Umut.EntityFrameworkCore
{
    public class UmutDbContext : AbpZeroDbContext<Tenant, Role, User, UmutDbContext>
    {

        /* Define a DbSet for each entity of the application */

        public DbSet<New> News { get; set; }

        public UmutDbContext(DbContextOptions<UmutDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
    }
    }
}
