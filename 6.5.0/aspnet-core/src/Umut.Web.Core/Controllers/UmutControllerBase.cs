using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Umut.Controllers
{
    public abstract class UmutControllerBase: AbpController
    {
        protected UmutControllerBase()
        {
            LocalizationSourceName = UmutConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
