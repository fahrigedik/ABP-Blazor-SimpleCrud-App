using SimpleCrudApplication.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SimpleCrudApplication.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SimpleCrudApplicationController : AbpControllerBase
{
    protected SimpleCrudApplicationController()
    {
        LocalizationResource = typeof(SimpleCrudApplicationResource);
    }
}
