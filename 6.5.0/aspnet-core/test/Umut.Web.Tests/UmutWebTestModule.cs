using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Umut.EntityFrameworkCore;
using Umut.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Umut.Web.Tests
{
    [DependsOn(
        typeof(UmutWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class UmutWebTestModule : AbpModule
    {
        public UmutWebTestModule(UmutEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(UmutWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(UmutWebMvcModule).Assembly);
        }
    }
}