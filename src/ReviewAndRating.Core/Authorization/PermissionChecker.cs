using Abp.Authorization;
using ReviewAndRating.Authorization.Roles;
using ReviewAndRating.Authorization.Users;

namespace ReviewAndRating.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
