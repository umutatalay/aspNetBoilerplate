using Abp.Authorization;
using Umut.Authorization.Roles;
using Umut.Authorization.Users;

namespace Umut.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
