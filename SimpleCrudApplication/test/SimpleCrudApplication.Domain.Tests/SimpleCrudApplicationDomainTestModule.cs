using Volo.Abp.Modularity;

namespace SimpleCrudApplication;

[DependsOn(
    typeof(SimpleCrudApplicationDomainModule),
    typeof(SimpleCrudApplicationTestBaseModule)
)]
public class SimpleCrudApplicationDomainTestModule : AbpModule
{

}
