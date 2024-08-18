using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SimpleCrudApplication.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class SimpleCrudApplicationDbContextFactory : IDesignTimeDbContextFactory<SimpleCrudApplicationDbContext>
{
    public SimpleCrudApplicationDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        SimpleCrudApplicationEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<SimpleCrudApplicationDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new SimpleCrudApplicationDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../SimpleCrudApplication.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
