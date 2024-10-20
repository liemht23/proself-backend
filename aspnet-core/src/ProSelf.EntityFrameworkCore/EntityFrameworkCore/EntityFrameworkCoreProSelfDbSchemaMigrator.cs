using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProSelf.Data;
using Volo.Abp.DependencyInjection;

namespace ProSelf.EntityFrameworkCore;

public class EntityFrameworkCoreProSelfDbSchemaMigrator
    : IProSelfDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreProSelfDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ProSelfDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ProSelfDbContext>()
            .Database
            .MigrateAsync();
    }
}
