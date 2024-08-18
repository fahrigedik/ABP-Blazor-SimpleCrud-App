using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SimpleCrudApplication.Data;
using Volo.Abp.DependencyInjection;

namespace SimpleCrudApplication.EntityFrameworkCore;

public class EntityFrameworkCoreSimpleCrudApplicationDbSchemaMigrator
    : ISimpleCrudApplicationDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSimpleCrudApplicationDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SimpleCrudApplicationDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SimpleCrudApplicationDbContext>()
            .Database
            .MigrateAsync();
    }
}
