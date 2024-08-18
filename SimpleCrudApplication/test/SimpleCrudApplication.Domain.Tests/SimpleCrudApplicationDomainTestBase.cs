using Volo.Abp.Modularity;

namespace SimpleCrudApplication;

/* Inherit from this class for your domain layer tests. */
public abstract class SimpleCrudApplicationDomainTestBase<TStartupModule> : SimpleCrudApplicationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
