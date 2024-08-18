using SimpleCrudApplication.Localization;
using Volo.Abp.Application.Services;

namespace SimpleCrudApplication;

/* Inherit your application services from this class.
 */
public abstract class SimpleCrudApplicationAppService : ApplicationService
{
    protected SimpleCrudApplicationAppService()
    {
        LocalizationResource = typeof(SimpleCrudApplicationResource);
    }
}
