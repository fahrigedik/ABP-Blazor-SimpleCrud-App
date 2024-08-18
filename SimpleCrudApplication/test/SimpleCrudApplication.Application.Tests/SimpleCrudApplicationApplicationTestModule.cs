using Volo.Abp.Modularity;

namespace SimpleCrudApplication;

[DependsOn(
    typeof(SimpleCrudApplicationApplicationModule),
    typeof(SimpleCrudApplicationDomainTestModule)
)]
public class SimpleCrudApplicationApplicationTestModule : AbpModule
{

}
