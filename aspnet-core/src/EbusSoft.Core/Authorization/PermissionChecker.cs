using Abp.Authorization;
using EbusSoft.Authorization.Roles;
using EbusSoft.Authorization.Users;

namespace EbusSoft.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
