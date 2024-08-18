using Volo.Abp.Modularity;

namespace SimpleCrudApplication;

public abstract class SimpleCrudApplicationApplicationTestBase<TStartupModule> : SimpleCrudApplicationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
