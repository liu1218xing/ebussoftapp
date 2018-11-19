using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace EbusSoft.Controllers
{
    public abstract class EbusSoftControllerBase: AbpController
    {
        protected EbusSoftControllerBase()
        {
            LocalizationSourceName = EbusSoftConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
