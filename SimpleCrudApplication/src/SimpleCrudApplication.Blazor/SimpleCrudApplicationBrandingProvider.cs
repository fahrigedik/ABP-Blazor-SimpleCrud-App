using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace SimpleCrudApplication.Blazor;

[Dependency(ReplaceServices = true)]
public class SimpleCrudApplicationBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SimpleCrudApplication";
}
