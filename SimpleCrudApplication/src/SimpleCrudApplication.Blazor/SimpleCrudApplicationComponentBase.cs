using SimpleCrudApplication.Localization;
using Volo.Abp.AspNetCore.Components;

namespace SimpleCrudApplication.Blazor;

public abstract class SimpleCrudApplicationComponentBase : AbpComponentBase
{
    protected SimpleCrudApplicationComponentBase()
    {
        LocalizationResource = typeof(SimpleCrudApplicationResource);
    }
}
