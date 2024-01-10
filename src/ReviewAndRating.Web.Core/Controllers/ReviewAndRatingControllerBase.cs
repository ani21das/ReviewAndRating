using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ReviewAndRating.Controllers
{
    public abstract class ReviewAndRatingControllerBase: AbpController
    {
        protected ReviewAndRatingControllerBase()
        {
            LocalizationSourceName = ReviewAndRatingConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
