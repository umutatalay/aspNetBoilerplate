using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Umut.Authorization;

namespace Umut
{
    [DependsOn(
        typeof(UmutCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class UmutApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<UmutAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(UmutApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
