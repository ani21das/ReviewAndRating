using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ReviewAndRating.EntityFrameworkCore;
using ReviewAndRating.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ReviewAndRating.Web.Tests
{
    [DependsOn(
        typeof(ReviewAndRatingWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ReviewAndRatingWebTestModule : AbpModule
    {
        public ReviewAndRatingWebTestModule(ReviewAndRatingEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ReviewAndRatingWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ReviewAndRatingWebMvcModule).Assembly);
        }
    }
}