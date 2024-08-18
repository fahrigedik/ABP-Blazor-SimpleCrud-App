using SimpleCrudApplication.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace SimpleCrudApplication.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SimpleCrudApplicationEntityFrameworkCoreModule),
    typeof(SimpleCrudApplicationApplicationContractsModule)
)]
public class SimpleCrudApplicationDbMigratorModule : AbpModule
{
}
