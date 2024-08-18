using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SimpleCrudApplication.Data;

/* This is used if database provider does't define
 * ISimpleCrudApplicationDbSchemaMigrator implementation.
 */
public class NullSimpleCrudApplicationDbSchemaMigrator : ISimpleCrudApplicationDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
