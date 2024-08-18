using System.Threading.Tasks;

namespace SimpleCrudApplication.Data;

public interface ISimpleCrudApplicationDbSchemaMigrator
{
    Task MigrateAsync();
}
