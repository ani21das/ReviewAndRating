using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ReviewAndRating.Authorization;

namespace ReviewAndRating
{
    [DependsOn(
        typeof(ReviewAndRatingCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ReviewAndRatingApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ReviewAndRatingAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ReviewAndRatingApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
