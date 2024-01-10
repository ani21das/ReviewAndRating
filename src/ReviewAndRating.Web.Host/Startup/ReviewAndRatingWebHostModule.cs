using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ReviewAndRating.Configuration;

namespace ReviewAndRating.Web.Host.Startup
{
    [DependsOn(
       typeof(ReviewAndRatingWebCoreModule))]
    public class ReviewAndRatingWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ReviewAndRatingWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ReviewAndRatingWebHostModule).GetAssembly());
        }
    }
}
