using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EbusSoft.Authorization;

namespace EbusSoft
{
    [DependsOn(
        typeof(EbusSoftCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class EbusSoftApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<EbusSoftAuthorizationProvider>();
            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(EbusSoftApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
