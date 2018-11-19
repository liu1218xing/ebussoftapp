using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EbusSoft.Configuration;

namespace EbusSoft.Web.Host.Startup
{
    [DependsOn(
       typeof(EbusSoftWebCoreModule))]
    public class EbusSoftWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public EbusSoftWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EbusSoftWebHostModule).GetAssembly());
        }
    }
}
